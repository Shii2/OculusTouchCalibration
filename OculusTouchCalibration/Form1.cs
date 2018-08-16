using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Security.Principal;
using System.ServiceProcess;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace OculusTouchCalibration
{
    public partial class Form1 : Form
    {
        private const string LTOUCH = ".ltouch";
        private const string RTOUCH = ".rtouch";
        private const string OBJECT = ".object";

        private static CalibrationData loadedData;

        private static string appdataDirectory;
        private static string oculusDirectory;
        private static string oculusDeviceCachePath;
        private static string calibrationDirectory;
        private static string appDirectory;
        private static string backupDirectory;

        private static Dictionary<string, string> m_ControllerDict;
        private static byte[] endBytes;

        public Form1()
        {
            InitializeComponent();

            appdataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            oculusDirectory = Path.Combine(appdataDirectory, "Oculus");
            oculusDeviceCachePath = Path.Combine(oculusDirectory, "DeviceCache.json");
            calibrationDirectory = Path.Combine(oculusDirectory, "TouchCalibration");
            appDirectory = Path.Combine(appdataDirectory, "TouchDeadzoneTool");
            backupDirectory = Path.Combine(appDirectory, "Backup");

            Directory.CreateDirectory(appDirectory);
            Directory.CreateDirectory(backupDirectory);

            m_ControllerDict = new Dictionary<string, string>();

            BackupConfigs();

            FillControllerList();
        }

        // Copy calibration files to backup folder
        private void BackupConfigs()
        {
            string fileName = string.Empty;
            string destFile = string.Empty;

            if (Directory.Exists(calibrationDirectory))
            {
                string[] files = Directory.GetFiles(calibrationDirectory);

                foreach (string s in files)
                {
                    fileName = Path.GetFileName(s);
                    destFile = Path.Combine(backupDirectory, fileName);
                    if (!File.Exists(s))
                    {
                        File.Copy(s, destFile, false);
                    }
                }
            }
        }

        // Restore original json files from backup
        private void RestoreFromBackup()
        {
            string fileName = string.Empty;
            string destFile = string.Empty;

            if (Directory.Exists(backupDirectory))
            {
                string[] files = Directory.GetFiles(backupDirectory);

                foreach (string s in files)
                {
                    fileName = Path.GetFileName(s);
                    destFile = Path.Combine(calibrationDirectory, fileName);
                    File.Copy(s, destFile, true);
                }
            }
        }

        // Save changes to json files
        private void button1_Click(object sender, EventArgs e)
        {
            string saveFolder = Application.StartupPath;

            loadedData.TrackedObject.JoyYDeadMax = Decimal.ToInt32(numYmax.Value);
            loadedData.TrackedObject.JoyYDeadMin = Decimal.ToInt32(numYmin.Value);
            loadedData.TrackedObject.JoyXDeadMax = Decimal.ToInt32(numXmax.Value);
            loadedData.TrackedObject.JoyXDeadMin = Decimal.ToInt32(numXmin.Value);

            string outputData = JsonConvert.SerializeObject(loadedData, Formatting.None, new DecimalJsonConverter());
            byte[] bytes = Encoding.ASCII.GetBytes(outputData);
            byte[] byteOutput = new byte[bytes.Length + endBytes.Length];
            Buffer.BlockCopy(bytes, 0, byteOutput, 0, bytes.Length);
            Buffer.BlockCopy(endBytes, 0, byteOutput, bytes.Length, endBytes.Length);

            string saveFilename;
            m_ControllerDict.TryGetValue(comboBox1.Text, out saveFilename);

            if (!string.IsNullOrEmpty(saveFilename))
            {
                //System.IO.File.WriteAllBytes(saveFolder + "\\" + saveFilename, byteOutput);
                System.IO.File.WriteAllBytes(calibrationDirectory + "\\" + saveFilename, byteOutput);
            }

            lbl_Status.Text = "Please restart OVRService to apply changes.";
        }

        // Populate controller list
        private void FillControllerList()
        {
            comboBox1.Items.Clear();
            m_ControllerDict.Clear();

            if (!Directory.Exists(calibrationDirectory))
            {
                MessageBox.Show("Path: " + calibrationDirectory + " not found!", "Error");
                btn_Reset.Enabled = false;
                btn_RestartOVR.Enabled = false;
                btn_RestoreOriginal.Enabled = false;
                btn_Save.Enabled = false;
                lbl_Status.Text = "Oculus software configuration directory not found!";
                return;
            }

            string[] fileEntries = Directory.GetFiles(calibrationDirectory);
            string userFriendlyName = "";

            string deviceCacheData = System.IO.File.ReadAllText(oculusDeviceCachePath);

            foreach (string filePath in fileEntries)
            {
                string fileName = Path.GetFileName(filePath);
                string fileExtension = Path.GetExtension(filePath);
                string id = fileName.Substring(0, 14);
                if (deviceCacheData.IndexOf(id) > -1)
                {
                    switch (fileExtension)
                    {
                        case LTOUCH:
                            userFriendlyName = "Left Touch Controller - " + id;
                            break;
                        case RTOUCH:
                            userFriendlyName = "Right Touch Controller - " + id;
                            break;
                        case OBJECT:
                            userFriendlyName = "Tracked Object - " + id;
                            break;
                        default:
                            continue;
                    }

                    m_ControllerDict.Add(userFriendlyName, fileName);

                    comboBox1.Items.Add(userFriendlyName);
                }
            }

            comboBox1.SelectedIndex = 0;
        }

        // Read calibration data for selected controller
        private void ReadValues(string fileName)
        {
            string saveFolder = Application.StartupPath;

            string inputData = System.IO.File.ReadAllText(Path.Combine(calibrationDirectory, fileName));
            byte[] inputByteData = System.IO.File.ReadAllBytes(Path.Combine(calibrationDirectory, fileName));

            endBytes = new byte[8];
            for (int i = inputByteData.Length; i > 0; i--)
            {
                char currentChar = Convert.ToChar(inputByteData[i - 1]);
                if (currentChar.Equals('}'))
                {
                    int len = inputByteData.Length - i;
                    endBytes = new byte[len];
                    for (int j = 0; j < len; j++)
                    {
                        endBytes[j] = inputByteData[i + j];
                    }
                    break;
                }
            }

            int jsonEnd = inputData.LastIndexOf('}') + 1;

            Encoding enc = Encoding.ASCII;
            string closingSymbols = enc.GetString(endBytes);

            inputData = inputData.Remove(jsonEnd);
            loadedData = JsonConvert.DeserializeObject<CalibrationData>(inputData);

            numXmax.Maximum = loadedData.TrackedObject.JoyXRangeMax;
            numXmax.Minimum = loadedData.TrackedObject.JoyXRangeMin;
            numXmin.Maximum = loadedData.TrackedObject.JoyXRangeMax;
            numXmin.Minimum = loadedData.TrackedObject.JoyXRangeMin;
            numYmax.Maximum = loadedData.TrackedObject.JoyYRangeMax;
            numYmax.Minimum = loadedData.TrackedObject.JoyYRangeMin;
            numYmin.Maximum = loadedData.TrackedObject.JoyYRangeMax;
            numYmin.Minimum = loadedData.TrackedObject.JoyYRangeMin;

            numXmax.Value = loadedData.TrackedObject.JoyXDeadMax;
            numXmin.Value = loadedData.TrackedObject.JoyXDeadMin;
            numYmax.Value = loadedData.TrackedObject.JoyYDeadMax;
            numYmin.Value = loadedData.TrackedObject.JoyYDeadMin;

            numXmin.Maximum = numXmax.Value;
            numXmax.Minimum = numXmin.Value;
            numYmin.Maximum = numYmax.Value;
            numYmax.Minimum = numYmin.Value;

            lblRangeXmax.Text = loadedData.TrackedObject.JoyXRangeMax.ToString();
            lblRangeXmin.Text = loadedData.TrackedObject.JoyXRangeMin.ToString();
            lblRangeYmax.Text = loadedData.TrackedObject.JoyYRangeMax.ToString();
            lblRangeYmin.Text = loadedData.TrackedObject.JoyYRangeMin.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filename;
            m_ControllerDict.TryGetValue(comboBox1.Text, out filename);

            if (!string.IsNullOrEmpty(filename))
                ReadValues(filename);
        }

        // Reset fields values to default
        private void button2_Click(object sender, EventArgs e)
        {
            numXmax.Value = loadedData.TrackedObject.JoyXDeadMax;
            numXmin.Value = loadedData.TrackedObject.JoyXDeadMin;
            numYmax.Value = loadedData.TrackedObject.JoyYDeadMax;
            numYmin.Value = loadedData.TrackedObject.JoyYDeadMin;
        }

        private void numXmax_ValueChanged(object sender, EventArgs e)
        {
            numXmin.Maximum = numXmax.Value;
        }

        private void numXmin_ValueChanged(object sender, EventArgs e)
        {
            numXmax.Minimum = numXmin.Value;
        }

        private void numYmax_ValueChanged(object sender, EventArgs e)
        {
            numYmin.Maximum = numYmax.Value;
        }

        private void numYmin_ValueChanged(object sender, EventArgs e)
        {
            numYmax.Minimum = numYmin.Value;
        }

        private void btn_RestoreOriginal_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(backupDirectory);
            if (files.Length == 0)
            {
                MessageBox.Show("Backup files not found!", "Error");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Do you want to reset custom deadzone values and restore original configuration files from the backup?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                RestoreFromBackup();
                FillControllerList();
            }

            lbl_Status.Text = "Original files restored! Please restart OVRService to apply changes.";
        }

        // Restart OVRService
        public void RestartService(string serviceName)
        {
            if (!IsUserAdministrator())
            {
                MessageBox.Show("Can not restart OVRService.\nPlease run application as Administrator!", "Error");
                return;
            }

            ServiceController service = new ServiceController(serviceName);
            TimeSpan timeout = TimeSpan.FromMinutes(1);
            if (service.Status != ServiceControllerStatus.Stopped)
            {
                lbl_Status.Text = "Stopping OVRServce. Please wait...";
                Application.DoEvents();

                // Stop Service
                service.Stop();
                Application.DoEvents();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                Application.DoEvents();
            }
            //Restart service
            lbl_Status.Text = "Restarting OVRServce. Please wait...";
            Application.DoEvents();
            service.Start();
            service.WaitForStatus(ServiceControllerStatus.Running, timeout);
            Application.DoEvents();
            lbl_Status.Text = "OVRServce restarted!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RestartService("OVRService");
        }

        // Check if software is running with Administrator privileges
        private static bool IsUserAdministrator()
        {
            bool isAdmin;
            try
            {
                WindowsIdentity user = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(user);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (UnauthorizedAccessException ex)
            {
                isAdmin = false;
                MessageBox.Show(ex.Message, "UnauthorizedAccessException");
            }
            catch (Exception ex)
            {
                isAdmin = false;
                MessageBox.Show(ex.Message, "Exception");
            }
            return isAdmin;
        }
    }
}
