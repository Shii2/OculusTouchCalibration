# Oculus Touch Deadzone Calibration Tool

This tool will allow you to adjust Oculus Touch thumbsticks deadzones. It may be useful if thumbstick started activating at times when it should not.

![Application main window](https://i.imgur.com/iNPT9Xp.png)

---

## Usage

* Extract archive anywhere
* Close all VR applications, SteamVR and Oculus desktop software if running
* Launch the tool. It will require Administrator rights for restarting OVRService
* Select Touch controller to calibrate in dropdown menu
* To increase deadzone, decrease values -X and -Y or increase values of +X and +Y. I recommend increasing and decreasing values by about 50
* Press Save button then Restart OVRService
* Launch Oculus software and check if issue is fixed
* Repeat above steps if you still experiencing thumbstick self-activation issue. In some extreme cases you may need to change deadzone value by about 200. For example when my thumbstick started behaiving weird I had to decrease -X deadzone from 502 to 380.

##  UI buttons

* Restore original files - restores original calibration files from backup folder. These files are backed up when tool started for the first time.
* Reset values - reload deadzone values from calibration file
* Save - save changes to calibration file
* Restart OVRService - restart OVRService to apply calibration changes. Oculus desktop software should be closed prior restarting.
