using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using AForge;
using AForge.Controls;
using AForge.Imaging;
using AForge.Math;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Video.FFMPEG;
using AForge.Vision;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Threading;
using System.Globalization;
using System.Drawing.Text;
//Library for create Report
using Spire.Xls;
using AForge.Imaging.Filters;

namespace SewerRobot
{
    public partial class frmMain : Form
    {
        private float dis = 3.71F;
        private int secondTemp = 0;
        Error test = new Error();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private string pipeSize = null;
        int rowCounterImageReport = 10;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private string timeState;

        //Directory For Gozareshat
        private string mainDir, subDir, videoSubDir, imageSubDir, gozareshSubDir, tmpDir;

        private float fps = 0;
        private Stopwatch stopWatch = null;
        private VideoFileWriter videoFileWriter = new VideoFileWriter();
        private bool recordStat = false;
        private int videoWidth = 640, videoHeight = 480;
        //private bool cameraSelection = false;   //for checking if camera is selected
        private bool additionalText = false;

        //Create a workbook
        //private Workbook workbook2 = new Workbook();
        //private Worksheet sheet2;
        //Create a workbook
         Workbook workbook;
         //Initailize worksheet
         Worksheet sheet;
        private System.Media.SoundPlayer takePhoto = new System.Media.SoundPlayer("../Resources/camerashutter.wav");


        private int encOffset = 0;
        float angOffset = -2.9f;
        private int encoder;

        int index = 1;
        //Temp String for error coding
        FontFamily[] font;
        private Font ft, myFont;
        private PersianCalendar pc = new PersianCalendar();
        DateTime thisDate = DateTime.Now;

        private bool cameraSelection = false;

        private string errorTypeTemp, errorCodingTemp, errorEndTemp;

        ///////Color
        SolidBrush blColor, bmColor, brColor, rColor, lColor;

        /////////Speed
        private int speed = 0;
        bool connectionState = false;

        bool isForward = false;
        bool isBackward = false;
        Task taskControl;

        // draw circle variables
        float xCircle, yCircle, wCircle, hCircle, xP, yP;//, xRectangle, yRectangle, wRectangle, hRectangle; //Width, Height;
        bool isDown = false, isDone = false, isSizeNS_Bottom = false, isSizeNS_Up = false, isSizeWE_Left = false, isSizeWE_Right = false, isSizeAll = false;
        int dirCircle = 0;

        int valueTrbLighting = 255;
        bool rotationCamera = false;
        byte[] msgCamera;
        int counterTakingPhoto = 0;
        string standardErorr;

        private delegate void _SetDisplay(string Text);

        
        private void _Fill_lblError(string str)
        {
            try
            {
                if (lblError.InvokeRequired == true)
                {
                    _SetDisplay d = new _SetDisplay(_Fill_lblError);
                    this.Invoke(d, new object[] { str });
                }
                else lblError.Text = str;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "error");
            }
        }
        private void _Fill_txtAngle(string str)
        {
            try
            {
                if (txtAngle.InvokeRequired == true)
                {
                    _SetDisplay d = new _SetDisplay(_Fill_txtAngle);
                    this.Invoke(d, new object[] { str });
                }
                else txtAngle.Text = str;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " txtAngle error");
            }
        }
        private void _Fill_txtDistance(string str)
        {
            try
            {
                if (txtDistance.InvokeRequired == true)
                {
                    _SetDisplay d = new _SetDisplay(_Fill_txtDistance);
                    this.Invoke(d, new object[] { str });
                }
                else txtDistance.Text = str;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "txtDistance error");
            }
        }

        void Control()
        {
            while (true)
            {
                //Thread.Sleep(500);
                if (serialPort1.IsOpen)
                {
                    try
                    {
                        if (rotationCamera)
                        {
                            serialPort1.Write(msgCamera, 0, msgCamera.Length);

                            Thread.Sleep(6);
                            if(msgCamera[4]==0)
                            {
                                serialPort1.Write(msgCamera, 0, msgCamera.Length);

                                Thread.Sleep(6);
                                rotationCamera = false;
                            }
                        }
                        else
                        { 
                            byte[] msg;
                            string sensors;

                            msg = new byte[3] { (byte)'<', (byte)'E', (byte)'>' };
                            serialPort1.Write(msg, 0, msg.Length);

                            Thread.Sleep(5);

                            sensors = serialPort1.ReadLine();
                            int encStart = sensors.IndexOf("E");
                            int encEnd = sensors.IndexOf("e");

                            string encS = sensors.Substring(encStart + 1, encEnd - encStart - 1);

                            if (int.TryParse(encS, out encoder))
                                _Fill_txtDistance(((Int32)((encoder - encOffset) * dis)).ToString());

                            Thread.Sleep(0);

                            msg = new byte[3] { (byte)'<', (byte)'A', (byte)'>' };
                            serialPort1.Write(msg, 0, msg.Length);

                            Thread.Sleep(550);

                            sensors = serialPort1.ReadExisting(); ;
                            int angStart = sensors.IndexOf("Y ");

                            int angEnd = -1;
                            if (angStart > 0)
                                angEnd = angStart + 6;

                            string angS = sensors.Substring(angStart + 1, angEnd - angStart - 1);
                            float angle;

                            System.Globalization.NumberStyles style;
                            System.Globalization.CultureInfo culture;
                            style = System.Globalization.NumberStyles.Number |
                                    System.Globalization.NumberStyles.AllowCurrencySymbol;
                            culture = System.Globalization.CultureInfo.CreateSpecificCulture("en-GB");

                            
                            if (Single.TryParse(angS, style, culture, out angle))
                            {
                                    _Fill_txtAngle((angle - angOffset).ToString());
                            }
                                

                            if (SharingData.X.Count == 0)
                            {
                                SharingData.X.Add((encoder - encOffset) * dis);
                                SharingData.Y.Add(angle - angOffset);
                            }
                            else if (SharingData.X.Last() < (encoder - encOffset) * dis)
                            {
                                SharingData.X.Add((encoder - encOffset) * dis);
                                SharingData.Y.Add(angle - angOffset);
                            }
                            else
                            {
                                SharingData.X.Add(SharingData.X.Last());
                                SharingData.Y.Add(angle - angOffset);
                            }

                            msg = new byte[4] { (byte)'<', (byte)'L', (byte)valueTrbLighting, (byte)'>' };
                            serialPort1.Write(msg, 0, msg.Length);
                            Thread.Sleep(5);
                        }
                    }
                    catch (Exception ex)
                    {
                        _Fill_lblError(ex.Message);
                    }
                }
            }
        }
        public frmMain()
        {
            InitializeComponent();
            serialPort1.ReadTimeout = 20;
        }
        private void AddFont()
        {
            myFont = new Font("Tahoma", 15);
            InstalledFontCollection fonts = new InstalledFontCollection();
            font = fonts.Families.ToArray();
            for (int i = 0; i < font.Length; i++)
            {
                if (font[i].Name == "B Titr")
                    myFont = new Font(font[i], 15);
            }
        }
        private void OpenVideoSource(IVideoSource source)
        {
            // set busy cursor
            this.Cursor = Cursors.WaitCursor;

            // stop current video source
            videoSourcePlayer.SignalToStop();
            videoSourcePlayer.WaitForStop();

            // start new video source
            videoSourcePlayer.VideoSource = new AsyncVideoSource(source);
            videoSourcePlayer.Start();

            // reset stop watch
            stopWatch = null;

            // start timer
            tmrFps.Start();

            this.Cursor = Cursors.Default;
        }
        private void btnSelectCamera_Click(object sender, EventArgs e )
        {
            VideoCaptureDeviceForm form = new VideoCaptureDeviceForm();

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                videoWidth = form.CaptureSize.Width;
                videoHeight = form.CaptureSize.Height;
                // open it
                OpenVideoSource(form.VideoDevice);

                //tmrRecord.Enabled = true;
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if(videoSourcePlayer.IsRunning)
            {
                if (!videoFileWriter.IsOpen)
                {
                    //string path = AppDomain.CurrentDomain.BaseDirectory + "Videos\\" + (DateTime.Now.Year * 10000000000 +
                    //     DateTime.Now.Month * 100000000 +
                    //     DateTime.Now.Day * 1000000 +
                    //     DateTime.Now.Hour * 10000 +
                    //     DateTime.Now.Minute * 100 +
                    //     DateTime.Now.Second).ToString() + ".flv";
                    string path = System.IO.Path.Combine(videoSubDir, (DateTime.Now.Year * 10000000000 +
                         DateTime.Now.Month * 100000000 +
                         DateTime.Now.Day * 1000000 +
                         DateTime.Now.Hour * 10000 +
                         DateTime.Now.Minute * 100 +
                         DateTime.Now.Second).ToString() + ".flv");
                    videoFileWriter.Open(path, videoWidth, videoHeight, (int)fps, VideoCodec.FLV1, videoWidth * videoHeight * (int)fps);

                }
                recordStat = !recordStat;
                if (recordStat == true)
                    btnRecord.Image = SewerRobot.Properties.Resources.Pause;

                else
                {
                    btnRecord.Image = SewerRobot.Properties.Resources.Record;
                    btnRec.Visible = false;
                    lblRec.Visible = false;
                }
            }
        }

        private void tmrFps_Tick(object sender, EventArgs e)
        {
            IVideoSource videoSource = videoSourcePlayer.VideoSource;

            if (videoSource != null)
            {
                // get number of frames since the last timer tick
                int framesReceived = videoSource.FramesReceived;

                if (stopWatch == null)
                {
                    stopWatch = new Stopwatch();
                    stopWatch.Start();
                }
                else
                {
                    stopWatch.Stop();

                    fps = 1000.0f * framesReceived / stopWatch.ElapsedMilliseconds;
                    lblFps.Text = fps.ToString("F2") + " fps";

                    stopWatch.Reset();
                    stopWatch.Start();
                }
            }
        }

        private void tmrRecord_Tick(object sender, EventArgs e)
        {

        }

        private void videoSourcePlayer_NewFrame(object sender, ref Bitmap image)
        {
            Graphics g = Graphics.FromImage(image);
            SolidBrush brush;

            brush = new SolidBrush(Color.FromName(clsMain.EndColor.Name));
            StringFormat RtoLFormat = new StringFormat(StringFormatFlags.DirectionRightToLeft);

            System.Drawing.Point employeePoint = new System.Drawing.Point();
            System.Drawing.Point contractorPoint = new System.Drawing.Point();
            System.Drawing.Point addressPoint = new System.Drawing.Point();
            System.Drawing.Point datePoint = new System.Drawing.Point();
            System.Drawing.Point timePoint = new System.Drawing.Point();
            System.Drawing.Point RPoint = new System.Drawing.Point();
            System.Drawing.Point BRPoint = new System.Drawing.Point();
            System.Drawing.Point pipeSizePoint = new System.Drawing.Point();
            System.Drawing.Point anglePoint = new System.Drawing.Point();
            System.Drawing.Point distancePoint = new System.Drawing.Point();
            contractorPoint.X = videoWidth;
            contractorPoint.Y = 25;
            employeePoint.X = videoWidth;
            employeePoint.Y = 0;
            addressPoint.X = videoWidth;
            addressPoint.Y = 50;
            datePoint.X = videoWidth;
            datePoint.Y = 80;
            timePoint.X = videoWidth;
            timePoint.Y = 110;
            BRPoint.X = videoWidth;
            BRPoint.Y = videoSourcePlayer.Bottom;
            RPoint.X = videoWidth;
            RPoint.Y = videoHeight - 40;
            pipeSizePoint.X = videoWidth;
            pipeSizePoint.Y = 50;
            distancePoint.X = videoWidth;
            distancePoint.Y = 120;
            anglePoint.X = videoSourcePlayer.Left;
            anglePoint.Y = 110;


            //txtContractor.Text = StringFormatFlags.DirectionRightToLeft;
            g.DrawString(txtContractor.Text, myFont, brush, contractorPoint, RtoLFormat);
            g.DrawString(txtEmployee.Text, myFont, brush, employeePoint,RtoLFormat);
            g.DrawString(txtState.Text + '،' + txtCity.Text + '،' + txtArea.Text, myFont, brush, addressPoint, RtoLFormat);
            g.DrawString("ش.م.ابتدایی: " + txtStartAddress.Text, myFont, brush, videoSourcePlayer.Left, 0);
            g.DrawString("ش.م.انتهایی: " + txtEndAddress.Text, myFont, brush, videoSourcePlayer.Left, 30);
            g.DrawString("سایز لوله:" + pipeSize + "م.م", myFont, brush, videoSourcePlayer.Left, 60);
            g.DrawString(txtDate.Text, myFont, brush, videoSourcePlayer.Left, 90);
            g.DrawString(timeState + txtHour.Text + ":" + txtMinute.Text, myFont, brush, videoSourcePlayer.Left, 120);
            //g.DrawString("شیب لوله: " + txtAngle.Text, myFont, brush, videoSourcePlayer.Left, 180);
            g.DrawString("مسافت پیموده شده: " + txtDistance.Text, myFont, brush, distancePoint, RtoLFormat);

            if (rdbShowSError.Checked)
            {
                string temp = test.ErrorTypeTemp + " " + test.ErrorCodeTemp;
                if (rdbStructureError.Checked == true)
                {
                    if (txtPercent.Enabled == true)
                    {
                        temp += "%" + txtPercent.Text;
                        if (test.EndNameTemp != "")
                            temp += " " + test.EndNameTemp;
                    }
                    if (txtStartHour.Enabled == true)
                    {
                        if (txtEndHour.Text != "")
                            temp += " " + "از ساعت" + " " + txtStartHour.Text + " " + "تا ساعت" + " " + txtEndHour.Text;
                        else
                            temp += " " + "در موقعیت ساعت" + " " + txtStartHour.Text;
                    }

                }
                else if (rdbRunError.Checked == true)
                {
                    if (txtPercent.Enabled == true && txtStartHour.Enabled == true && txtDiameter.Enabled == true)
                    {
                        if (txtPercent.Text != "")
                            temp += " " + "در موقعیت ساعت" + " " + txtStartHour.Text + " " + "با قطر" + " " + txtPercent.Text + "میلی متر" + " " + "(" + "نفوذ به داخل لوله" + txtPercent.Text + "%" + ")";
                        else
                            temp += " " + "در موقعیت ساعت" + " " + txtStartHour.Text + " " + "با قطر" + txtPercent.Text + "میلی متر";
                    }
                    else if (txtDiameter.Enabled == true && txtStartHour.Enabled == true)
                    {
                        if (txtEndHour.Text != "")
                            temp += " " + "از ساعت" + " " + txtStartHour.Text + " " + "تا ساعت" + " " + txtEndHour.Text;
                        else
                            temp += " " + "در موقعیت ساعت" + " " + txtStartHour.Text + "با قطر" + txtDiameter.Text + "میلی متر";
                    }
                    else if (txtStartHour.Enabled == true)
                    {
                        if (txtEndHour.Text != "")
                            temp += " " + "از ساعت" + " " + txtStartHour.Text + " " + "تا ساعت" + " " + txtEndHour.Text;
                        else
                            temp += " " + "در موقعیت ساعت" + " " + txtStartHour.Text;
                    }
                }
                else if (rdbServiceError.Checked == true)
                {
                    if (txtPercent.Enabled == true && txtStartHour.Enabled == true)
                    {
                        if (txtEndHour.Text != "")
                            temp += " " + "از ساعت" + " " + txtStartHour.Text + " " + "تا ساعت" + " " + txtEndHour.Text + " " + "و" + txtPercent.Text + "%" + test.EndNameTemp;
                        else
                            temp += " " + "در موقعیت ساعت" + " " + txtStartHour.Text + " " + "و" + txtPercent.Text + "%" + test.EndNameTemp;
                    }
                    else if (txtPercent.Enabled == true)
                    {
                        temp += "%" + txtPercent.Text;
                        if (test.EndNameTemp != "")
                            temp += " " + test.EndNameTemp;
                    }
                    else if (txtStartHour.Enabled == true)
                    {
                        if (txtEndHour.Text != "")
                            temp += " " + "از ساعت" + " " + txtStartHour.Text + " " + "تا ساعت" + " " + txtEndHour.Text;
                        else
                            temp += " " + "در موقعیت ساعت" + " " + txtStartHour.Text;
                    }
                }
                if (temp != null)
                {
                    standardErorr = temp;
                    g.DrawString(temp, myFont, rColor, RPoint, RtoLFormat);
                }
                    //g.DrawString(temp, myFont, rColor,pipeSizePoint, RtoLFormat);
                //g.DrawString(txtAddTextR.Text, myFont, rColor, RPoint, RtoLFormat);

            }
            else if(rdbShowError.Checked)
            {
                g.DrawString(txtAddTextR.Text, myFont, rColor, RPoint, RtoLFormat);
            }
                if (recordStat)
            {
                try
                {
                    videoFileWriter.WriteVideoFrame(image);
                } 
                catch (AccessViolationException ex)
                { throw ex; }
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            recordStat = false;
            videoFileWriter.Close();

            if (videoSourcePlayer.VideoSource != null)
            {

                videoSourcePlayer.SignalToStop();
                videoSourcePlayer.WaitForStop();

            }
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            bool sw = true;
            foreach(Control c in tabPage1.Controls)
            {
                if( c.GetType() == typeof(System.Windows.Forms.TextBox) || c.GetType() == typeof(System.Windows.Forms.ComboBox))
                {
                    if(c.Text == "")
                        sw = false;
                }
            }

            switch (cmbPipeSize.Text)
            {
                case "200":
                case "250":
                    dis = 2.841F;//3.662F;
                    break;
                case "300":
                case "315":
                    dis = 3.932F;//LASTIK BOZORGA
                    break;
                case "400":
                    dis = 3.963F;//3.662F;
                    break;
                case "500":
                    dis = 3.900F;//3.662F;
                    break;
                case "900":
                    dis = 4.050F;//3.662F;
                    break;
            }
            pipeSize = cmbPipeSize.Text;
            if(sw == true)
            {
                CreateDirectory();
                Report();
                grpCamera.Enabled = true;
                foreach (Control ctl in tabControl1.Controls)
                {
                    if (ctl.Name == "tabPage1")
                        ctl.Enabled = false;
                }
                btnNewProject.Enabled = true;
            }
            else
            {
                MessageBox.Show("لطفا همه تکس باکس ها را پر کنید");
            }
        }

        private void CreateDirectory()
        {
            try
            {
                //Create Project Directory
                mainDir = AppDomain.CurrentDomain.BaseDirectory + txtContractor.Text;
                System.IO.Directory.CreateDirectory(mainDir);
                subDir = System.IO.Path.Combine(mainDir, txtStartAddress.Text + '+' + txtEndAddress.Text);
                System.IO.Directory.CreateDirectory(subDir);
                videoSubDir = System.IO.Path.Combine(subDir, "Video");
                imageSubDir = System.IO.Path.Combine(subDir, "Image");
                gozareshSubDir = System.IO.Path.Combine(subDir, "Gozaresh");
                System.IO.Directory.CreateDirectory(videoSubDir);
                System.IO.Directory.CreateDirectory(imageSubDir);
                System.IO.Directory.CreateDirectory(gozareshSubDir);
                tmpDir = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Temp");
                System.IO.Directory.CreateDirectory(tmpDir);
            }
            catch (Exception)
            {
                MessageBox.Show("پوشه ها با موفقیت ایجاد نشد");
            }
        }

        private void btnStopRecord_Click(object sender, EventArgs e)
        {
            if (gozareshSubDir != null)
            {
                sheet.Range["G6"].Text = cmbPipeMaterial.SelectedItem.ToString();
                sheet.Range["G7"].Text = cmbProcedure.SelectedItem.ToString();
                sheet.Range["G8"].Text = cmbDutyOfPipe.SelectedItem.ToString();
                sheet.Range["J5"].Text = cmbPipeShape.SelectedItem.ToString();
                sheet.Range["J7"].Text = txtDistance.Text;
                if(chkBranch.Checked)
                {
                    sheet.Range["J8"].Text = "دارای انشعاب";
                }
                else
                {
                    sheet.Range["J8"].Text = "بدون انشعاب";
                }
                string path = System.IO.Path.Combine(gozareshSubDir, "Report.xlsx");
                workbook.SaveToFile(path, ExcelVersion.Version2013);
            }
            if (videoFileWriter.IsOpen)//(cameraSelection)
            {
                recordStat = false;
                videoFileWriter.Close();
                videoSourcePlayer.VideoSource.SignalToStop();
                btnRecord.Image = SewerRobot.Properties.Resources.Record;
            }
            //Save the file
            //workbook2.SaveToFile("C:/Users/javad/Desktop/Shib.xlsx");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbPipeSize.SelectedIndex = 0;
            cmbDirection.SelectedIndex = 0;
            cmbPipeMaterial.SelectedIndex = 8;
            cmbProcedure.SelectedIndex = 1;
            cmbDutyOfPipe.SelectedIndex = 1;
            cmbPipeShape.SelectedIndex = 0;

            btnNewProject.Enabled = false;
            //Az bein bordan kadre atraf
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            AddFont();
            //tanzim rang ha

            rColor = new SolidBrush(Color.FromName(clsR.EndColor.Name));
            grpCamera.Enabled = false;
            //grpMotor.Enabled = false;
            //grpSensors.Enabled = false;

            
            //Initailize worksheet
            //workbook2.LoadFromFile("Encoder-Angle.xlsx");
            //sheet2 = workbook2.Worksheets[0];
            //Create a workbook
            workbook = new Workbook();
            //Initailize worksheet
            workbook.LoadFromFile("Gozaresh.xlsx");
            sheet = workbook.Worksheets[0];

            //Set text box
            txtDate.Text = pc.GetYear(thisDate).ToString() + "/" + pc.GetMonth(thisDate).ToString() + "/" + pc.GetDayOfMonth(thisDate).ToString(); //DateTime.Now.ToShortDateString();
            txtHour.Text = ((DateTime.Now.Hour)%12).ToString();
            txtMinute.Text = DateTime.Now.Minute.ToString();
            if (DateTime.Now.Hour < 12)
                cmbTime.SelectedIndex = 0;
            else
                cmbTime.SelectedIndex = 1;
        }

        private void btnStopRecord_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnStopRecord, "Stop Recording");
        }


        private void tlbQuit_Click(object sender, EventArgs e)
        {
            recordStat = false;
            videoFileWriter.Close();

            if (videoSourcePlayer.VideoSource != null)
            {

                videoSourcePlayer.SignalToStop();
                videoSourcePlayer.WaitForStop();

            }
            this.Close();
        }

        private void btnChangeText_Click(object sender, EventArgs e)
        {
            additionalText = true;
        }

        private void tlbConnect_Click(object sender, EventArgs e)
        {
            if (connectionState == false)
            {
                string[] ports = SerialPort.GetPortNames();
                if (ports.Length != 0)
                {
                    frmConnect con = new frmConnect(this);
                    con.Show();
                }
            }
            else
            {
                serialPort1.Close();
                tlbConnect.Image = SewerRobot.Properties.Resources.Disconnect;
                connectionState = false;
                //MessageBox.Show(".اتصال یو اس بی یافت نشد");
            }

        }

        public void comPortConnect(string baudrate, string portname)
        {
            serialPort1.BaudRate = Int32.Parse(baudrate);
            serialPort1.PortName = portname;
            try
            {
                serialPort1.Open();
                grpMotor.Enabled = true;
                tlbConnect.Image = SewerRobot.Properties.Resources.Connect;
                connectionState = true;
                if (taskControl == null)
                {
                    taskControl = new Task(Control);
                    if (taskControl.Status != TaskStatus.Running)
                    {
                        speed = (int)(trbSpeedControl.Value * 25.5);
                        taskControl.Start();
                    }
                }
                //byte[] msg = new byte[3]   { 0x00, 0x68, 0xfa };
                // serialPort1.Write(msg, 0, 3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
             timer1.Enabled = true;
            //tsbConDisCon.Image = Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory + "pic\\" + "DisConnect.png");
            //connectedComPort = true;
            //tsbConDisCon.Text = "Disconnect";
            //tsbWIFI.Enabled = false;
            //tsbConDisCon.BackColor = Color.Lime;
        }



        private void btnForward_MouseDown(object sender, MouseEventArgs e)
        {
            if (!chkForward.Checked && !chkBackward.Checked)
            {
                //byte[] msg = new byte[9] { (byte)'<', (byte)'F', (byte)'>', 0x00, 0x66, (byte)speed, 0x00, 0x65, (byte)speed };
                //serialPort1.Write(msg, 0, 9);
                isForward = true;
            }
        }

        private void btnForward_MouseUp(object sender, MouseEventArgs e)
        {
            if (!chkForward.Checked && !chkBackward.Checked)
            {
                //byte[] msg = new byte[9] { (byte)'<', (byte)'F', (byte)'>', 0x00, 0x66, (byte)0, 0x00, 0x65, (byte)0 };
                //serialPort1.Write(msg, 0, 9);
                isForward = false;
            }
        }

        private void btnBackward_MouseDown(object sender, MouseEventArgs e)
        {
            if (!chkForward.Checked && !chkBackward.Checked)
            {
                //byte[] msg = new byte[9] {(byte)'<',(byte)'B',(byte)'>', 0x00, 0x66, (byte)speed, 0x00, 0x67, (byte)speed };
                //serialPort1.Write(msg, 0, 9); 
                isBackward = true;
            }
        }

        private void btnBackward_MouseUp(object sender, MouseEventArgs e)
        {
            if (!chkForward.Checked && !chkBackward.Checked)
            {
                //byte[] msg = new byte[9] {(byte)'<',(byte)'B',(byte)'>', 0x00, 0x66, (byte)0, 0x00, 0x67, (byte)0 };
                //serialPort1.Write(msg, 0, 9);
                isBackward = false;
            }
        }

        private void chkForward_CheckedChanged(object sender, EventArgs e)
        {
            if (chkForward.Checked == true)
            {
                chkBackward.Enabled = false;
                //byte[] msg = new byte[9] {(byte)'<',(byte)'F',(byte)'>', 0x00, 0x66, (byte)speed, 0x00, 0x65, (byte)speed };
                //serialPort1.Write(msg, 0, 9);
                isForward = true;
            }
            else
            {
                chkBackward.Enabled = true;
                //byte[] msg = new byte[9] { (byte)'<', (byte)'F', (byte)'>', 0x00, 0x66, (byte)0, 0x00, 0x65, (byte)0 };
                //serialPort1.Write(msg, 0, 9);
                isForward = false;
                trbSpeedControl.Value = 0;
                
            }
        }

        private void chkBackward_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBackward.Checked == true)
            {
                chkForward.Enabled = false;
                //byte[] msg = new byte[9] { (byte)'<', (byte)'B', (byte)'>', 0x00, 0x66, (byte)speed, 0x00, 0x67, (byte)speed };
                //serialPort1.Write(msg, 0, 9);
                isBackward = true;
            }
            else
            {
                chkForward.Enabled = true;
                //byte[] msg = new byte[9] { (byte)'<', (byte)'B', (byte)'>', 0x00, 0x66, (byte)0, 0x00, 0x67, (byte)0 };
                //serialPort1.Write(msg, 0, 9);
                isBackward = false;
            }
        }

        private void trbLigthControl_ValueChanged(object sender, EventArgs e)
        {
            //byte[] msg = new byte[5] { 0x3c, 0x00, 0x65, (byte)(trbLigthControl.Value * 3), 0x3e };
            //serialPort1.Write(msg, 0, 5);
        }

        private void trbSpeedControl_ValueChanged(object sender, EventArgs e)
        {
            speed = (int)(trbSpeedControl.Value * 25.5);
            if (chkBackward.Checked)
            {
                chkBackward_CheckedChanged(sender, e);
            }
            else if (chkForward.Checked)
            {
                chkForward_CheckedChanged(sender, e);
            }
        }

        private void clsMain_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void clsMain_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                clsMain.EndColor = colorDialog1.Color;
                //blColor = new SolidBrush(Color.FromName(clsMain.EndColor.Name));
                //blColor = new SolidBrush(Color.FromName(clsBL.EndColor.Name));
            }
        }

        //tavamaee tekoon dadan form bedoon border
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //byte[] msg = new byte[6] { 0x00, 0x66, 0x00, 0x00, 0x65, 0x00 };
            //serialPort1.Write(msg, 0, 6);
            isForward = false;
            isBackward = false;
        }

        private void toolStrip_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secondTemp++;
            timeState = cmbTime.Text;
            if (secondTemp == 60)
            {
                    UpdateTime();
                    secondTemp = 0;
            }
            if(recordStat == true && secondTemp%2 == 0)
            {
                btnRec.Visible = !(btnRec.Visible);
                lblRec.Visible = !(lblRec.Visible);
            }
    
        }

        private void UpdateTime()
        {
            if (chkSetTime.Checked == false)
            {
                txtHour.Text = DateTime.Now.Hour.ToString();
                txtMinute.Text = DateTime.Now.Minute.ToString();
                if (DateTime.Now.Hour < 12)
                    cmbTime.SelectedIndex = 0;
                else
                    cmbTime.SelectedIndex = 1;
            }
            else
            {
                int min;
                int.TryParse(txtMinute.Text,out min);
                min++;
                txtMinute.Text = min.ToString();
                if(min == 60)
                {
                    txtMinute.Text = "00";
                    int h;
                    int.TryParse(txtHour.Text, out h);
                    h++;
                    txtHour.Text = h.ToString();
                    if (h == 12)
                    {
                        txtHour.Text = "00";
                        if (cmbTime.SelectedIndex == 1)
                            cmbTime.SelectedIndex = 0;
                        else
                            cmbTime.SelectedIndex = 1;
                    }
                }
            }
        }

        private void btnAvgAngle_Click(object sender, EventArgs e)
        {
            SharingData.ReportSubDir = gozareshSubDir;
            frmAngle fa = new frmAngle();
            fa.Show();
            double sum = 0;
            //int k = sheet2.Rows.Count();
            //int k2 = sheet2.Columns.Count();
            //for (int i = 0; i < sheet2.Rows.Count(); i++)
            //{

            //}
            //for (int i = 0; i < SharingData.Y.Count - 1; i++)
            //{
            //    if (Math.Abs(SharingData.Y[i] - SharingData.Y[i + 1]) < 20)
            //        sum += SharingData.Y[i];
            //}
            //SharingData.Avg = sum / SharingData.Y.Count;
            //double p = SharingData.Avg * 100 / 90;
            //lblAvgAngle.Text = "متوسط شیب: " + p.ToString() + "%";
        }

        private void btnGetImage_Click(object sender, EventArgs e)
        {
            if (videoSourcePlayer.IsRunning)
            {
                try
                {
                    btnGetImage.Enabled = false;
                    Thread.Sleep(250);
                    string path = System.IO.Path.Combine(imageSubDir, (DateTime.Now.Year * 10000000000 +
                         DateTime.Now.Month * 100000000 +
                         DateTime.Now.Day * 1000000 +
                         DateTime.Now.Hour * 10000 +
                         DateTime.Now.Minute * 100 +
                         DateTime.Now.Second).ToString() + ".jpg");
                    Bitmap bitmap = (Bitmap)videoSourcePlayer.GetCurrentVideoFrame().Clone();
                    bitmap.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
                    // create filter
                    ResizeBicubic filter = new ResizeBicubic(300, 202);
                    // apply the filter
                    Bitmap newImage = filter.Apply(bitmap);
                    path = System.IO.Path.Combine(tmpDir, (DateTime.Now.Year * 10000000000 +
                         DateTime.Now.Month * 100000000 +
                         DateTime.Now.Day * 1000000 +
                         DateTime.Now.Hour * 10000 +
                         DateTime.Now.Minute * 100 +
                         DateTime.Now.Second).ToString() + "-r.jpg");
                    newImage.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);

                    sheet.Pictures.Add(rowCounterImageReport, 7, path);

                    if (rdbShowError.Checked)
                    {
                        sheet.Range["C" + (rowCounterImageReport).ToString()].Text = txtAddTextR.Text;
                    }
                    else if(rdbShowSError.Checked)
                    {
                        sheet.Range["C" + (rowCounterImageReport).ToString()].Text = standardErorr;
                    }
                    rowCounterImageReport += 7;
                    Thread.Sleep(750);
                    btnGetImage.Enabled = true;
                    //takePhoto.Play();
                    counterTakingPhoto++;
                    lblCounterTakingPhoto.Text = counterTakingPhoto.ToString();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void btnCameraTiltUp_Click(object sender, EventArgs e)
        {


        }

        private void btnCameraPanRight_Click(object sender, EventArgs e)
        {

        }

        private void btnCameraTiltDown_Click(object sender, EventArgs e)
        {

        }

        private void btnCameraPanLeft_Click(object sender, EventArgs e)
        {

        }

        private void btnCameraTiltUp_MouseDown(object sender, MouseEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                msgCamera = new byte[7] { 0xFF, 0x01, 0x00, 0x08, 0x00, (byte)trbSpeedRotation.Value, (byte)(trbSpeedRotation.Value + 0x09) }; // 0x20, 0x29 };
                //try
                //{
                //    serialPort1.Write(msg, 0, 7);
                //}
                //catch(Exception)
                //{
                //    throw;
                //}
                rotationCamera = true;
            }
        }

        private void btnCameraTiltUp_MouseUp(object sender, MouseEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                msgCamera = new byte[7] { 0xFF, 0x01, 0x00, 0x00, 0x00, 0x00, 0x01 };
                //try
                //{
                //    serialPort1.Write(msg, 0, 7);
                //}
                //catch (Exception)
                //{
                //    throw;
                //}
                rotationCamera = true;
            }
        }

        private void btnCameraPanRight_MouseDown(object sender, MouseEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                msgCamera = new byte[7] { 0xFF, 0x01, 0x00, 0x02, (byte)trbSpeedRotation.Value, 0x00, (byte)(trbSpeedRotation.Value + 0x03) };
                //try
                //{
                //serialPort1.Write(msg, 0, 7);
                //}
                //catch (Exception)
                //{
                //    throw;
                //}
                rotationCamera = true;
            }
        }

        private void btnCameraPanRight_MouseUp(object sender, MouseEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                msgCamera = new byte[7] { 0xFF, 0x01, 0x00, 0x00, 0x00, 0x00, 0x01 };
                //try
                //{
                //serialPort1.Write(msg, 0, 7);
                //}
                //catch (Exception)
                //{
                //    throw;
                //}
                rotationCamera = true;
            }
        }

        private void btnCameraTiltDown_MouseDown(object sender, MouseEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                msgCamera = new byte[7] { 0xFF, 0x01, 0x00, 0x10, 0x00, (byte)trbSpeedRotation.Value, (byte)(trbSpeedRotation.Value + 0x11) };
                //try
                //{
                //    serialPort1.Write(msg, 0, 7);
                //}
                //catch (Exception)
                //{
                //    throw;
                //}
                rotationCamera = true;
            }
        }

        private void btnCameraTiltDown_MouseUp(object sender, MouseEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                msgCamera = new byte[7] { 0xFF, 0x01, 0x00, 0x00, 0x00, 0x00, 0x01 };
                //try
                //{
                //serialPort1.Write(msg, 0, 7);
                //}
                //catch (Exception)
                //{
                //    throw;
                //}
                rotationCamera = true;
            }
        }

        private void btnCameraPanLeft_MouseDown(object sender, MouseEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                msgCamera = new byte[7] { 0xFF, 0x01, 0x00, 0x04, (byte)trbSpeedRotation.Value, 0x00, (byte)(trbSpeedRotation.Value + 0x05) };
                //try
                //{
                //serialPort1.Write(msg, 0, 7);
                //}
                //catch (Exception)
                //{
                //    throw;
                //}
                rotationCamera = true;
            }
        }

        private void btnCameraPanLeft_MouseUp(object sender, MouseEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                msgCamera = new byte[7] { 0xFF, 0x01, 0x00, 0x00, 0x00, 0x00, 0x01 };
                //try
                //{
                //serialPort1.Write(msg, 0, 7);
                //}
                //catch (Exception)
                //{
                //    throw;
                //}
                rotationCamera = true;
            }
        }

        private void cmbErrorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] tmp;
            if (rdbStructureError.Checked == true)
                tmp = test.SetStructureErrorsType(cmbErrorType.SelectedItem.ToString());
            else if (rdbServiceError.Checked == true)
                tmp = test.SetServiceErrorsType(cmbErrorType.SelectedItem.ToString());
            else
                tmp = test.SetRunErrorsType(cmbErrorType.SelectedItem.ToString());
            cmbErrorCoding.DataSource = tmp;
            //errorCodingTemp = null;
            cmbErrorCoding_SelectedIndexChanged(sender, e);
        }

        private void rdbServiceError_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbServiceError.Checked)
            {
                cmbErrorType.DataSource = test.ServiceErrors;
            }
        }

        private void rdbStructureError_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbStructureError.Checked)
            {
                cmbErrorType.DataSource = test.StructureErrors;
            } 
        }

        private void rdbRunError_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRunError.Checked)
            {
                cmbErrorType.DataSource = test.RunErrors;
            } 
        }

        private void cmbErrorCoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = null;
            txtStartHour.Enabled = false;
            txtEndHour.Enabled = false;
            txtPercent.Enabled = false;
            txtEndHour.Text = null;
            if (cmbErrorCoding.SelectedItem != null)
            {
                if (rdbStructureError.Checked == true)
                {
                    if (cmbErrorCoding.SelectedItem != null)
                    {
                        test.TypeErrorTemp = cmbErrorType.SelectedItem.ToString();
                        test.SetStructureErrorsTypeName(cmbErrorCoding.SelectedItem.ToString());
                    }
                }
                if (rdbServiceError.Checked == true)
                {
                    if (cmbErrorCoding.SelectedItem != null)
                    {
                        test.TypeErrorTemp = cmbErrorType.SelectedItem.ToString();
                        test.SetServiceErrorsTypeName(cmbErrorCoding.SelectedItem.ToString());
                    }
                }
                if (rdbRunError.Checked == true)
                {
                    if (cmbErrorCoding.SelectedItem != null)
                    {
                        test.TypeErrorTemp = cmbErrorType.SelectedItem.ToString();
                        test.SetRunErrorsTypeName(cmbErrorCoding.SelectedItem.ToString());
                    }
                }
                txtStartHour.Enabled = test.StartTimeTemp;
                txtEndHour.Enabled = test.EndTimeTemp;
                txtPercent.Enabled = test.PercentTemp;
                txtDiameter.Enabled = test.DiameterTemp;
            }
            else
            {
                if (rdbStructureError.Checked == true)
                {
                    switch (cmbErrorType.SelectedItem.ToString())
                    {
                        case "شکستگی":
                        case "سوراخ":
                            txtStartHour.Enabled = true;
                            txtEndHour.Enabled = true;
                            break;
                        case "تغییر شکل":
                            txtPercent.Enabled = true;
                            break;

                    }
                }
                if (rdbServiceError.Checked == true)
                {
                    switch (cmbErrorType.SelectedItem.ToString())
                    {
                        case "تراوش":
                        case "سوراخ":
                            txtStartHour.Enabled = true;
                            txtEndHour.Enabled = true;
                            break;
                        case "تغییر شکل":
                            txtPercent.Enabled = true;
                            break;

                    }
                }
            }
        }

        private void videoSourcePlayer_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.ForestGreen, 1.5F);
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            myPen.Color = Color.Gray;
            if (isDown || isDone)
            {
                Pen circlePen = new Pen(Color.FromName(clsCircle.EndColor.Name), 2F);
                g.DrawEllipse(circlePen, xCircle, yCircle, wCircle, hCircle);
                SolidBrush brush;
                brush = new SolidBrush(Color.FromName(clsMain.EndColor.Name));
                StringFormat RtoLFormat = new StringFormat(StringFormatFlags.DirectionRightToLeft);
                g.DrawString(wCircle.ToString(), myFont, brush, xCircle + wCircle / 2 + myFont.Size * 1.25f, yCircle - myFont.Size * 2, RtoLFormat);
                g.DrawString(wCircle.ToString(), myFont, brush, xCircle , yCircle + hCircle/2 - myFont.Size, RtoLFormat);

                if (wCircle > 0 && hCircle > 0)
                {//1
                    dirCircle = 1;
                    g.DrawRectangle(myPen, xCircle, yCircle, wCircle, hCircle);
                    g.DrawRectangle(System.Drawing.Pens.Black, xCircle + wCircle / 2 - 2, yCircle - 2, 4, 4);
                    g.DrawRectangle(System.Drawing.Pens.Black, xCircle + wCircle / 2 - 2, yCircle + hCircle - 2, 4, 4);
                    g.DrawRectangle(System.Drawing.Pens.Black, xCircle - 2, yCircle + hCircle / 2 - 2, 4, 4);
                    g.DrawRectangle(System.Drawing.Pens.Black, xCircle + wCircle - 2, yCircle + hCircle / 2 - 2, 4, 4);
                }
                else if (wCircle < 0 && hCircle > 0)
                {//2
                    dirCircle = 2;
                    g.DrawRectangle(myPen, xCircle + wCircle, yCircle, Math.Abs(wCircle), Math.Abs(hCircle));
                    g.DrawRectangle(System.Drawing.Pens.Black, xCircle + wCircle / 2 - 2, yCircle - 2, 4, 4);
                    g.DrawRectangle(System.Drawing.Pens.Black, xCircle + wCircle / 2 - 2, yCircle + hCircle - 2, 4, 4);
                    g.DrawRectangle(System.Drawing.Pens.Black, xCircle - 2, yCircle + hCircle / 2 - 2, 4, 4);
                    g.DrawRectangle(System.Drawing.Pens.Black, xCircle + wCircle - 2, yCircle + hCircle / 2 - 2, 4, 4);
                }
                else if (wCircle < 0 && hCircle < 0)
                {//3
                    dirCircle = 3;
                    g.DrawRectangle(myPen, xCircle + wCircle, yCircle + hCircle, Math.Abs(wCircle), Math.Abs(hCircle));
                    g.DrawRectangle(System.Drawing.Pens.Black, xCircle + wCircle / 2 - 2, yCircle - 2, 4, 4);
                    g.DrawRectangle(System.Drawing.Pens.Black, xCircle + wCircle / 2 - 2, yCircle + hCircle - 2, 4, 4);
                    g.DrawRectangle(System.Drawing.Pens.Black, xCircle - 2, yCircle + hCircle / 2 - 2, 4, 4);
                    g.DrawRectangle(System.Drawing.Pens.Black, xCircle + wCircle - 2, yCircle + hCircle / 2 - 2, 4, 4);
                }
                else if (wCircle > 0 && hCircle < 0)
                {//4
                    dirCircle = 4;
                    g.DrawRectangle(myPen, xCircle, yCircle + hCircle, Math.Abs(wCircle), Math.Abs(hCircle));
                    g.DrawRectangle(System.Drawing.Pens.Black, xCircle + wCircle / 2 - 2, yCircle - 2, 4, 4);
                    g.DrawRectangle(System.Drawing.Pens.Black, xCircle + wCircle / 2 - 2, yCircle + hCircle - 2, 4, 4);
                    g.DrawRectangle(System.Drawing.Pens.Black, xCircle - 2, yCircle + hCircle / 2 - 2, 4, 4);
                    g.DrawRectangle(System.Drawing.Pens.Black, xCircle + wCircle - 2, yCircle + hCircle / 2 - 2, 4, 4);
                }
            }


        }

        private void videoSourcePlayer_MouseDown(object sender, MouseEventArgs e)
        {


            //if (isDone)
            //{

            //    if ((e.X > xCircle + wCircle / 2 - 8 && e.X < xCircle + wCircle / 2 + 8) && (e.Y > yCircle - 3 && e.Y < yCircle + 6))
            //        isSizeNS_Up = true;
            //    else if ((e.X > xCircle + wCircle / 2 - 8 && e.X < xCircle + wCircle / 2 + 8) && (e.Y > yCircle + hCircle - 3 && e.Y < yCircle + hCircle + 6))
            //        isSizeNS_Bottom = true;
            //    else if ((e.X > xCircle - 3 && e.X < xCircle + 6) && (e.Y > yCircle + hCircle / 2 - 8 && e.Y < yCircle + hCircle / 2 + 8))
            //        isSizeWE_Left = true;
            //    else if ((e.X > xCircle + wCircle - 3 && e.X < xCircle + wCircle + 6) && (e.Y > yCircle + hCircle / 2 - 8 && e.Y < yCircle + hCircle / 2 + 8))
            //        isSizeWE_Right = true;
            //    else if ((e.X > xCircle + 4 && e.X < xCircle + wCircle - 4) && (e.Y > yCircle + 4 && e.Y < yCircle + hCircle + 4))
            //    {
            //        xP = e.X;
            //        yP = e.Y;
            //        isSizeAll = true;
            //    }
            //    else
            //        isDone = false;
            //}
            //if (!isSizeNS_Up && !isSizeNS_Bottom && !isSizeWE_Left && !isSizeWE_Right && !isSizeAll)
            //{
            //    xCircle = e.X;
            //    yCircle = e.Y;
            //    wCircle = 0;
            //    hCircle = 0;
            //}
            //isDown = true;
        }

        private void videoSourcePlayer_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.X > xCircle + wCircle / 2 - 8 && e.X < xCircle + wCircle / 2 + 8) && (e.Y > yCircle - 3 && e.Y < yCircle + 6))
                Cursor.Current = Cursors.SizeNS;
            else if ((e.X > xCircle + wCircle / 2 - 8 && e.X < xCircle + wCircle / 2 + 8) && (e.Y > yCircle + hCircle - 3 && e.Y < yCircle + hCircle + 6))
                Cursor.Current = Cursors.SizeNS;
            else if ((e.X > xCircle - 3 && e.X < xCircle + 6) && (e.Y > yCircle + hCircle / 2 - 8 && e.Y < yCircle + hCircle / 2 + 8))
                Cursor.Current = Cursors.SizeWE;
            else if ((e.X > xCircle + wCircle - 3 && e.X < xCircle + wCircle + 6) && (e.Y > yCircle + hCircle / 2 - 8 && e.Y < yCircle + hCircle / 2 + 8))
                Cursor.Current = Cursors.SizeWE;
            else if ((e.X > xCircle + 4 && e.X < xCircle + wCircle - 4) && (e.Y > yCircle + 4 && e.Y < yCircle + hCircle + 4))
                Cursor.Current = Cursors.SizeAll;

            if (!isDone && isDown)
            {
                wCircle = e.X - xCircle;
                hCircle = e.Y - yCircle;
            }
            else if (isSizeNS_Up)
            {
                    hCircle -= (e.Y - yCircle);
                    yCircle = e.Y;
            }
            else if (isSizeNS_Bottom)
            {
                  hCircle = e.Y - yCircle;
            }
            else if (isSizeWE_Left)
            {
                    wCircle -= (e.X - xCircle);
                    xCircle = e.X;
            }
            else if (isSizeWE_Right)
            {
                wCircle = e.X - xCircle;
            }
            else if(isSizeAll)
            {
                xCircle += e.X - xP;
                yCircle += e.Y - yP;
                xP = e.X;
                yP = e.Y;
            }
        }

        private void videoSourcePlayer_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
            isDone = true;
            isSizeNS_Up = false;
            isSizeNS_Bottom = false;
            isSizeWE_Left = false;
            isSizeWE_Right = false;
            isSizeAll = false;
            if (dirCircle == 4)
            {
                yCircle += hCircle;
                hCircle *= -1;
            }
            else if (dirCircle == 3)
            {
                xCircle += wCircle;
                yCircle += hCircle;
                wCircle *= -1;
                hCircle *= -1;
            }
            else if (dirCircle == 2)
            {
                xCircle += wCircle;
                wCircle *= -1;
            }
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            
        }

        private void btnZoomIn_MouseUp(object sender, MouseEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                msgCamera = new byte[7] { 0xFF, 0x01, 0x00, 0x00, 0x00, 0x00, 0x01 };
                //serialPort1.Write(msg, 0, 7);
                rotationCamera = true;
            }
        }

        private void btnZoomOut_MouseUp(object sender, MouseEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                msgCamera = new byte[7] { 0xFF, 0x01, 0x00, 0x00, 0x00, 0x00, 0x01 };
                //serialPort1.Write(msg, 0, 7);
                rotationCamera = true;
            }
        }

        private void btnZoomIn_MouseDown(object sender, MouseEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                msgCamera = new byte[7] { 0xFF, 0x01, 0x00, 0x20, 0x00, 0x00, 0x21 }; // 0x20, 0x29 };
                //serialPort1.Write(msg, 0, 7);
                rotationCamera = true;
            }
        }

        private void btnZoomOut_MouseDown(object sender, MouseEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                msgCamera = new byte[7] { 0xFF, 0x01, 0x00, 0x40, 0x00, 0x00, 0x41 }; // 0x20, 0x29 };
                //serialPort1.Write(msg, 0, 7);
                rotationCamera = true;
            }
        }

        private void clsCircle_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                clsCircle.EndColor = colorDialog1.Color;
                //blColor = new SolidBrush(Color.FromName(clsMain.EndColor.Name));
                //blColor = new SolidBrush(Color.FromName(clsBL.EndColor.Name));
            }
        }

        bool Report()
        {
            
            //sheet.Range["A1:C3"].Merge();
            //sheet.Range["A1:C3"].Style.KnownColor = ExcelColors.BlueGray;
            sheet.Range["K2"].Text = txtDate.Text;
            sheet.Range["K3"].Text = txtHour.Text + ":" + txtMinute.Text;
            sheet.Range["B5"].Text = txtState.Text + "-" + txtCity.Text + "-" + txtArea.Text;       //Address
            sheet.Range["B6"].Text = cmbDirection.SelectedItem.ToString();
            sheet.Range["B7"].Text = txtStartAddress.Text;
            sheet.Range["B8"].Text = txtEndAddress.Text;
            sheet.Range["G5"].Text = cmbPipeSize.Text;      //PipeSize
            //sheet.Range["A10"].Text = "نوع 2عارضه :";

            //sheet.Range["A10"].NumberFormat = "[Red]";
            //sheet.Range["A10"].Style.KnownColor = ExcelColors.Blue;
            //sheet.SetRowHeight(2, 100);
            //sheet.SetColumnWidth(3, 100);
            //sheet.Range["D11"].Text = txtCity.Text;      //City
            //sheet.Range["E11"].Text = txtArea.Text;      //Area
            //sheet.Range["J3"].Text = txtDate.Text;      //Date
            //sheet.Range["J4"].Text = txtMinute.Text;      //Time
            //sheet.Range["C15"].Text = txtStartAddress.Text;      //Start Address
            //sheet.Pictures.Add(10, 7, "20170112083237.jpg");
            //Save the file
            
            
            
            //Launch the file
            ////System.Diagnostics.Process.Start("Sample.xls");
            ////Application.EnableVisualStyles();
            ////Application.SetCompatibleTextRenderingDefault(false);
            ////Application.Run(new Form1());

            return false;
        }

        private void txtAngle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDistance_TextChanged(object sender, EventArgs e)
        {
            //sheet2.Range["A" + index.ToString()].Text = txtDistance.Text;
            //sheet2.Range["B" + index.ToString()].Text = txtAngle.Text;
            //index++;   
        }

        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                MessageBox.Show("Form.KeyPress: '" +
                    e.KeyChar.ToString() + "' pressed.");

                switch (e.KeyChar)
                {
                    case (char)49:
                    case (char)52:
                    case (char)55:
                        MessageBox.Show("Form.KeyPress: '" +
                            e.KeyChar.ToString() + "' consumed.");
                        e.Handled = true;
                        break;
                }
            }
        }


        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnDistanceOffsett_Click(object sender, EventArgs e)
        {
            encOffset = encoder;
            SharingData.X.Clear();
            SharingData.Y.Clear();
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {

        }

        private void txtMinute_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkSetTime_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSetTime.Checked == false)
                UpdateTime();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {

        }

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            if (btnEntry.Enabled == false)
            {
                foreach (Control ctl in tabControl1.Controls)
                {
                    if (ctl.Name == "tabPage1")
                        ctl.Enabled = true;
                }
                grpCamera.Enabled = false;
            }
        }

        private void clsR_Click(object sender, EventArgs e)
        {

        }

        private void trbLighting_ValueChanged(object sender, EventArgs e)
        {
            valueTrbLighting = trbLighting.Value;
        }

        private void btnAngleOffsett_Click(object sender, EventArgs e)
        {
            System.Globalization.NumberStyles style;
            System.Globalization.CultureInfo culture;
            style = System.Globalization.NumberStyles.Number |
                    System.Globalization.NumberStyles.AllowCurrencySymbol;
            culture = System.Globalization.CultureInfo.CreateSpecificCulture("en-GB");

            Single.TryParse(txtAngOffset.Text, style, culture, out angOffset);
          
        }

    }


}
