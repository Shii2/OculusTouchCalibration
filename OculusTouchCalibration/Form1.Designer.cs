namespace OculusTouchCalibration
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Save = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numXmin = new System.Windows.Forms.NumericUpDown();
            this.numXmax = new System.Windows.Forms.NumericUpDown();
            this.numYmax = new System.Windows.Forms.NumericUpDown();
            this.numYmin = new System.Windows.Forms.NumericUpDown();
            this.lblRangeXmin = new System.Windows.Forms.Label();
            this.lblRangeXmax = new System.Windows.Forms.Label();
            this.lblRangeYmax = new System.Windows.Forms.Label();
            this.lblRangeYmin = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_RestoreOriginal = new System.Windows.Forms.Button();
            this.btn_RestartOVR = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numXmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYmin)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Save.Location = new System.Drawing.Point(302, 232);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(255, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numXmin
            // 
            this.numXmin.Location = new System.Drawing.Point(80, 117);
            this.numXmin.Name = "numXmin";
            this.numXmin.Size = new System.Drawing.Size(50, 20);
            this.numXmin.TabIndex = 2;
            this.numXmin.ValueChanged += new System.EventHandler(this.numXmin_ValueChanged);
            // 
            // numXmax
            // 
            this.numXmax.Location = new System.Drawing.Point(205, 117);
            this.numXmax.Name = "numXmax";
            this.numXmax.Size = new System.Drawing.Size(50, 20);
            this.numXmax.TabIndex = 3;
            this.numXmax.ValueChanged += new System.EventHandler(this.numXmax_ValueChanged);
            // 
            // numYmax
            // 
            this.numYmax.Location = new System.Drawing.Point(143, 62);
            this.numYmax.Name = "numYmax";
            this.numYmax.Size = new System.Drawing.Size(50, 20);
            this.numYmax.TabIndex = 4;
            this.numYmax.ValueChanged += new System.EventHandler(this.numYmax_ValueChanged);
            // 
            // numYmin
            // 
            this.numYmin.Location = new System.Drawing.Point(143, 173);
            this.numYmin.Name = "numYmin";
            this.numYmin.Size = new System.Drawing.Size(50, 20);
            this.numYmin.TabIndex = 5;
            this.numYmin.ValueChanged += new System.EventHandler(this.numYmin_ValueChanged);
            // 
            // lblRangeXmin
            // 
            this.lblRangeXmin.AutoSize = true;
            this.lblRangeXmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRangeXmin.ForeColor = System.Drawing.Color.Red;
            this.lblRangeXmin.Location = new System.Drawing.Point(119, 140);
            this.lblRangeXmin.Name = "lblRangeXmin";
            this.lblRangeXmin.Size = new System.Drawing.Size(34, 13);
            this.lblRangeXmin.TabIndex = 6;
            this.lblRangeXmin.Text = "minX";
            // 
            // lblRangeXmax
            // 
            this.lblRangeXmax.AutoSize = true;
            this.lblRangeXmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRangeXmax.ForeColor = System.Drawing.Color.Red;
            this.lblRangeXmax.Location = new System.Drawing.Point(247, 140);
            this.lblRangeXmax.Name = "lblRangeXmax";
            this.lblRangeXmax.Size = new System.Drawing.Size(37, 13);
            this.lblRangeXmax.TabIndex = 7;
            this.lblRangeXmax.Text = "maxX";
            // 
            // lblRangeYmax
            // 
            this.lblRangeYmax.AutoSize = true;
            this.lblRangeYmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRangeYmax.ForeColor = System.Drawing.Color.Red;
            this.lblRangeYmax.Location = new System.Drawing.Point(185, 85);
            this.lblRangeYmax.Name = "lblRangeYmax";
            this.lblRangeYmax.Size = new System.Drawing.Size(37, 13);
            this.lblRangeYmax.TabIndex = 8;
            this.lblRangeYmax.Text = "maxY";
            // 
            // lblRangeYmin
            // 
            this.lblRangeYmin.AutoSize = true;
            this.lblRangeYmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRangeYmin.ForeColor = System.Drawing.Color.Red;
            this.lblRangeYmin.Location = new System.Drawing.Point(182, 196);
            this.lblRangeYmin.Name = "lblRangeYmin";
            this.lblRangeYmin.Size = new System.Drawing.Size(34, 13);
            this.lblRangeYmin.TabIndex = 9;
            this.lblRangeYmin.Text = "minY";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(136, 232);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(80, 23);
            this.btn_Reset.TabIndex = 10;
            this.btn_Reset.Text = "Reset values";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Y max:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Y min:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "X min:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "X max:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Deadzone +Y (Up)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Deadzone -X (Left)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Deadzone -Y (Down)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Deadzone +X (Right)";
            // 
            // btn_RestoreOriginal
            // 
            this.btn_RestoreOriginal.Location = new System.Drawing.Point(12, 232);
            this.btn_RestoreOriginal.Name = "btn_RestoreOriginal";
            this.btn_RestoreOriginal.Size = new System.Drawing.Size(118, 23);
            this.btn_RestoreOriginal.TabIndex = 19;
            this.btn_RestoreOriginal.Text = "Restore original files";
            this.btn_RestoreOriginal.UseVisualStyleBackColor = true;
            this.btn_RestoreOriginal.Click += new System.EventHandler(this.btn_RestoreOriginal_Click);
            // 
            // btn_RestartOVR
            // 
            this.btn_RestartOVR.Location = new System.Drawing.Point(259, 261);
            this.btn_RestartOVR.Name = "btn_RestartOVR";
            this.btn_RestartOVR.Size = new System.Drawing.Size(118, 23);
            this.btn_RestartOVR.TabIndex = 20;
            this.btn_RestartOVR.Text = "Restart OVRService";
            this.btn_RestartOVR.UseVisualStyleBackColor = true;
            this.btn_RestartOVR.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Controller to calibrate:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Status:";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Uighur", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Status.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Status.Location = new System.Drawing.Point(55, 287);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(35, 14);
            this.lbl_Status.TabIndex = 23;
            this.lbl_Status.Text = "ready";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 309);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_RestartOVR);
            this.Controls.Add(this.btn_RestoreOriginal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.lblRangeYmin);
            this.Controls.Add(this.lblRangeYmax);
            this.Controls.Add(this.lblRangeXmax);
            this.Controls.Add(this.lblRangeXmin);
            this.Controls.Add(this.numYmin);
            this.Controls.Add(this.numYmax);
            this.Controls.Add(this.numXmax);
            this.Controls.Add(this.numXmin);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Oculus Touch Deadzone Calibration Tool";
            ((System.ComponentModel.ISupportInitialize)(this.numXmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numXmin;
        private System.Windows.Forms.NumericUpDown numXmax;
        private System.Windows.Forms.NumericUpDown numYmax;
        private System.Windows.Forms.NumericUpDown numYmin;
        private System.Windows.Forms.Label lblRangeXmin;
        private System.Windows.Forms.Label lblRangeXmax;
        private System.Windows.Forms.Label lblRangeYmax;
        private System.Windows.Forms.Label lblRangeYmin;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_RestoreOriginal;
        private System.Windows.Forms.Button btn_RestartOVR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_Status;
    }
}

