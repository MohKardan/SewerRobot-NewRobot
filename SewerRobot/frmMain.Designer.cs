namespace SewerRobot
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblFps = new System.Windows.Forms.Label();
            this.tmrFps = new System.Windows.Forms.Timer(this.components);
            this.tmrRecord = new System.Windows.Forms.Timer(this.components);
            this.trbSpeedControl = new System.Windows.Forms.TrackBar();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.chkForward = new System.Windows.Forms.CheckBox();
            this.chkBackward = new System.Windows.Forms.CheckBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbDirection = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbPipeSize = new System.Windows.Forms.ComboBox();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.chkSetTime = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.clsMain = new AForge.Controls.ColorSlider();
            this.btnEntry = new System.Windows.Forms.Button();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtEndAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPipeSize = new System.Windows.Forms.Label();
            this.lblEndAddress = new System.Windows.Forms.Label();
            this.lblStartAddress = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblContractorName = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtStartAddress = new System.Windows.Forms.TextBox();
            this.txtContractor = new System.Windows.Forms.TextBox();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbShowError = new System.Windows.Forms.RadioButton();
            this.rdbNoShowError = new System.Windows.Forms.RadioButton();
            this.rdbShowSError = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEndHour = new System.Windows.Forms.TextBox();
            this.txtStartHour = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdbRunError = new System.Windows.Forms.RadioButton();
            this.rdbStructureError = new System.Windows.Forms.RadioButton();
            this.rdbServiceError = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbErrorCoding = new System.Windows.Forms.ComboBox();
            this.lblErrorType = new System.Windows.Forms.Label();
            this.cmbErrorType = new System.Windows.Forms.ComboBox();
            this.clsR = new AForge.Controls.ColorSlider();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAddTextR = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.clsArrow = new AForge.Controls.ColorSlider();
            this.chkArrow = new System.Windows.Forms.CheckBox();
            this.clsRectangle = new AForge.Controls.ColorSlider();
            this.clsCircle = new AForge.Controls.ColorSlider();
            this.chkRectangle = new System.Windows.Forms.CheckBox();
            this.chkCircle = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cmbPipeShape = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbDutyOfPipe = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbProcedure = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbPipeMaterial = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.grpMotor = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpCamera = new System.Windows.Forms.GroupBox();
            this.lblCounterTakingPhoto = new System.Windows.Forms.Label();
            this.trbLighting = new System.Windows.Forms.TrackBar();
            this.btnRec = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.trbSpeedRotation = new System.Windows.Forms.TrackBar();
            this.btnCameraPanLeft = new System.Windows.Forms.Button();
            this.btnCameraTiltDown = new System.Windows.Forms.Button();
            this.btnCameraPanRight = new System.Windows.Forms.Button();
            this.btnCameraTiltUp = new System.Windows.Forms.Button();
            this.btnGetImage = new System.Windows.Forms.Button();
            this.btnStopRecord = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnSelectCamera = new System.Windows.Forms.Button();
            this.lblRec = new System.Windows.Forms.Label();
            this.grpSensors = new System.Windows.Forms.GroupBox();
            this.btnAngleOffsett = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAngOffset = new System.Windows.Forms.TextBox();
            this.btnDistanceOffsett = new System.Windows.Forms.Button();
            this.btnAvgAngle = new System.Windows.Forms.Button();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tlbQuit = new System.Windows.Forms.ToolStripButton();
            this.tlbConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tllHelp = new System.Windows.Forms.ToolStripLabel();
            this.tllAboutUs = new System.Windows.Forms.ToolStripLabel();
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chkBranch = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trbSpeedControl)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.grpMotor.SuspendLayout();
            this.grpCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbLighting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSpeedRotation)).BeginInit();
            this.grpSensors.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFps
            // 
            this.lblFps.AutoSize = true;
            this.lblFps.Location = new System.Drawing.Point(13, 27);
            this.lblFps.Name = "lblFps";
            this.lblFps.Size = new System.Drawing.Size(33, 13);
            this.lblFps.TabIndex = 45;
            this.lblFps.Text = "FPS: ";
            // 
            // tmrFps
            // 
            this.tmrFps.Enabled = true;
            this.tmrFps.Interval = 1000;
            this.tmrFps.Tick += new System.EventHandler(this.tmrFps_Tick);
            // 
            // tmrRecord
            // 
            this.tmrRecord.Tick += new System.EventHandler(this.tmrRecord_Tick);
            // 
            // trbSpeedControl
            // 
            this.trbSpeedControl.LargeChange = 1;
            this.trbSpeedControl.Location = new System.Drawing.Point(15, 15);
            this.trbSpeedControl.Margin = new System.Windows.Forms.Padding(1);
            this.trbSpeedControl.Name = "trbSpeedControl";
            this.trbSpeedControl.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trbSpeedControl.Size = new System.Drawing.Size(45, 143);
            this.trbSpeedControl.TabIndex = 46;
            this.trbSpeedControl.ValueChanged += new System.EventHandler(this.trbSpeedControl_ValueChanged);
            // 
            // btnForward
            // 
            this.btnForward.Image = global::SewerRobot.Properties.Resources.Forward;
            this.btnForward.Location = new System.Drawing.Point(88, 17);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(38, 38);
            this.btnForward.TabIndex = 47;
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            this.btnForward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnForward_MouseDown);
            this.btnForward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnForward_MouseUp);
            // 
            // btnBackward
            // 
            this.btnBackward.Image = ((System.Drawing.Image)(resources.GetObject("btnBackward.Image")));
            this.btnBackward.Location = new System.Drawing.Point(88, 117);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(38, 38);
            this.btnBackward.TabIndex = 48;
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            this.btnBackward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBackward_MouseDown);
            this.btnBackward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnBackward_MouseUp);
            // 
            // chkForward
            // 
            this.chkForward.AutoSize = true;
            this.chkForward.Location = new System.Drawing.Point(132, 27);
            this.chkForward.Name = "chkForward";
            this.chkForward.Size = new System.Drawing.Size(84, 17);
            this.chkForward.TabIndex = 49;
            this.chkForward.Text = "حرکت به جلو";
            this.chkForward.UseVisualStyleBackColor = true;
            this.chkForward.CheckedChanged += new System.EventHandler(this.chkForward_CheckedChanged);
            // 
            // chkBackward
            // 
            this.chkBackward.AutoSize = true;
            this.chkBackward.Location = new System.Drawing.Point(132, 133);
            this.chkBackward.Name = "chkBackward";
            this.chkBackward.Size = new System.Drawing.Size(88, 17);
            this.chkBackward.TabIndex = 50;
            this.chkBackward.Text = "حرکت به عقب";
            this.chkBackward.UseVisualStyleBackColor = true;
            this.chkBackward.CheckedChanged += new System.EventHandler(this.chkBackward_CheckedChanged);
            // 
            // btnStop
            // 
            this.btnStop.Image = global::SewerRobot.Properties.Resources.Stop;
            this.btnStop.Location = new System.Drawing.Point(88, 67);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(38, 38);
            this.btnStop.TabIndex = 51;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabControl1.Location = new System.Drawing.Point(736, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(416, 480);
            this.tabControl1.TabIndex = 58;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbDirection);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.cmbPipeSize);
            this.tabPage1.Controls.Add(this.cmbTime);
            this.tabPage1.Controls.Add(this.txtHour);
            this.tabPage1.Controls.Add(this.chkSetTime);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.txtArea);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.txtCity);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.clsMain);
            this.tabPage1.Controls.Add(this.btnEntry);
            this.tabPage1.Controls.Add(this.txtMinute);
            this.tabPage1.Controls.Add(this.txtDate);
            this.tabPage1.Controls.Add(this.txtEndAddress);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblPipeSize);
            this.tabPage1.Controls.Add(this.lblEndAddress);
            this.tabPage1.Controls.Add(this.lblStartAddress);
            this.tabPage1.Controls.Add(this.lblEmployee);
            this.tabPage1.Controls.Add(this.lblContractorName);
            this.tabPage1.Controls.Add(this.txtState);
            this.tabPage1.Controls.Add(this.txtStartAddress);
            this.tabPage1.Controls.Add(this.txtContractor);
            this.tabPage1.Controls.Add(this.txtEmployee);
            this.tabPage1.Font = new System.Drawing.Font("B Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(408, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "مشخصات پروژه";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbDirection
            // 
            this.cmbDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDirection.FormattingEnabled = true;
            this.cmbDirection.Items.AddRange(new object[] {
            "در جهت جریان",
            "خلاف جهت جریان"});
            this.cmbDirection.Location = new System.Drawing.Point(20, 238);
            this.cmbDirection.Name = "cmbDirection";
            this.cmbDirection.Size = new System.Drawing.Size(101, 28);
            this.cmbDirection.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("B Nazanin", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label18.Location = new System.Drawing.Point(293, 407);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 29);
            this.label18.TabIndex = 73;
            this.label18.Text = "تغییر رنگ متن:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label17.Location = new System.Drawing.Point(127, 238);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 26);
            this.label17.TabIndex = 72;
            this.label17.Text = "جهت ویدئومتری:";
            // 
            // cmbPipeSize
            // 
            this.cmbPipeSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPipeSize.FormattingEnabled = true;
            this.cmbPipeSize.Items.AddRange(new object[] {
            "200",
            "250",
            "300",
            "315",
            "400",
            "500",
            "900"});
            this.cmbPipeSize.Location = new System.Drawing.Point(239, 236);
            this.cmbPipeSize.Name = "cmbPipeSize";
            this.cmbPipeSize.Size = new System.Drawing.Size(60, 28);
            this.cmbPipeSize.TabIndex = 10;
            // 
            // cmbTime
            // 
            this.cmbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Items.AddRange(new object[] {
            "ق.ظ",
            "ب.ظ"});
            this.cmbTime.Location = new System.Drawing.Point(154, 330);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(51, 28);
            this.cmbTime.TabIndex = 13;
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(211, 331);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(41, 27);
            this.txtHour.TabIndex = 12;
            this.txtHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkSetTime
            // 
            this.chkSetTime.AutoSize = true;
            this.chkSetTime.Location = new System.Drawing.Point(41, 333);
            this.chkSetTime.Name = "chkSetTime";
            this.chkSetTime.Size = new System.Drawing.Size(107, 24);
            this.chkSetTime.TabIndex = 14;
            this.chkSetTime.Text = "تنظیم زمان دلخواه";
            this.chkSetTime.UseVisualStyleBackColor = true;
            this.chkSetTime.CheckedChanged += new System.EventHandler(this.chkSetTime_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.Location = new System.Drawing.Point(305, 166);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 30);
            this.label16.TabIndex = 71;
            this.label16.Text = "منطقه:";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(154, 170);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(145, 27);
            this.txtArea.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(305, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 30);
            this.label15.TabIndex = 69;
            this.label15.Text = "شهرستان:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(211, 137);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(88, 27);
            this.txtCity.TabIndex = 4;
            this.txtCity.Text = "مشهد";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.Location = new System.Drawing.Point(305, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 33);
            this.label14.TabIndex = 67;
            this.label14.Text = "استان:";
            // 
            // clsMain
            // 
            this.clsMain.Location = new System.Drawing.Point(212, 415);
            this.clsMain.Name = "clsMain";
            this.clsMain.Size = new System.Drawing.Size(75, 23);
            this.clsMain.TabIndex = 66;
            this.clsMain.Text = "colorSlider6";
            this.clsMain.Click += new System.EventHandler(this.clsMain_Click);
            this.clsMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clsMain_MouseClick);
            // 
            // btnEntry
            // 
            this.btnEntry.Font = new System.Drawing.Font("B Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEntry.Location = new System.Drawing.Point(6, 410);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(75, 31);
            this.btnEntry.TabIndex = 16;
            this.btnEntry.Text = "ثبت";
            this.btnEntry.UseVisualStyleBackColor = true;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // txtMinute
            // 
            this.txtMinute.Location = new System.Drawing.Point(258, 330);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(41, 27);
            this.txtMinute.TabIndex = 11;
            this.txtMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMinute.TextChanged += new System.EventHandler(this.txtMinute_TextChanged);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(211, 298);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(88, 27);
            this.txtDate.TabIndex = 9;
            // 
            // txtEndAddress
            // 
            this.txtEndAddress.Location = new System.Drawing.Point(20, 204);
            this.txtEndAddress.Name = "txtEndAddress";
            this.txtEndAddress.Size = new System.Drawing.Size(101, 27);
            this.txtEndAddress.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(305, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "زمان:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(305, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "تاریخ:";
            // 
            // lblPipeSize
            // 
            this.lblPipeSize.AutoSize = true;
            this.lblPipeSize.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPipeSize.Location = new System.Drawing.Point(305, 234);
            this.lblPipeSize.Name = "lblPipeSize";
            this.lblPipeSize.Size = new System.Drawing.Size(70, 30);
            this.lblPipeSize.TabIndex = 9;
            this.lblPipeSize.Text = "قطر لوله:";
            // 
            // lblEndAddress
            // 
            this.lblEndAddress.AutoSize = true;
            this.lblEndAddress.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblEndAddress.Location = new System.Drawing.Point(127, 202);
            this.lblEndAddress.Name = "lblEndAddress";
            this.lblEndAddress.Size = new System.Drawing.Size(83, 26);
            this.lblEndAddress.TabIndex = 8;
            this.lblEndAddress.Text = "ش.م.انتهایی:";
            // 
            // lblStartAddress
            // 
            this.lblStartAddress.AutoSize = true;
            this.lblStartAddress.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblStartAddress.Location = new System.Drawing.Point(305, 203);
            this.lblStartAddress.Name = "lblStartAddress";
            this.lblStartAddress.Size = new System.Drawing.Size(83, 26);
            this.lblStartAddress.TabIndex = 7;
            this.lblStartAddress.Text = "ش.م.ابتدایی:";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblEmployee.Location = new System.Drawing.Point(305, 65);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(71, 33);
            this.lblEmployee.TabIndex = 5;
            this.lblEmployee.Text = "کارفرما:";
            // 
            // lblContractorName
            // 
            this.lblContractorName.AutoSize = true;
            this.lblContractorName.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblContractorName.Location = new System.Drawing.Point(305, 32);
            this.lblContractorName.Name = "lblContractorName";
            this.lblContractorName.Size = new System.Drawing.Size(81, 33);
            this.lblContractorName.TabIndex = 4;
            this.lblContractorName.Text = " پیمانکار:";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(103, 104);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(196, 27);
            this.txtState.TabIndex = 3;
            this.txtState.Text = "خراسان رضوی";
            // 
            // txtStartAddress
            // 
            this.txtStartAddress.Location = new System.Drawing.Point(216, 203);
            this.txtStartAddress.Name = "txtStartAddress";
            this.txtStartAddress.Size = new System.Drawing.Size(83, 27);
            this.txtStartAddress.TabIndex = 6;
            // 
            // txtContractor
            // 
            this.txtContractor.Location = new System.Drawing.Point(103, 38);
            this.txtContractor.Name = "txtContractor";
            this.txtContractor.Size = new System.Drawing.Size(196, 27);
            this.txtContractor.TabIndex = 1;
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(103, 71);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(196, 27);
            this.txtEmployee.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtDiameter);
            this.tabPage2.Controls.Add(this.txtPercent);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtEndHour);
            this.tabPage2.Controls.Add(this.txtStartHour);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.rdbRunError);
            this.tabPage2.Controls.Add(this.rdbStructureError);
            this.tabPage2.Controls.Add(this.rdbServiceError);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cmbErrorCoding);
            this.tabPage2.Controls.Add(this.lblErrorType);
            this.tabPage2.Controls.Add(this.cmbErrorType);
            this.tabPage2.Controls.Add(this.clsR);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtAddTextR);
            this.tabPage2.Font = new System.Drawing.Font("B Mitra", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(408, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "درج خطا";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbShowError);
            this.groupBox1.Controls.Add(this.rdbNoShowError);
            this.groupBox1.Controls.Add(this.rdbShowSError);
            this.groupBox1.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(6, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 90);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "وضعیت نمایش خطا";
            // 
            // rdbShowError
            // 
            this.rdbShowError.AutoSize = true;
            this.rdbShowError.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbShowError.Location = new System.Drawing.Point(165, 27);
            this.rdbShowError.Name = "rdbShowError";
            this.rdbShowError.Size = new System.Drawing.Size(118, 26);
            this.rdbShowError.TabIndex = 74;
            this.rdbShowError.TabStop = true;
            this.rdbShowError.Text = "نمایش خطای دستی";
            this.rdbShowError.UseVisualStyleBackColor = true;
            // 
            // rdbNoShowError
            // 
            this.rdbNoShowError.AutoSize = true;
            this.rdbNoShowError.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbNoShowError.Location = new System.Drawing.Point(289, 27);
            this.rdbNoShowError.Name = "rdbNoShowError";
            this.rdbNoShowError.Size = new System.Drawing.Size(101, 26);
            this.rdbNoShowError.TabIndex = 75;
            this.rdbNoShowError.TabStop = true;
            this.rdbNoShowError.Text = "عدم نمایش خطا";
            this.rdbNoShowError.UseVisualStyleBackColor = true;
            // 
            // rdbShowSError
            // 
            this.rdbShowSError.AutoSize = true;
            this.rdbShowSError.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbShowSError.Location = new System.Drawing.Point(30, 27);
            this.rdbShowSError.Name = "rdbShowSError";
            this.rdbShowSError.Size = new System.Drawing.Size(129, 26);
            this.rdbShowSError.TabIndex = 73;
            this.rdbShowSError.TabStop = true;
            this.rdbShowSError.Text = "نمایش خطای استاندارد";
            this.rdbShowSError.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(100, 220);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 26);
            this.label13.TabIndex = 72;
            this.label13.Text = "قطر لوله";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(56, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 26);
            this.label5.TabIndex = 71;
            this.label5.Text = "mm";
            // 
            // txtDiameter
            // 
            this.txtDiameter.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDiameter.Location = new System.Drawing.Point(15, 210);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(35, 33);
            this.txtDiameter.TabIndex = 70;
            this.txtDiameter.Text = "   ";
            // 
            // txtPercent
            // 
            this.txtPercent.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPercent.Location = new System.Drawing.Point(15, 168);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(35, 33);
            this.txtPercent.TabIndex = 69;
            this.txtPercent.Text = "   ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(56, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 30);
            this.label11.TabIndex = 68;
            this.label11.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(77, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 26);
            this.label10.TabIndex = 67;
            this.label10.Text = "به میزان";
            // 
            // txtEndHour
            // 
            this.txtEndHour.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtEndHour.Location = new System.Drawing.Point(191, 168);
            this.txtEndHour.Name = "txtEndHour";
            this.txtEndHour.Size = new System.Drawing.Size(35, 33);
            this.txtEndHour.TabIndex = 66;
            // 
            // txtStartHour
            // 
            this.txtStartHour.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtStartHour.Location = new System.Drawing.Point(297, 168);
            this.txtStartHour.Name = "txtStartHour";
            this.txtStartHour.Size = new System.Drawing.Size(35, 33);
            this.txtStartHour.TabIndex = 65;
            this.txtStartHour.Text = "   ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(232, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 26);
            this.label9.TabIndex = 63;
            this.label9.Text = "تا ساعت";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(338, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 26);
            this.label8.TabIndex = 62;
            this.label8.Text = "ساعت";
            // 
            // rdbRunError
            // 
            this.rdbRunError.AutoSize = true;
            this.rdbRunError.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbRunError.Location = new System.Drawing.Point(231, 6);
            this.rdbRunError.Name = "rdbRunError";
            this.rdbRunError.Size = new System.Drawing.Size(67, 30);
            this.rdbRunError.TabIndex = 60;
            this.rdbRunError.TabStop = true;
            this.rdbRunError.Text = "اجرایی";
            this.rdbRunError.UseVisualStyleBackColor = true;
            this.rdbRunError.CheckedChanged += new System.EventHandler(this.rdbRunError_CheckedChanged);
            // 
            // rdbStructureError
            // 
            this.rdbStructureError.AutoSize = true;
            this.rdbStructureError.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbStructureError.Location = new System.Drawing.Point(151, 6);
            this.rdbStructureError.Name = "rdbStructureError";
            this.rdbStructureError.Size = new System.Drawing.Size(74, 30);
            this.rdbStructureError.TabIndex = 59;
            this.rdbStructureError.TabStop = true;
            this.rdbStructureError.Text = "سازه ای";
            this.rdbStructureError.UseVisualStyleBackColor = true;
            this.rdbStructureError.CheckedChanged += new System.EventHandler(this.rdbStructureError_CheckedChanged);
            // 
            // rdbServiceError
            // 
            this.rdbServiceError.AutoSize = true;
            this.rdbServiceError.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbServiceError.Location = new System.Drawing.Point(304, 4);
            this.rdbServiceError.Name = "rdbServiceError";
            this.rdbServiceError.Size = new System.Drawing.Size(101, 30);
            this.rdbServiceError.TabIndex = 58;
            this.rdbServiceError.TabStop = true;
            this.rdbServiceError.Text = "سرویس دهی";
            this.rdbServiceError.UseVisualStyleBackColor = true;
            this.rdbServiceError.CheckedChanged += new System.EventHandler(this.rdbServiceError_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(304, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 27);
            this.label4.TabIndex = 24;
            this.label4.Text = "کدگذاری عیب";
            // 
            // cmbErrorCoding
            // 
            this.cmbErrorCoding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbErrorCoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbErrorCoding.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbErrorCoding.FormattingEnabled = true;
            this.cmbErrorCoding.Location = new System.Drawing.Point(15, 130);
            this.cmbErrorCoding.Name = "cmbErrorCoding";
            this.cmbErrorCoding.Size = new System.Drawing.Size(371, 32);
            this.cmbErrorCoding.TabIndex = 23;
            this.cmbErrorCoding.SelectedIndexChanged += new System.EventHandler(this.cmbErrorCoding_SelectedIndexChanged);
            // 
            // lblErrorType
            // 
            this.lblErrorType.AutoSize = true;
            this.lblErrorType.Font = new System.Drawing.Font("B Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblErrorType.Location = new System.Drawing.Point(338, 33);
            this.lblErrorType.Name = "lblErrorType";
            this.lblErrorType.Size = new System.Drawing.Size(57, 27);
            this.lblErrorType.TabIndex = 22;
            this.lblErrorType.Text = "نوع عیب";
            // 
            // cmbErrorType
            // 
            this.cmbErrorType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbErrorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbErrorType.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbErrorType.FormattingEnabled = true;
            this.cmbErrorType.Location = new System.Drawing.Point(15, 63);
            this.cmbErrorType.Name = "cmbErrorType";
            this.cmbErrorType.Size = new System.Drawing.Size(371, 34);
            this.cmbErrorType.TabIndex = 21;
            this.cmbErrorType.SelectedIndexChanged += new System.EventHandler(this.cmbErrorType_SelectedIndexChanged);
            // 
            // clsR
            // 
            this.clsR.Location = new System.Drawing.Point(311, 306);
            this.clsR.Name = "clsR";
            this.clsR.Size = new System.Drawing.Size(69, 23);
            this.clsR.TabIndex = 20;
            this.clsR.Text = "colorSlider5";
            this.clsR.Click += new System.EventHandler(this.clsR_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(297, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 26);
            this.label12.TabIndex = 10;
            this.label12.Text = "نوشته دلخواه:";
            // 
            // txtAddTextR
            // 
            this.txtAddTextR.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtAddTextR.Location = new System.Drawing.Point(15, 267);
            this.txtAddTextR.Name = "txtAddTextR";
            this.txtAddTextR.Size = new System.Drawing.Size(365, 33);
            this.txtAddTextR.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.clsArrow);
            this.tabPage3.Controls.Add(this.chkArrow);
            this.tabPage3.Controls.Add(this.clsRectangle);
            this.tabPage3.Controls.Add(this.clsCircle);
            this.tabPage3.Controls.Add(this.chkRectangle);
            this.tabPage3.Controls.Add(this.chkCircle);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(408, 447);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ابزار ترسیم";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // clsArrow
            // 
            this.clsArrow.EndColor = System.Drawing.Color.Green;
            this.clsArrow.Location = new System.Drawing.Point(255, 78);
            this.clsArrow.Name = "clsArrow";
            this.clsArrow.Size = new System.Drawing.Size(69, 23);
            this.clsArrow.TabIndex = 24;
            this.clsArrow.Text = "colorSlider5";
            // 
            // chkArrow
            // 
            this.chkArrow.AutoSize = true;
            this.chkArrow.Location = new System.Drawing.Point(348, 77);
            this.chkArrow.Name = "chkArrow";
            this.chkArrow.Size = new System.Drawing.Size(49, 24);
            this.chkArrow.TabIndex = 23;
            this.chkArrow.Text = "فلش";
            this.chkArrow.UseVisualStyleBackColor = true;
            // 
            // clsRectangle
            // 
            this.clsRectangle.EndColor = System.Drawing.Color.Green;
            this.clsRectangle.Location = new System.Drawing.Point(255, 48);
            this.clsRectangle.Name = "clsRectangle";
            this.clsRectangle.Size = new System.Drawing.Size(69, 23);
            this.clsRectangle.TabIndex = 22;
            this.clsRectangle.Text = "colorSlider5";
            // 
            // clsCircle
            // 
            this.clsCircle.EndColor = System.Drawing.Color.Green;
            this.clsCircle.Location = new System.Drawing.Point(255, 18);
            this.clsCircle.Name = "clsCircle";
            this.clsCircle.Size = new System.Drawing.Size(69, 23);
            this.clsCircle.TabIndex = 21;
            this.clsCircle.Text = "colorSlider5";
            this.clsCircle.Click += new System.EventHandler(this.clsCircle_Click);
            // 
            // chkRectangle
            // 
            this.chkRectangle.AutoSize = true;
            this.chkRectangle.Location = new System.Drawing.Point(330, 48);
            this.chkRectangle.Name = "chkRectangle";
            this.chkRectangle.Size = new System.Drawing.Size(67, 24);
            this.chkRectangle.TabIndex = 2;
            this.chkRectangle.Text = "مستطیل";
            this.chkRectangle.UseVisualStyleBackColor = true;
            // 
            // chkCircle
            // 
            this.chkCircle.AutoSize = true;
            this.chkCircle.Location = new System.Drawing.Point(346, 18);
            this.chkCircle.Name = "chkCircle";
            this.chkCircle.Size = new System.Drawing.Size(51, 24);
            this.chkCircle.TabIndex = 1;
            this.chkCircle.Text = "دایره";
            this.chkCircle.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chkBranch);
            this.tabPage4.Controls.Add(this.cmbPipeShape);
            this.tabPage4.Controls.Add(this.label23);
            this.tabPage4.Controls.Add(this.cmbDutyOfPipe);
            this.tabPage4.Controls.Add(this.label22);
            this.tabPage4.Controls.Add(this.cmbProcedure);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.cmbPipeMaterial);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(408, 447);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "گزارش";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cmbPipeShape
            // 
            this.cmbPipeShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPipeShape.FormattingEnabled = true;
            this.cmbPipeShape.Items.AddRange(new object[] {
            "دایروی",
            "مستطیلی",
            "تخم مرغی",
            "دوپهن شده",
            "یوشکل",
            "کمانی",
            "نعلی شکل",
            "سایر"});
            this.cmbPipeShape.Location = new System.Drawing.Point(106, 159);
            this.cmbPipeShape.Name = "cmbPipeShape";
            this.cmbPipeShape.Size = new System.Drawing.Size(192, 28);
            this.cmbPipeShape.TabIndex = 53;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label23.Location = new System.Drawing.Point(304, 158);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 26);
            this.label23.TabIndex = 52;
            this.label23.Text = "شکل لوله:";
            // 
            // cmbDutyOfPipe
            // 
            this.cmbDutyOfPipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDutyOfPipe.FormattingEnabled = true;
            this.cmbDutyOfPipe.Items.AddRange(new object[] {
            "ترکیبی",
            "فاضلاب خانگی",
            "آبهای سطحی",
            "فاضلاب صنعتی",
            " سایر"});
            this.cmbDutyOfPipe.Location = new System.Drawing.Point(106, 125);
            this.cmbDutyOfPipe.Name = "cmbDutyOfPipe";
            this.cmbDutyOfPipe.Size = new System.Drawing.Size(192, 28);
            this.cmbDutyOfPipe.TabIndex = 51;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label22.Location = new System.Drawing.Point(304, 124);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 26);
            this.label22.TabIndex = 50;
            this.label22.Text = "نوع شبکه:";
            // 
            // cmbProcedure
            // 
            this.cmbProcedure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcedure.FormattingEnabled = true;
            this.cmbProcedure.Items.AddRange(new object[] {
            "تونل",
            "ترانشه"});
            this.cmbProcedure.Location = new System.Drawing.Point(106, 91);
            this.cmbProcedure.Name = "cmbProcedure";
            this.cmbProcedure.Size = new System.Drawing.Size(192, 28);
            this.cmbProcedure.TabIndex = 49;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label21.Location = new System.Drawing.Point(304, 90);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 26);
            this.label21.TabIndex = 48;
            this.label21.Text = "روش اجرا:";
            // 
            // cmbPipeMaterial
            // 
            this.cmbPipeMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPipeMaterial.FormattingEnabled = true;
            this.cmbPipeMaterial.Items.AddRange(new object[] {
            "بتونی",
            "آجری",
            "اپوکسی",
            "آزبست",
            "آهن",
            "فولاد",
            "پلاستیک تقویت شده",
            "کامپوزیت",
            "پلی اتیلن",
            "پلی استر",
            "پی وی سی",
            "نوع نامشخصی از آهن یا استیل",
            "نوع نامشخصی از  ترکیبات پلاستک",
            "سایر"});
            this.cmbPipeMaterial.Location = new System.Drawing.Point(106, 57);
            this.cmbPipeMaterial.Name = "cmbPipeMaterial";
            this.cmbPipeMaterial.Size = new System.Drawing.Size(192, 28);
            this.cmbPipeMaterial.TabIndex = 47;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label20.Location = new System.Drawing.Point(304, 56);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 26);
            this.label20.TabIndex = 46;
            this.label20.Text = "جنس لوله:";
            // 
            // btnNewProject
            // 
            this.btnNewProject.Font = new System.Drawing.Font("B Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNewProject.Location = new System.Drawing.Point(466, 21);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(84, 31);
            this.btnNewProject.TabIndex = 75;
            this.btnNewProject.Text = "پروژه جدید";
            this.btnNewProject.UseVisualStyleBackColor = true;
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click);
            // 
            // grpMotor
            // 
            this.grpMotor.Controls.Add(this.label7);
            this.grpMotor.Controls.Add(this.label6);
            this.grpMotor.Controls.Add(this.btnStop);
            this.grpMotor.Controls.Add(this.chkBackward);
            this.grpMotor.Controls.Add(this.chkForward);
            this.grpMotor.Controls.Add(this.btnBackward);
            this.grpMotor.Controls.Add(this.btnForward);
            this.grpMotor.Controls.Add(this.trbSpeedControl);
            this.grpMotor.Location = new System.Drawing.Point(342, 514);
            this.grpMotor.Name = "grpMotor";
            this.grpMotor.Size = new System.Drawing.Size(225, 178);
            this.grpMotor.TabIndex = 59;
            this.grpMotor.TabStop = false;
            this.grpMotor.Text = "Motor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Stop";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Max";
            // 
            // grpCamera
            // 
            this.grpCamera.Controls.Add(this.lblCounterTakingPhoto);
            this.grpCamera.Controls.Add(this.trbLighting);
            this.grpCamera.Controls.Add(this.btnRec);
            this.grpCamera.Controls.Add(this.btnZoomOut);
            this.grpCamera.Controls.Add(this.btnZoomIn);
            this.grpCamera.Controls.Add(this.trbSpeedRotation);
            this.grpCamera.Controls.Add(this.btnCameraPanLeft);
            this.grpCamera.Controls.Add(this.btnCameraTiltDown);
            this.grpCamera.Controls.Add(this.btnCameraPanRight);
            this.grpCamera.Controls.Add(this.btnCameraTiltUp);
            this.grpCamera.Controls.Add(this.btnGetImage);
            this.grpCamera.Controls.Add(this.btnStopRecord);
            this.grpCamera.Controls.Add(this.btnRecord);
            this.grpCamera.Controls.Add(this.btnSelectCamera);
            this.grpCamera.Controls.Add(this.lblRec);
            this.grpCamera.Location = new System.Drawing.Point(13, 509);
            this.grpCamera.Name = "grpCamera";
            this.grpCamera.Size = new System.Drawing.Size(324, 171);
            this.grpCamera.TabIndex = 60;
            this.grpCamera.TabStop = false;
            this.grpCamera.Text = "       ";
            // 
            // lblCounterTakingPhoto
            // 
            this.lblCounterTakingPhoto.AutoSize = true;
            this.lblCounterTakingPhoto.Location = new System.Drawing.Point(182, 36);
            this.lblCounterTakingPhoto.Name = "lblCounterTakingPhoto";
            this.lblCounterTakingPhoto.Size = new System.Drawing.Size(13, 13);
            this.lblCounterTakingPhoto.TabIndex = 76;
            this.lblCounterTakingPhoto.Text = "0";
            // 
            // trbLighting
            // 
            this.trbLighting.LargeChange = 64;
            this.trbLighting.Location = new System.Drawing.Point(138, 69);
            this.trbLighting.Maximum = 255;
            this.trbLighting.Name = "trbLighting";
            this.trbLighting.Size = new System.Drawing.Size(180, 45);
            this.trbLighting.SmallChange = 16;
            this.trbLighting.TabIndex = 70;
            this.trbLighting.TickFrequency = 32;
            this.trbLighting.Value = 255;
            this.trbLighting.ValueChanged += new System.EventHandler(this.trbLighting_ValueChanged);
            // 
            // btnRec
            // 
            this.btnRec.Image = global::SewerRobot.Properties.Resources.Recordin;
            this.btnRec.Location = new System.Drawing.Point(302, 22);
            this.btnRec.Name = "btnRec";
            this.btnRec.Size = new System.Drawing.Size(16, 16);
            this.btnRec.TabIndex = 68;
            this.btnRec.UseVisualStyleBackColor = true;
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Image = global::SewerRobot.Properties.Resources.zoom_out_32;
            this.btnZoomOut.Location = new System.Drawing.Point(94, 65);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(38, 38);
            this.btnZoomOut.TabIndex = 67;
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            this.btnZoomOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZoomOut_MouseDown);
            this.btnZoomOut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnZoomOut_MouseUp);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Image = global::SewerRobot.Properties.Resources.zoom_in_32;
            this.btnZoomIn.Location = new System.Drawing.Point(6, 66);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(38, 38);
            this.btnZoomIn.TabIndex = 66;
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            this.btnZoomIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZoomIn_MouseDown);
            this.btnZoomIn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnZoomIn_MouseUp);
            // 
            // trbSpeedRotation
            // 
            this.trbSpeedRotation.LargeChange = 16;
            this.trbSpeedRotation.Location = new System.Drawing.Point(138, 120);
            this.trbSpeedRotation.Maximum = 63;
            this.trbSpeedRotation.Name = "trbSpeedRotation";
            this.trbSpeedRotation.Size = new System.Drawing.Size(180, 45);
            this.trbSpeedRotation.SmallChange = 16;
            this.trbSpeedRotation.TabIndex = 64;
            this.trbSpeedRotation.Value = 56;
            // 
            // btnCameraPanLeft
            // 
            this.btnCameraPanLeft.Location = new System.Drawing.Point(6, 109);
            this.btnCameraPanLeft.Name = "btnCameraPanLeft";
            this.btnCameraPanLeft.Size = new System.Drawing.Size(38, 38);
            this.btnCameraPanLeft.TabIndex = 63;
            this.btnCameraPanLeft.Text = "Left";
            this.btnCameraPanLeft.UseVisualStyleBackColor = true;
            this.btnCameraPanLeft.Click += new System.EventHandler(this.btnCameraPanLeft_Click);
            this.btnCameraPanLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCameraPanLeft_MouseDown);
            this.btnCameraPanLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCameraPanLeft_MouseUp);
            // 
            // btnCameraTiltDown
            // 
            this.btnCameraTiltDown.Location = new System.Drawing.Point(50, 109);
            this.btnCameraTiltDown.Name = "btnCameraTiltDown";
            this.btnCameraTiltDown.Size = new System.Drawing.Size(38, 38);
            this.btnCameraTiltDown.TabIndex = 62;
            this.btnCameraTiltDown.Text = "Down";
            this.btnCameraTiltDown.UseVisualStyleBackColor = true;
            this.btnCameraTiltDown.Click += new System.EventHandler(this.btnCameraTiltDown_Click);
            this.btnCameraTiltDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCameraTiltDown_MouseDown);
            this.btnCameraTiltDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCameraTiltDown_MouseUp);
            // 
            // btnCameraPanRight
            // 
            this.btnCameraPanRight.Location = new System.Drawing.Point(94, 109);
            this.btnCameraPanRight.Name = "btnCameraPanRight";
            this.btnCameraPanRight.Size = new System.Drawing.Size(38, 38);
            this.btnCameraPanRight.TabIndex = 61;
            this.btnCameraPanRight.Text = "Right";
            this.btnCameraPanRight.UseVisualStyleBackColor = true;
            this.btnCameraPanRight.Click += new System.EventHandler(this.btnCameraPanRight_Click);
            this.btnCameraPanRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCameraPanRight_MouseDown);
            this.btnCameraPanRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCameraPanRight_MouseUp);
            // 
            // btnCameraTiltUp
            // 
            this.btnCameraTiltUp.Location = new System.Drawing.Point(50, 65);
            this.btnCameraTiltUp.Name = "btnCameraTiltUp";
            this.btnCameraTiltUp.Size = new System.Drawing.Size(38, 38);
            this.btnCameraTiltUp.TabIndex = 60;
            this.btnCameraTiltUp.Text = "Up";
            this.btnCameraTiltUp.UseVisualStyleBackColor = true;
            this.btnCameraTiltUp.Click += new System.EventHandler(this.btnCameraTiltUp_Click);
            this.btnCameraTiltUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCameraTiltUp_MouseDown);
            this.btnCameraTiltUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCameraTiltUp_MouseUp);
            // 
            // btnGetImage
            // 
            this.btnGetImage.Image = global::SewerRobot.Properties.Resources.take_photo;
            this.btnGetImage.Location = new System.Drawing.Point(138, 23);
            this.btnGetImage.Name = "btnGetImage";
            this.btnGetImage.Size = new System.Drawing.Size(38, 38);
            this.btnGetImage.TabIndex = 59;
            this.btnGetImage.UseVisualStyleBackColor = true;
            this.btnGetImage.Click += new System.EventHandler(this.btnGetImage_Click);
            // 
            // btnStopRecord
            // 
            this.btnStopRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnStopRecord.Image")));
            this.btnStopRecord.Location = new System.Drawing.Point(94, 23);
            this.btnStopRecord.Name = "btnStopRecord";
            this.btnStopRecord.Size = new System.Drawing.Size(38, 38);
            this.btnStopRecord.TabIndex = 56;
            this.btnStopRecord.UseVisualStyleBackColor = true;
            this.btnStopRecord.Click += new System.EventHandler(this.btnStopRecord_Click);
            this.btnStopRecord.MouseHover += new System.EventHandler(this.btnStopRecord_MouseHover);
            // 
            // btnRecord
            // 
            this.btnRecord.AutoSize = true;
            this.btnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRecord.Image = global::SewerRobot.Properties.Resources.Recording1;
            this.btnRecord.Location = new System.Drawing.Point(50, 23);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(38, 38);
            this.btnRecord.TabIndex = 44;
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnSelectCamera
            // 
            this.btnSelectCamera.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectCamera.Image")));
            this.btnSelectCamera.Location = new System.Drawing.Point(6, 23);
            this.btnSelectCamera.Name = "btnSelectCamera";
            this.btnSelectCamera.Size = new System.Drawing.Size(38, 38);
            this.btnSelectCamera.TabIndex = 6;
            this.btnSelectCamera.UseVisualStyleBackColor = true;
            this.btnSelectCamera.Click += new System.EventHandler(this.btnSelectCamera_Click);
            // 
            // lblRec
            // 
            this.lblRec.AutoSize = true;
            this.lblRec.Font = new System.Drawing.Font("B Mitra", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRec.ForeColor = System.Drawing.Color.Red;
            this.lblRec.Location = new System.Drawing.Point(273, 20);
            this.lblRec.Name = "lblRec";
            this.lblRec.Size = new System.Drawing.Size(33, 21);
            this.lblRec.TabIndex = 69;
            this.lblRec.Text = "ضبط";
            // 
            // grpSensors
            // 
            this.grpSensors.Controls.Add(this.btnAngleOffsett);
            this.grpSensors.Controls.Add(this.label19);
            this.grpSensors.Controls.Add(this.txtAngOffset);
            this.grpSensors.Controls.Add(this.btnNewProject);
            this.grpSensors.Controls.Add(this.btnDistanceOffsett);
            this.grpSensors.Controls.Add(this.btnAvgAngle);
            this.grpSensors.Controls.Add(this.txtAngle);
            this.grpSensors.Controls.Add(this.lblError);
            this.grpSensors.Controls.Add(this.txtDistance);
            this.grpSensors.Controls.Add(this.lblDistance);
            this.grpSensors.Controls.Add(this.label3);
            this.grpSensors.Controls.Add(this.lblFps);
            this.grpSensors.Location = new System.Drawing.Point(583, 514);
            this.grpSensors.Name = "grpSensors";
            this.grpSensors.Size = new System.Drawing.Size(569, 178);
            this.grpSensors.TabIndex = 61;
            this.grpSensors.TabStop = false;
            this.grpSensors.Text = "Sensors       ";
            // 
            // btnAngleOffsett
            // 
            this.btnAngleOffsett.Location = new System.Drawing.Point(263, 102);
            this.btnAngleOffsett.Name = "btnAngleOffsett";
            this.btnAngleOffsett.Size = new System.Drawing.Size(107, 23);
            this.btnAngleOffsett.TabIndex = 78;
            this.btnAngleOffsett.Text = "صفر کردن شیب";
            this.btnAngleOffsett.UseVisualStyleBackColor = true;
            this.btnAngleOffsett.Click += new System.EventHandler(this.btnAngleOffsett_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label19.Location = new System.Drawing.Point(160, 106);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label19.Size = new System.Drawing.Size(43, 20);
            this.label19.TabIndex = 77;
            this.label19.Text = "Offset";
            // 
            // txtAngOffset
            // 
            this.txtAngOffset.Location = new System.Drawing.Point(205, 105);
            this.txtAngOffset.Name = "txtAngOffset";
            this.txtAngOffset.Size = new System.Drawing.Size(52, 20);
            this.txtAngOffset.TabIndex = 76;
            this.txtAngOffset.Text = "-2.9";
            // 
            // btnDistanceOffsett
            // 
            this.btnDistanceOffsett.Location = new System.Drawing.Point(263, 131);
            this.btnDistanceOffsett.Name = "btnDistanceOffsett";
            this.btnDistanceOffsett.Size = new System.Drawing.Size(107, 23);
            this.btnDistanceOffsett.TabIndex = 66;
            this.btnDistanceOffsett.Text = "صفر کردن مسافت";
            this.btnDistanceOffsett.UseVisualStyleBackColor = true;
            this.btnDistanceOffsett.Click += new System.EventHandler(this.btnDistanceOffsett_Click);
            // 
            // btnAvgAngle
            // 
            this.btnAvgAngle.Location = new System.Drawing.Point(48, 101);
            this.btnAvgAngle.Name = "btnAvgAngle";
            this.btnAvgAngle.Size = new System.Drawing.Size(106, 23);
            this.btnAvgAngle.TabIndex = 65;
            this.btnAvgAngle.Text = "متوسط شیب";
            this.btnAvgAngle.UseVisualStyleBackColor = true;
            this.btnAvgAngle.Click += new System.EventHandler(this.btnAvgAngle_Click);
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(375, 104);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(100, 20);
            this.txtAngle.TabIndex = 49;
            this.txtAngle.TextChanged += new System.EventHandler(this.txtAngle_TextChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(6, 148);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(29, 13);
            this.lblError.TabIndex = 48;
            this.lblError.Text = "Error";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(376, 130);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 20);
            this.txtDistance.TabIndex = 47;
            this.txtDistance.TextChanged += new System.EventHandler(this.txtDistance_TextChanged);
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDistance.Location = new System.Drawing.Point(497, 127);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDistance.Size = new System.Drawing.Size(55, 26);
            this.lblDistance.TabIndex = 2;
            this.lblDistance.Text = "مسافت:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(508, 101);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(44, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "شیب:";
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlbQuit,
            this.tlbConnect,
            this.toolStripButton3,
            this.tllHelp,
            this.tllAboutUs});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1165, 25);
            this.toolStrip.TabIndex = 63;
            this.toolStrip.Text = "toolStrip1";
            this.toolStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip_MouseDown);
            // 
            // tlbQuit
            // 
            this.tlbQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlbQuit.Image = global::SewerRobot.Properties.Resources.Close;
            this.tlbQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbQuit.Name = "tlbQuit";
            this.tlbQuit.Size = new System.Drawing.Size(23, 22);
            this.tlbQuit.Click += new System.EventHandler(this.tlbQuit_Click);
            // 
            // tlbConnect
            // 
            this.tlbConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlbConnect.Image = global::SewerRobot.Properties.Resources.Disconnect;
            this.tlbConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbConnect.Name = "tlbConnect";
            this.tlbConnect.Size = new System.Drawing.Size(23, 22);
            this.tlbConnect.Click += new System.EventHandler(this.tlbConnect_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::SewerRobot.Properties.Resources.Setting;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // tllHelp
            // 
            this.tllHelp.Name = "tllHelp";
            this.tllHelp.Size = new System.Drawing.Size(32, 22);
            this.tllHelp.Text = "Help";
            // 
            // tllAboutUs
            // 
            this.tllAboutUs.Name = "tllAboutUs";
            this.tllAboutUs.Size = new System.Drawing.Size(56, 22);
            this.tllAboutUs.Text = "About Us";
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.BorderColor = System.Drawing.Color.White;
            this.videoSourcePlayer.Location = new System.Drawing.Point(12, 28);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.videoSourcePlayer.Size = new System.Drawing.Size(720, 480);
            this.videoSourcePlayer.TabIndex = 64;
            this.videoSourcePlayer.Text = "videoSourcePlayer";
            this.videoSourcePlayer.VideoSource = null;
            this.videoSourcePlayer.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer_NewFrame);
            this.videoSourcePlayer.Paint += new System.Windows.Forms.PaintEventHandler(this.videoSourcePlayer_Paint);
            this.videoSourcePlayer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.videoSourcePlayer_MouseDown);
            this.videoSourcePlayer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.videoSourcePlayer_MouseMove);
            this.videoSourcePlayer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.videoSourcePlayer_MouseUp);
            // 
            // colorDialog1
            // 
            this.colorDialog1.SolidColorOnly = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chkBranch
            // 
            this.chkBranch.AutoSize = true;
            this.chkBranch.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkBranch.Location = new System.Drawing.Point(227, 193);
            this.chkBranch.Name = "chkBranch";
            this.chkBranch.Size = new System.Drawing.Size(71, 30);
            this.chkBranch.TabIndex = 55;
            this.chkBranch.Text = "انشعاب";
            this.chkBranch.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 695);
            this.Controls.Add(this.videoSourcePlayer);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.grpSensors);
            this.Controls.Add(this.grpCamera);
            this.Controls.Add(this.grpMotor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sewer Robot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMain_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.trbSpeedControl)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.grpMotor.ResumeLayout(false);
            this.grpMotor.PerformLayout();
            this.grpCamera.ResumeLayout(false);
            this.grpCamera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbLighting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSpeedRotation)).EndInit();
            this.grpSensors.ResumeLayout(false);
            this.grpSensors.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectCamera;
        private System.Windows.Forms.Label lblFps;
        private System.Windows.Forms.Timer tmrFps;
        private System.Windows.Forms.Timer tmrRecord;
        private System.Windows.Forms.TrackBar trbSpeedControl;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.CheckBox chkForward;
        private System.Windows.Forms.CheckBox chkBackward;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grpMotor;
        private System.Windows.Forms.GroupBox grpCamera;
        private System.Windows.Forms.GroupBox grpSensors;
        private System.Windows.Forms.Label lblEndAddress;
        private System.Windows.Forms.Label lblStartAddress;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblContractorName;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtStartAddress;
        private System.Windows.Forms.TextBox txtContractor;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPipeSize;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtEndAddress;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tlbConnect;
        private System.Windows.Forms.ToolStripButton tlbQuit;
        private System.Windows.Forms.ToolStripLabel tllHelp;
        private System.Windows.Forms.ToolStripLabel tllAboutUs;
        private System.Windows.Forms.Button btnEntry;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnStopRecord;
        private System.Windows.Forms.TextBox txtAddTextR;
        private System.Windows.Forms.Label label12;
        private AForge.Controls.ColorSlider clsMain;
        private AForge.Controls.ColorSlider clsR;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Button btnAvgAngle;
        private System.Windows.Forms.Button btnGetImage;
        private System.Windows.Forms.Button btnCameraPanLeft;
        private System.Windows.Forms.Button btnCameraTiltDown;
        private System.Windows.Forms.Button btnCameraPanRight;
        private System.Windows.Forms.Button btnCameraTiltUp;
        private System.Windows.Forms.Label lblErrorType;
        private System.Windows.Forms.ComboBox cmbErrorType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbStructureError;
        private System.Windows.Forms.RadioButton rdbServiceError;
        private System.Windows.Forms.ComboBox cmbErrorCoding;
        private System.Windows.Forms.RadioButton rdbRunError;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEndHour;
        private System.Windows.Forms.TextBox txtStartHour;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trbSpeedRotation;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private AForge.Controls.ColorSlider clsRectangle;
        private AForge.Controls.ColorSlider clsCircle;
        private System.Windows.Forms.CheckBox chkRectangle;
        private System.Windows.Forms.CheckBox chkCircle;
        private AForge.Controls.ColorSlider clsArrow;
        private System.Windows.Forms.CheckBox chkArrow;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnDistanceOffsett;
        private System.Windows.Forms.CheckBox chkSetTime;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Button btnRec;
        private System.Windows.Forms.Label lblRec;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.ComboBox cmbPipeSize;
        private System.Windows.Forms.ComboBox cmbDirection;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.RadioButton rdbShowError;
        private System.Windows.Forms.RadioButton rdbShowSError;
        private System.Windows.Forms.RadioButton rdbNoShowError;
        private System.Windows.Forms.TrackBar trbLighting;
        private System.Windows.Forms.Label lblCounterTakingPhoto;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtAngOffset;
        private System.Windows.Forms.Button btnAngleOffsett;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox cmbPipeShape;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmbDutyOfPipe;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbProcedure;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbPipeMaterial;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox chkBranch;
    }
}

