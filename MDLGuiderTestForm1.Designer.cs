namespace MDL_Guide_Tester
{
    partial class MDLGuiderTestForm1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CalibationTestButton = new Button();
            LogTextBox = new TextBox();
            Binning1Button = new RadioButton();
            Binning2Button = new RadioButton();
            Binning3Button = new RadioButton();
            Binning4Button = new RadioButton();
            groupBox1 = new GroupBox();
            ExposureBox = new NumericUpDown();
            label1 = new Label();
            AutoStarCheckBox = new CheckBox();
            ConnectButton = new Button();
            LocateTestButton = new Button();
            DelayCheckBox = new CheckBox();
            SaveLogsButton = new Button();
            saveFileDialog1 = new SaveFileDialog();
            GuidingTestButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExposureBox).BeginInit();
            SuspendLayout();
            // 
            // CalibationTestButton
            // 
            CalibationTestButton.Location = new Point(10, 70);
            CalibationTestButton.Name = "CalibationTestButton";
            CalibationTestButton.Size = new Size(109, 23);
            CalibationTestButton.TabIndex = 0;
            CalibationTestButton.Text = "Calibration Test";
            CalibationTestButton.UseVisualStyleBackColor = true;
            CalibationTestButton.Click += CalibrationTestButton_Click;
            // 
            // LogTextBox
            // 
            LogTextBox.Location = new Point(10, 149);
            LogTextBox.Multiline = true;
            LogTextBox.Name = "LogTextBox";
            LogTextBox.ScrollBars = ScrollBars.Vertical;
            LogTextBox.Size = new Size(503, 292);
            LogTextBox.TabIndex = 1;
            // 
            // Binning1Button
            // 
            Binning1Button.AutoSize = true;
            Binning1Button.Checked = true;
            Binning1Button.Location = new Point(32, 18);
            Binning1Button.Name = "Binning1Button";
            Binning1Button.Size = new Size(42, 19);
            Binning1Button.TabIndex = 2;
            Binning1Button.TabStop = true;
            Binning1Button.Text = "1x1";
            Binning1Button.UseVisualStyleBackColor = true;
            // 
            // Binning2Button
            // 
            Binning2Button.AutoSize = true;
            Binning2Button.Location = new Point(32, 43);
            Binning2Button.Name = "Binning2Button";
            Binning2Button.Size = new Size(42, 19);
            Binning2Button.TabIndex = 3;
            Binning2Button.TabStop = true;
            Binning2Button.Text = "2x2";
            Binning2Button.UseVisualStyleBackColor = true;
            // 
            // Binning3Button
            // 
            Binning3Button.AutoSize = true;
            Binning3Button.Location = new Point(32, 68);
            Binning3Button.Name = "Binning3Button";
            Binning3Button.Size = new Size(42, 19);
            Binning3Button.TabIndex = 4;
            Binning3Button.TabStop = true;
            Binning3Button.Text = "3x3";
            Binning3Button.UseVisualStyleBackColor = true;
            // 
            // Binning4Button
            // 
            Binning4Button.AutoSize = true;
            Binning4Button.Location = new Point(32, 93);
            Binning4Button.Name = "Binning4Button";
            Binning4Button.Size = new Size(42, 19);
            Binning4Button.TabIndex = 5;
            Binning4Button.TabStop = true;
            Binning4Button.Text = "4x4";
            Binning4Button.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Binning4Button);
            groupBox1.Controls.Add(Binning3Button);
            groupBox1.Controls.Add(Binning2Button);
            groupBox1.Controls.Add(Binning1Button);
            groupBox1.Location = new Point(414, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(83, 118);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Binning";
            // 
            // ExposureBox
            // 
            ExposureBox.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            ExposureBox.Location = new Point(359, 69);
            ExposureBox.Name = "ExposureBox";
            ExposureBox.Size = new Size(44, 23);
            ExposureBox.TabIndex = 7;
            ExposureBox.TextAlign = HorizontalAlignment.Center;
            ExposureBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(271, 73);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 8;
            label1.Text = "Exposure (sec)";
            // 
            // AutoStarCheckBox
            // 
            AutoStarCheckBox.AutoSize = true;
            AutoStarCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            AutoStarCheckBox.Checked = true;
            AutoStarCheckBox.CheckState = CheckState.Checked;
            AutoStarCheckBox.Location = new Point(189, 73);
            AutoStarCheckBox.Name = "AutoStarCheckBox";
            AutoStarCheckBox.Size = new Size(72, 19);
            AutoStarCheckBox.TabIndex = 9;
            AutoStarCheckBox.Text = "AutoStar";
            AutoStarCheckBox.UseVisualStyleBackColor = true;
            // 
            // ConnectButton
            // 
            ConnectButton.Location = new Point(10, 12);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new Size(109, 23);
            ConnectButton.TabIndex = 10;
            ConnectButton.Text = "Connect Test";
            ConnectButton.UseVisualStyleBackColor = true;
            ConnectButton.Click += ConnectButton_Click;
            // 
            // LocateTestButton
            // 
            LocateTestButton.Location = new Point(12, 41);
            LocateTestButton.Name = "LocateTestButton";
            LocateTestButton.Size = new Size(107, 23);
            LocateTestButton.TabIndex = 11;
            LocateTestButton.Text = "Locate Test";
            LocateTestButton.UseVisualStyleBackColor = true;
            LocateTestButton.Click += LocateTestButton_Click;
            // 
            // DelayCheckBox
            // 
            DelayCheckBox.AutoSize = true;
            DelayCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            DelayCheckBox.Checked = true;
            DelayCheckBox.CheckState = CheckState.Checked;
            DelayCheckBox.Location = new Point(128, 73);
            DelayCheckBox.Name = "DelayCheckBox";
            DelayCheckBox.Size = new Size(55, 19);
            DelayCheckBox.TabIndex = 12;
            DelayCheckBox.Text = "Delay";
            DelayCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveLogsButton
            // 
            SaveLogsButton.Location = new Point(294, 115);
            SaveLogsButton.Name = "SaveLogsButton";
            SaveLogsButton.Size = new Size(109, 23);
            SaveLogsButton.TabIndex = 13;
            SaveLogsButton.Text = "Save Logs";
            SaveLogsButton.UseVisualStyleBackColor = true;
            SaveLogsButton.Click += SaveLogsButton_Click;
            // 
            // GuidingTestButton
            // 
            GuidingTestButton.Location = new Point(10, 99);
            GuidingTestButton.Name = "GuidingTestButton";
            GuidingTestButton.Size = new Size(109, 23);
            GuidingTestButton.TabIndex = 14;
            GuidingTestButton.Text = "Guiding Test";
            GuidingTestButton.UseVisualStyleBackColor = true;
            GuidingTestButton.Click += GuidingTestButton_Click;
            // 
            // MDLGuiderTestForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 450);
            Controls.Add(GuidingTestButton);
            Controls.Add(SaveLogsButton);
            Controls.Add(DelayCheckBox);
            Controls.Add(LocateTestButton);
            Controls.Add(ConnectButton);
            Controls.Add(AutoStarCheckBox);
            Controls.Add(label1);
            Controls.Add(ExposureBox);
            Controls.Add(groupBox1);
            Controls.Add(LogTextBox);
            Controls.Add(CalibationTestButton);
            Name = "MDLGuiderTestForm1";
            Text = "MDL Calibration Tester";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ExposureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CalibationTestButton;
        private TextBox LogTextBox;
        private RadioButton Binning1Button;
        private RadioButton Binning2Button;
        private RadioButton Binning3Button;
        private RadioButton Binning4Button;
        private GroupBox groupBox1;
        private NumericUpDown ExposureBox;
        private Label label1;
        private CheckBox AutoStarCheckBox;
        private Button ConnectButton;
        private Button LocateTestButton;
        private CheckBox DelayCheckBox;
        private Button SaveLogsButton;
        private SaveFileDialog saveFileDialog1;
        private Button GuidingTestButton;
    }
}
