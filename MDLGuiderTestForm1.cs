using System.Runtime.CompilerServices;
using System.Reflection;
using System.Diagnostics;
using System.IO;
using MaxIm;

namespace MDL_Guide_Tester
{
    public partial class MDLGuiderTestForm1 : Form
    {
        public MDLGuiderTestForm1()
        {
            InitializeComponent();
        }

        public List<string> logList = new List<string>();
        public int MainFilterNumber { get; set; } = 0;
        public double GuiderDuration { get; set; } = 1;
        public int GuiderBinning { get; set; } = 1;

        private void CalibrationTestButton_Click(object sender, EventArgs e)
        {
            LogIt("\r\n");
            LogIt("Testing Calibration");
            //
            //This routine automates a complete guider calibration in Maxim DL, i.e. guider and AO-X
            //

            GuiderDuration = (double)ExposureBox.Value; ; //Exposure length in seconds
            GuiderBinning = GetBinning();

            //Open Maxim objects -- camera and application
            MaxIm.Application app = new MaxIm.Application();
            MaxIm.CCDCamera cam = new MaxIm.CCDCamera();
            //Connect Maxim
            cam.LinkEnabled = BoolToSbyte(true);
            //Set binning
            cam.GuiderBinning = (sbyte)GuiderBinning;
            short bin = cam.GuiderBinning;
            LogIt("Binning set to: " + bin.ToString());

            //Find Star automatically via guider exposure
            if (AutoStarCheckBox.Checked)
                cam.GuiderAutoSelectStar = BoolToSbyte(true);
            else
            {
                //Find Star automatically via guider exposure
                bool guiderStatus = SbyteToBool(cam.GuiderExpose(GuiderDuration));
                if (guiderStatus)
                    LogIt("Exposure Passed");
                else
                {
                    LogIt("Exposure Failed");
                    LogIt("Calibration Test Failed");
                    return;
                }
                if (cam.GuiderXStarPosition == 0 && cam.GuiderYStarPosition == 0)
                {
                    LogIt("Guide Star Locate Failed");
                    LogIt("Calibration Test Failed");
                    return;
                }
                else
                    LogIt("Guide State Locate Passed");
            }

            //Start the guider calibration using the same exposure length
            bool calResult = SbyteToBool(cam.GuiderCalibrate(GuiderDuration));
            if (DelayCheckBox.Checked)
            {
                Thread.Sleep(2000);
            }
            int calImmediateState = cam.GuiderCalState;

            LogIt("Cal Start Result: " + calResult.ToString());
            if (calResult)
                LogIt("Cal start result = true");
            else
            {
                LogIt("Cal start result = false");
                LogIt("Calibration Test Failed");
                return;
            }

            //Check to see if guidercalstate has been set correctly immediately after starting cal
            if (calImmediateState != 1)
                LogIt("Error -- Immediate calstate reading is: " + GetCompletion(calImmediateState));
            else
                LogIt("Awaiting on Cal Complete  ");

            //Take another reading and Wait for calibration to complete
            while (SbyteToBool(cam.GuiderRunning))
            {
                LogIt(".", false);
                Thread.Sleep(1000);
            }
            LogIt("\r\n", false);
            //Report calibration result upon completion status, either 2 for successful or 3 for unsuccessful
            LogIt("Cal done with results: " + GetCompletion(cam.GuiderCalState) + " at binning " + cam.GuiderBinning.ToString());
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            LogIt("\r\n");
            LogIt("Connection Text");

            //
            //This routine automates a complete guider calibration in Maxim DL, i.e. guider and AO-X
            //

            LogIt("MDL Connection Test:");
            //Connect Maxim
            MaxIm.Application app;
            MaxIm.CCDCamera cam;

            //Open Maxim objects -- camera and application
            try
            {
                app = new MaxIm.Application();
                cam = new MaxIm.CCDCamera();
            }
            catch (Exception ex)
            {
                LogIt("MDL Connection Failed -- " + ex.Message);
                return;
            }
            LogIt("MDL Version " + app.Version + " Connection Passed");

            LogIt("Camera Connection Test:");

            cam.LinkEnabled = BoolToSbyte(true);
            if (SbyteToBool(cam.LinkEnabled))
                LogIt("Camera Connection Passed");
            else
            {
                LogIt("Camera Connection Failed");
                return;
            }

            LogIt("Mount Connection Test:");
            //Connect mount (via TSX ASCOM2X Adapter)
            app.TelescopeConnected = BoolToSbyte(true);
            if (SbyteToBool(app.TelescopeConnected))
                LogIt("Mount connection Passed");
            else
                LogIt("Mount connection Failed");
            LogIt("Connection Tests Passed");
            //Read in filter names
            List<string> filterNames = GetFilterNames();
            foreach (string filterName in filterNames)
                FilterListBox.Items.Add(filterName);
            return;
        }

        private void LocateTestButton_Click(object sender, EventArgs e)
        {
            LogIt("\r\n");
            LogIt("Locate Star Test");
            double duration = (double)ExposureBox.Value; ; //Exposure length in seconds
            int binning = GetBinning();

            //Open Maxim objects -- camera and application
            MaxIm.Application app = new MaxIm.Application();
            MaxIm.CCDCamera cam = new MaxIm.CCDCamera();

            //Connect Maxim
            cam.LinkEnabled = BoolToSbyte(true);

            //Set binning
            cam.GuiderBinning = (sbyte)binning;
            short bin = cam.GuiderBinning;
            LogIt("Binning set to: " + bin.ToString());

            //Wait a couple of seconds for MDL to get connected
            Thread.Sleep(2000);
            if (AutoStarCheckBox.Checked)
                cam.GuiderAutoSelectStar = BoolToSbyte(true);

            //Find Star automatically via guider exposure
            bool guiderStatus = SbyteToBool(cam.GuiderExpose(duration));
            while (SbyteToBool(cam.GuiderRunning))
            {
                LogIt(".", false);
                Thread.Sleep(1000);
            }

            if (guiderStatus)
            {
                GuideStarX.Text = cam.GuiderXStarPosition.ToString();
                GuideStarY.Text = cam.GuiderYStarPosition.ToString();
                LogIt("Exposure Passed");
            }
            else
            {
                LogIt("Exposure Failed");
                LogIt("Locate Star Test Failed");
                return;
            }
            if (cam.GuiderXStarPosition == 0 && cam.GuiderYStarPosition == 0)
            {
                LogIt("Guide Star Not Located");
                LogIt("Locate Star Test Failed");
            }
            else
            {
                LogIt("Guide Star Located at " + cam.GuiderXStarPosition.ToString() + " X / " + cam.GuiderYStarPosition.ToString() + " Y");
                LogIt("Locate Star Test Passed");
            }
        }

        private void GuidingTestButton_Click(object sender, EventArgs e)
        {
            LogIt("\r\n");
            LogIt("Testing Guiding");
            //
            //This routine automates a complete guider calibration in Maxim DL, i.e. guider and AO-X
            //

            double duration = (double)ExposureBox.Value; ; //Exposure length in seconds
            int binning = GetBinning();

            //Open Maxim objects -- camera and application
            MaxIm.Application app = new MaxIm.Application();
            MaxIm.CCDCamera cam = new MaxIm.CCDCamera();
            //Connect Maxim
            cam.LinkEnabled = BoolToSbyte(true);
            //Turn off guiding and exit if running
            if (SbyteToBool(cam.GuiderRunning))
            {
                cam.GuiderStop();
                LogIt("Guiding Stopped");
                GuidingTestButton.Text = "Guider Test";
                return;
            }
            //Set binning
            cam.GuiderBinning = (sbyte)binning;
            short bin = cam.GuiderBinning;
            LogIt("Binning set to: " + bin.ToString());

            ////Find Star automatically via guider exposure
            //if (AutoStarCheckBox.Checked)
            //    cam.GuiderAutoSelectStar = BoolToSbyte(true);
            //else
            //{
            //    //Find Star automatically via guider exposure
            //    bool guiderStatus = SbyteToBool(cam.GuiderExpose(duration));
            //    if (guiderStatus)
            //        LogIt("Exposure Passed");
            //    else
            //    {
            //        LogIt("Exposure Failed");
            //        LogIt("Calibration Test Failed");
            //        return;
            //    }
            //    if (cam.GuiderXStarPosition == 0 && cam.GuiderYStarPosition == 0)
            //    {
            //        LogIt("Guide Star Locate Failed");
            //        LogIt("Calibration Test Failed");
            //        return;
            //    }
            //    else
            //        LogIt("Guide State Locate Passed");
            //}


            //Start the guider calibration using the same exposure length
            bool gStart = SbyteToBool(cam.GuiderTrack(duration));
            bool gImmediateState = SbyteToBool(cam.GuiderRunning);
            //Check to see if guidercalstate has been set correctly immediately after starting cal
            if (!gImmediateState)
                LogIt("Error -- Immediate Guider reading is: " + gImmediateState);
            if (DelayCheckBox.Checked)
            {
                Thread.Sleep(2000);
            }
            bool gResult = SbyteToBool(cam.GuiderRunning);
            LogIt("Guider Start Result: " + gResult.ToString());
            if (gResult)
                LogIt("Guider start result = true");
            else
            {
                LogIt("Guider start result = false");
                LogIt("Guider Test Failed");
                return;
            }


            GuideStarX.Text = cam.GuiderXStarPosition.ToString();
            GuideStarY.Text = cam.GuiderYStarPosition.ToString();
            LogIt("");
            //Report calibration result upon completion status, either 2 for successful or 3 for unsuccessful
            //LogIt("Cal done with results: " + GetCompletion(cam.GuiderCalState) + " at binning " + cam.GuiderBinning.ToString());
            GuidingTestButton.Text = "Guider Stop";
        }

        private void SaveLogsButton_Click(object sender, EventArgs e)
        {
            List<string> mdlLog = GetMDLLog();
            List<string> aoxLog = GetAOXLog();
            saveFileDialog1.Filter = "Log files (*.log)|*.log";
            DialogResult saveLogResult = saveFileDialog1.ShowDialog();
            if (saveLogResult != DialogResult.OK)
                return;
            //FileStream logStream = File.Open(saveFileDialog1.FileName, FileMode.OpenOrCreate);
            StreamWriter logStream = File.CreateText(saveFileDialog1.FileName);
            //Copy local log into save file
            logStream.WriteLine("***************");
            logStream.WriteLine("MDL Guider Test Log");
            logStream.WriteLine("***************");
            foreach (string logLine in logList)
                logStream.WriteLine(logLine);
            //Copy MDL AO log file to it
            logStream.WriteLine("***************");
            logStream.WriteLine("MDL Log");
            logStream.WriteLine("***************");
            foreach (string logLIne in mdlLog)
                logStream.WriteLine(logLIne);
            logStream.WriteLine("***************");
            logStream.WriteLine("MDL Guider AO Log");
            logStream.WriteLine("***************");
            foreach (string logLIne in aoxLog)
                logStream.WriteLine(logLIne);
            logStream.Close();
        }

        private void LogIt(string text, bool newLine = true)
        {
            if (!newLine)
            {
                LogTextBox.AppendText(text);
            }
            else
            {
                string logTextLine = DateTime.Now.ToString("HH:MM:ss.ss") + "   " + text;
                logList.Add(logTextLine);
                LogTextBox.AppendText(logTextLine + "\r\n");
            }
        }

        private int GetBinning()
        {
            if (Binning1Button.Checked)
                return 1;
            if (Binning2Button.Checked)
                return 2;
            if (Binning3Button.Checked)
                return 3;
            if (Binning4Button.Checked)
                return 4;
            return 0;
        }

        private List<string> GetFilterNames()
        {
            List<string> filterNames = new List<string>();
            MaxIm.Application app = new MaxIm.Application();
            MaxIm.CCDCamera cam = new MaxIm.CCDCamera();
            cam.LinkEnabled = BoolToSbyte(true);
            foreach (string f in cam.FilterNames)
                filterNames.Add(f);
            return filterNames;
        }

        private string GetCompletion(int calState)
        {
            switch (calState)
            {
                case 0:
                    return "Not Calibrated";
                case 1:
                    return "Calibrating";
                case 2:
                    return "Calibration Successful";
                case 3:
                    return "Calibration Failed";
                default:
                    return "Huh?";
            }
        }

        private List<string> GetAOXLog()
        {
            List<string> logList = new List<string>();

            string userDocumentDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string mdlLogFilePath = userDocumentDirectoryPath + "\\MaxIm DL 7\\Settings\\Log";
            string mdlAOXLogFilePath = mdlLogFilePath + "\\DLImagingAO";
            string currentDateLogPath = mdlAOXLogFilePath + "\\" + DateTime.Now.ToString("yyyyMMdd") + ".log";

            //Try to open today's log, return null list if failed
            StreamReader textStream;
            try { textStream = new StreamReader(currentDateLogPath); }
            catch { return logList; }

            //Read log into list
            while (textStream.Peek() != -1)
                logList.Add(textStream.ReadLine());
            textStream.Close();
            return logList;
        }

        private List<string> GetMDLLog()
        {
            List<string> logList = new List<string>();

            string userDocumentDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string mdlLogFilePath = userDocumentDirectoryPath + "\\MaxIm DL 7\\Settings\\Log";
            string currentDateLogPath = mdlLogFilePath + "\\" + DateTime.Now.ToString("yyyyMMdd") + ".log";

            //Try to open today's log, return null list if failed
            StreamReader textStream;
            try { textStream = new StreamReader(currentDateLogPath); }
            catch { return logList; }

            //Read log into list
            while (textStream.Peek() != -1)
                logList.Add(textStream.ReadLine());
            textStream.Close();
            return logList;
        }

        private bool SbyteToBool(sbyte value)
        {
            if (value == 0)
                return false;
            else
                return true;
        }

        private sbyte BoolToSbyte(bool value)
        {
            if (value)
                return 1;
            else
                return 0;
        }

        private void FilterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set main camera filter
            MainFilterNumber = FilterListBox.SelectedIndex;
        }

        private void MoveStarTestButton_Click(object sender, EventArgs e)
        {
            LogIt("\r\n");
            LogIt("Guider Move Start Location Test");
            //Open Maxim objects -- camera and application
            MaxIm.Application app = new MaxIm.Application();
            MaxIm.CCDCamera cam = new MaxIm.CCDCamera();
            //Connect Maxim
            cam.LinkEnabled = BoolToSbyte(true);
            //Get current star position
            LogIt("Moving Guider Star location to X=" + (cam.GuiderXStarPosition + (float)DeltaXBox.Value).ToString("0.00") +
                               " / Y = " + (cam.GuiderYStarPosition + (float)DeltaYBox.Value).ToString("0.00"));
            sbyte moveResult = BoolToSbyte(false);
            try
            {
                moveResult = cam.GuiderMoveStar(cam.GuiderXStarPosition + (float)DeltaXBox.Value,
                                                    cam.GuiderYStarPosition + (float)DeltaYBox.Value);
            }
            catch ( Exception ex )
            {
                LogIt("Move failed: " + ex.Message);
                moveResult = BoolToSbyte(false);
            }
            if (SbyteToBool(moveResult))
                LogIt("Move Star successful");
            else
                LogIt("Move Star failed");
            GuideStarX.Text = cam.GuiderXStarPosition.ToString();
            GuideStarY.Text = cam.GuiderYStarPosition.ToString();
            return;
        }

        private void MainCameraExposureButton_Click(object sender, EventArgs e)
        {
            LogIt("\r\n");
            LogIt("Main Camera Exposure");
            //
            //This routine automates a camera exposure in Maxim DL, i.e. guider and AO-X
            //

            double duration = (double)MainCameraExposureBox.Value; ; //Exposure length in seconds
            int cameraBinning = GetBinning();


            //Open Maxim objects -- camera and application
            MaxIm.Application app = new MaxIm.Application();
            MaxIm.CCDCamera cam = new MaxIm.CCDCamera();
            //Connect Maxim
            cam.LinkEnabled = BoolToSbyte(true);
            //Set binning
            cam.BinX = (sbyte)cameraBinning;
            cam.BinY = (sbyte)cameraBinning;
            LogIt("Main Camera Binning set to: " + cam.BinX.ToString() + " / " + cam.BinY.ToString());
            //filter
            cam.Filter = (short)MainFilterNumber;
            LogIt("Main Camera Filter set to: " + cam.Filter.ToString());
            //Expose
            bool cameraStatus = SbyteToBool(cam.Expose(duration, 1));
            if (cameraStatus)
                LogIt("Camera Exposure Started for " + duration.ToString() + " seconds");
            else
            {
                LogIt("Camera Exposure Failed");
                LogIt("Camera Exposusre Test Failed");
                return;
            }

            //Get guide star position
            GuideStarX.Text = cam.GuiderXStarPosition.ToString();
            GuideStarY.Text = cam.GuiderYStarPosition.ToString();

            //Take another reading and Wait for calibration to complete

            while (!SbyteToBool(cam.ImageReady))
            {
                LogIt("Camera Status = " + cam.CameraStatus.ToString());
                Thread.Sleep(1000);
            }
            //Report exposure result upon completion status, either 2 for successful or 3 for unsuccessful
            LogIt("Main camera exposure done with results: " + cam.CameraStatus.ToString());
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //Read in filter names
            List<string> filterNames = GetFilterNames();
            foreach (string filterName in filterNames)
                FilterListBox.Items.Add(filterName);
        }
    }
}

