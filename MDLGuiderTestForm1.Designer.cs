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
            FilterListBox = new ListBox();
            MainCameraExposureButton = new Button();
            label2 = new Label();
            MainCameraExposureBox = new NumericUpDown();
            label3 = new Label();
            MainCameraBinningBox = new NumericUpDown();
            MoveStarTestButton = new Button();
            label4 = new Label();
            DeltaXBox = new NumericUpDown();
            label5 = new Label();
            DeltaYBox = new NumericUpDown();
            label6 = new Label();
            GuideStarX = new Label();
            GuideStarY = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExposureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MainCameraExposureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MainCameraBinningBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeltaXBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeltaYBox).BeginInit();
            groupBox3.SuspendLayout();
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
            LogTextBox.Location = new Point(12, 304);
            LogTextBox.Multiline = true;
            LogTextBox.Name = "LogTextBox";
            LogTextBox.ScrollBars = ScrollBars.Vertical;
            LogTextBox.Size = new Size(503, 288);
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
            groupBox1.Location = new Point(391, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(103, 118);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Guider Binning";
            // 
            // ExposureBox
            // 
            ExposureBox.Location = new Point(224, 70);
            ExposureBox.Name = "ExposureBox";
            ExposureBox.Size = new Size(44, 23);
            ExposureBox.TabIndex = 7;
            ExposureBox.TextAlign = HorizontalAlignment.Center;
            ExposureBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 74);
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
            AutoStarCheckBox.Location = new Point(136, 44);
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
            LocateTestButton.Location = new Point(10, 41);
            LocateTestButton.Name = "LocateTestButton";
            LocateTestButton.Size = new Size(109, 23);
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
            DelayCheckBox.Location = new Point(136, 15);
            DelayCheckBox.Name = "DelayCheckBox";
            DelayCheckBox.Size = new Size(55, 19);
            DelayCheckBox.TabIndex = 12;
            DelayCheckBox.Text = "Delay";
            DelayCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveLogsButton
            // 
            SaveLogsButton.Location = new Point(10, 275);
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
            // FilterListBox
            // 
            FilterListBox.FormattingEnabled = true;
            FilterListBox.ItemHeight = 15;
            FilterListBox.Location = new Point(194, 17);
            FilterListBox.Name = "FilterListBox";
            FilterListBox.Size = new Size(120, 79);
            FilterListBox.TabIndex = 15;
            FilterListBox.SelectedIndexChanged += FilterListBox_SelectedIndexChanged;
            // 
            // MainCameraExposureButton
            // 
            MainCameraExposureButton.Location = new Point(343, 46);
            MainCameraExposureButton.Name = "MainCameraExposureButton";
            MainCameraExposureButton.Size = new Size(109, 23);
            MainCameraExposureButton.TabIndex = 16;
            MainCameraExposureButton.Text = "Expose";
            MainCameraExposureButton.UseVisualStyleBackColor = true;
            MainCameraExposureButton.Click += MainCameraExposureButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 30);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 18;
            label2.Text = "Exposure (sec)";
            // 
            // MainCameraExposureBox
            // 
            MainCameraExposureBox.Location = new Point(96, 26);
            MainCameraExposureBox.Name = "MainCameraExposureBox";
            MainCameraExposureBox.Size = new Size(44, 23);
            MainCameraExposureBox.TabIndex = 17;
            MainCameraExposureBox.TextAlign = HorizontalAlignment.Center;
            MainCameraExposureBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 59);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 20;
            label3.Text = "Binning";
            // 
            // MainCameraBinningBox
            // 
            MainCameraBinningBox.Location = new Point(97, 57);
            MainCameraBinningBox.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            MainCameraBinningBox.Name = "MainCameraBinningBox";
            MainCameraBinningBox.Size = new Size(33, 23);
            MainCameraBinningBox.TabIndex = 19;
            MainCameraBinningBox.TextAlign = HorizontalAlignment.Center;
            MainCameraBinningBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // MoveStarTestButton
            // 
            MoveStarTestButton.Location = new Point(10, 130);
            MoveStarTestButton.Name = "MoveStarTestButton";
            MoveStarTestButton.Size = new Size(109, 23);
            MoveStarTestButton.TabIndex = 21;
            MoveStarTestButton.Text = "Move Star Test";
            MoveStarTestButton.UseVisualStyleBackColor = true;
            MoveStarTestButton.Click += MoveStarTestButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 134);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 23;
            label4.Text = "dX";
            // 
            // DeltaXBox
            // 
            DeltaXBox.Location = new Point(163, 130);
            DeltaXBox.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            DeltaXBox.Name = "DeltaXBox";
            DeltaXBox.Size = new Size(44, 23);
            DeltaXBox.TabIndex = 22;
            DeltaXBox.TextAlign = HorizontalAlignment.Center;
            DeltaXBox.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(224, 134);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 25;
            label5.Text = "dY";
            // 
            // DeltaYBox
            // 
            DeltaYBox.Location = new Point(251, 130);
            DeltaYBox.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            DeltaYBox.Name = "DeltaYBox";
            DeltaYBox.Size = new Size(44, 23);
            DeltaYBox.TabIndex = 24;
            DeltaYBox.TextAlign = HorizontalAlignment.Center;
            DeltaYBox.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(157, 17);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 26;
            label6.Text = "Filter";
            label6.Click += label6_Click;
            // 
            // GuideStarX
            // 
            GuideStarX.BorderStyle = BorderStyle.FixedSingle;
            GuideStarX.Location = new Point(295, 29);
            GuideStarX.MinimumSize = new Size(1, 1);
            GuideStarX.Name = "GuideStarX";
            GuideStarX.Size = new Size(37, 23);
            GuideStarX.TabIndex = 27;
            GuideStarX.Text = "X";
            GuideStarX.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GuideStarY
            // 
            GuideStarY.BorderStyle = BorderStyle.FixedSingle;
            GuideStarY.Location = new Point(338, 29);
            GuideStarY.Name = "GuideStarY";
            GuideStarY.Size = new Size(38, 23);
            GuideStarY.TabIndex = 28;
            GuideStarY.Text = "Y";
            GuideStarY.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(295, 14);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 29;
            label7.Text = "Star X";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(339, 14);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 30;
            label8.Text = "Star Y";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(FilterListBox);
            groupBox3.Controls.Add(MainCameraExposureBox);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(MainCameraBinningBox);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(MainCameraExposureButton);
            groupBox3.Location = new Point(12, 163);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(482, 106);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Main Camera";
            // 
            // MDLGuiderTestForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 598);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(GuideStarY);
            Controls.Add(GuideStarX);
            Controls.Add(label5);
            Controls.Add(DeltaYBox);
            Controls.Add(label4);
            Controls.Add(DeltaXBox);
            Controls.Add(MoveStarTestButton);
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
            Controls.Add(groupBox3);
            Name = "MDLGuiderTestForm1";
            Text = "MDL Calibration Tester";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ExposureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)MainCameraExposureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)MainCameraBinningBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeltaXBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeltaYBox).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private ListBox FilterListBox;
        private Button MainCameraExposureButton;
        private Label label2;
        private NumericUpDown MainCameraExposureBox;
        private Label label3;
        private NumericUpDown MainCameraBinningBox;
        private Button MoveStarTestButton;
        private Label label4;
        private NumericUpDown DeltaXBox;
        private Label label5;
        private NumericUpDown DeltaYBox;
        private Label label6;
        private Label GuideStarX;
        private Label GuideStarY;
        private Label label7;
        private Label label8;
        private GroupBox groupBox3;
    }
}
