﻿namespace HMI_Winform
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStop = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPause = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSetting = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.lblIO = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbLight03 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.lbLight02 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbLight01 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbLight00 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbMode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblLamp04UI = new System.Windows.Forms.Label();
            this.lblLamp01UI = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLamp02UI = new System.Windows.Forms.Label();
            this.lblLamp03UI = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblPauseIOPage = new System.Windows.Forms.Label();
            this.lblStopIOPage = new System.Windows.Forms.Label();
            this.lblStartIOPage = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalibMode = new System.Windows.Forms.Button();
            this.btnSettingMode = new System.Windows.Forms.Button();
            this.btnManualMode = new System.Windows.Forms.Button();
            this.btnAutoMode = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.lblStop);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblPause);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblStart);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblSetting);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblLog);
            this.panel1.Controls.Add(this.lblIO);
            this.panel1.Controls.Add(this.lblHome);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 90);
            this.panel1.TabIndex = 0;
            // 
            // lblStop
            // 
            this.lblStop.BackColor = System.Drawing.Color.Green;
            this.lblStop.Image = ((System.Drawing.Image)(resources.GetObject("lblStop.Image")));
            this.lblStop.Location = new System.Drawing.Point(665, 6);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(78, 59);
            this.lblStop.TabIndex = 13;
            this.lblStop.Click += new System.EventHandler(this.lblStop_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(665, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 18);
            this.label13.TabIndex = 12;
            this.label13.Text = "Stop";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(555, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 18);
            this.label12.TabIndex = 11;
            this.label12.Text = "Pause";
            // 
            // lblPause
            // 
            this.lblPause.BackColor = System.Drawing.Color.Green;
            this.lblPause.Image = ((System.Drawing.Image)(resources.GetObject("lblPause.Image")));
            this.lblPause.Location = new System.Drawing.Point(555, 6);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(78, 59);
            this.lblPause.TabIndex = 10;
            this.lblPause.Click += new System.EventHandler(this.lblPause_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(445, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Start";
            // 
            // lblStart
            // 
            this.lblStart.BackColor = System.Drawing.Color.Green;
            this.lblStart.Image = ((System.Drawing.Image)(resources.GetObject("lblStart.Image")));
            this.lblStart.Location = new System.Drawing.Point(445, 6);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(78, 59);
            this.lblStart.TabIndex = 8;
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(335, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Setting Page";
            // 
            // lblSetting
            // 
            this.lblSetting.BackColor = System.Drawing.Color.Green;
            this.lblSetting.Image = ((System.Drawing.Image)(resources.GetObject("lblSetting.Image")));
            this.lblSetting.Location = new System.Drawing.Point(335, 6);
            this.lblSetting.Name = "lblSetting";
            this.lblSetting.Size = new System.Drawing.Size(78, 59);
            this.lblSetting.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(225, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Log Page";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(115, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "IO Page";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Home Page";
            // 
            // lblLog
            // 
            this.lblLog.BackColor = System.Drawing.Color.Green;
            this.lblLog.Image = ((System.Drawing.Image)(resources.GetObject("lblLog.Image")));
            this.lblLog.Location = new System.Drawing.Point(225, 6);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(78, 59);
            this.lblLog.TabIndex = 2;
            this.lblLog.Click += new System.EventHandler(this.lblLog_Click);
            // 
            // lblIO
            // 
            this.lblIO.BackColor = System.Drawing.Color.Green;
            this.lblIO.Image = ((System.Drawing.Image)(resources.GetObject("lblIO.Image")));
            this.lblIO.Location = new System.Drawing.Point(115, 7);
            this.lblIO.Name = "lblIO";
            this.lblIO.Size = new System.Drawing.Size(78, 59);
            this.lblIO.TabIndex = 1;
            this.lblIO.Click += new System.EventHandler(this.lblIO_Click);
            // 
            // lblHome
            // 
            this.lblHome.BackColor = System.Drawing.Color.Green;
            this.lblHome.Image = ((System.Drawing.Image)(resources.GetObject("lblHome.Image")));
            this.lblHome.Location = new System.Drawing.Point(5, 6);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(78, 59);
            this.lblHome.TabIndex = 0;
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(8, 96);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(851, 657);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.lbMode);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(843, 628);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MainPage";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox2.Controls.Add(this.lbLight03);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.lbLight02);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lbLight01);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lbLight00);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(20, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 328);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Light Rolling";
            // 
            // lbLight03
            // 
            this.lbLight03.ImageIndex = 0;
            this.lbLight03.ImageList = this.imageList1;
            this.lbLight03.Location = new System.Drawing.Point(19, 259);
            this.lbLight03.Name = "lbLight03";
            this.lbLight03.Size = new System.Drawing.Size(60, 60);
            this.lbLight03.TabIndex = 5;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "dot_red_96px.png");
            this.imageList1.Images.SetKeyName(1, "dot_green_96px.png");
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(95, 278);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 17);
            this.label17.TabIndex = 9;
            this.label17.Text = "Light04";
            // 
            // lbLight02
            // 
            this.lbLight02.ImageIndex = 0;
            this.lbLight02.ImageList = this.imageList1;
            this.lbLight02.Location = new System.Drawing.Point(19, 179);
            this.lbLight02.Name = "lbLight02";
            this.lbLight02.Size = new System.Drawing.Size(60, 60);
            this.lbLight02.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(95, 201);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 17);
            this.label16.TabIndex = 8;
            this.label16.Text = "Light03";
            // 
            // lbLight01
            // 
            this.lbLight01.ImageIndex = 0;
            this.lbLight01.ImageList = this.imageList1;
            this.lbLight01.Location = new System.Drawing.Point(19, 102);
            this.lbLight01.Name = "lbLight01";
            this.lbLight01.Size = new System.Drawing.Size(60, 60);
            this.lbLight01.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(85, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 17);
            this.label15.TabIndex = 7;
            this.label15.Text = "Light02";
            // 
            // lbLight00
            // 
            this.lbLight00.ImageIndex = 0;
            this.lbLight00.ImageList = this.imageList1;
            this.lbLight00.Location = new System.Drawing.Point(19, 33);
            this.lbLight00.Name = "lbLight00";
            this.lbLight00.Size = new System.Drawing.Size(60, 60);
            this.lbLight00.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(85, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Light01";
            // 
            // lbMode
            // 
            this.lbMode.AutoSize = true;
            this.lbMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMode.Location = new System.Drawing.Point(169, 28);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(43, 25);
            this.lbMode.TabIndex = 1;
            this.lbMode.Text = "Idle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Machine Mode:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Bisque;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(843, 628);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "IO Page";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Silver;
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.lblLamp04UI);
            this.groupBox4.Controls.Add(this.lblLamp01UI);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.lblLamp02UI);
            this.groupBox4.Controls.Add(this.lblLamp03UI);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(472, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(313, 366);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Output";
            // 
            // label2
            // 
            this.label2.ImageIndex = 0;
            this.label2.ImageList = this.imageList1;
            this.label2.Location = new System.Drawing.Point(24, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 60);
            this.label2.TabIndex = 13;
            // 
            // label19
            // 
            this.label19.ImageIndex = 0;
            this.label19.ImageList = this.imageList1;
            this.label19.Location = new System.Drawing.Point(24, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 60);
            this.label19.TabIndex = 10;
            // 
            // lblLamp04UI
            // 
            this.lblLamp04UI.AutoSize = true;
            this.lblLamp04UI.Location = new System.Drawing.Point(100, 277);
            this.lblLamp04UI.Name = "lblLamp04UI";
            this.lblLamp04UI.Size = new System.Drawing.Size(55, 17);
            this.lblLamp04UI.TabIndex = 17;
            this.lblLamp04UI.Text = "Light04";
            // 
            // lblLamp01UI
            // 
            this.lblLamp01UI.AutoSize = true;
            this.lblLamp01UI.Location = new System.Drawing.Point(90, 54);
            this.lblLamp01UI.Name = "lblLamp01UI";
            this.lblLamp01UI.Size = new System.Drawing.Size(55, 17);
            this.lblLamp01UI.TabIndex = 14;
            this.lblLamp01UI.Text = "Light01";
            this.lblLamp01UI.Click += new System.EventHandler(this.lblLamp01UI_Click);
            this.lblLamp01UI.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblLamp01UI_MouseDown);
            // 
            // label7
            // 
            this.label7.ImageIndex = 0;
            this.label7.ImageList = this.imageList1;
            this.label7.Location = new System.Drawing.Point(24, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 60);
            this.label7.TabIndex = 12;
            // 
            // lblLamp02UI
            // 
            this.lblLamp02UI.AutoSize = true;
            this.lblLamp02UI.Location = new System.Drawing.Point(90, 114);
            this.lblLamp02UI.Name = "lblLamp02UI";
            this.lblLamp02UI.Size = new System.Drawing.Size(55, 17);
            this.lblLamp02UI.TabIndex = 15;
            this.lblLamp02UI.Text = "Light02";
            // 
            // lblLamp03UI
            // 
            this.lblLamp03UI.AutoSize = true;
            this.lblLamp03UI.Location = new System.Drawing.Point(100, 200);
            this.lblLamp03UI.Name = "lblLamp03UI";
            this.lblLamp03UI.Size = new System.Drawing.Size(55, 17);
            this.lblLamp03UI.TabIndex = 16;
            this.lblLamp03UI.Text = "Light03";
            // 
            // label11
            // 
            this.label11.ImageIndex = 0;
            this.label11.ImageList = this.imageList1;
            this.label11.Location = new System.Drawing.Point(24, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 60);
            this.label11.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.lblPauseIOPage);
            this.groupBox3.Controls.Add(this.lblStopIOPage);
            this.groupBox3.Controls.Add(this.lblStartIOPage);
            this.groupBox3.Location = new System.Drawing.Point(6, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 366);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Input";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(74, 182);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(37, 17);
            this.label26.TabIndex = 5;
            this.label26.Text = "Stop";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(72, 114);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(48, 17);
            this.label25.TabIndex = 4;
            this.label25.Text = "Pause";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(72, 54);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 17);
            this.label24.TabIndex = 3;
            this.label24.Text = "Start";
            // 
            // lblPauseIOPage
            // 
            this.lblPauseIOPage.ImageIndex = 0;
            this.lblPauseIOPage.ImageList = this.imageList1;
            this.lblPauseIOPage.Location = new System.Drawing.Point(6, 92);
            this.lblPauseIOPage.Name = "lblPauseIOPage";
            this.lblPauseIOPage.Size = new System.Drawing.Size(60, 60);
            this.lblPauseIOPage.TabIndex = 2;
            // 
            // lblStopIOPage
            // 
            this.lblStopIOPage.ImageIndex = 0;
            this.lblStopIOPage.ImageList = this.imageList1;
            this.lblStopIOPage.Location = new System.Drawing.Point(6, 161);
            this.lblStopIOPage.Name = "lblStopIOPage";
            this.lblStopIOPage.Size = new System.Drawing.Size(60, 60);
            this.lblStopIOPage.TabIndex = 1;
            // 
            // lblStartIOPage
            // 
            this.lblStartIOPage.ImageIndex = 0;
            this.lblStartIOPage.ImageList = this.imageList1;
            this.lblStartIOPage.Location = new System.Drawing.Point(6, 32);
            this.lblStartIOPage.Name = "lblStartIOPage";
            this.lblStartIOPage.Size = new System.Drawing.Size(60, 60);
            this.lblStartIOPage.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Beige;
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(843, 628);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Log Page";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 24;
            this.dataGridView1.Location = new System.Drawing.Point(21, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(733, 595);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnCalibMode);
            this.groupBox1.Controls.Add(this.btnSettingMode);
            this.groupBox1.Controls.Add(this.btnManualMode);
            this.groupBox1.Controls.Add(this.btnAutoMode);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(865, 393);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 356);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode Select";
            // 
            // btnCalibMode
            // 
            this.btnCalibMode.Image = ((System.Drawing.Image)(resources.GetObject("btnCalibMode.Image")));
            this.btnCalibMode.Location = new System.Drawing.Point(10, 270);
            this.btnCalibMode.Name = "btnCalibMode";
            this.btnCalibMode.Size = new System.Drawing.Size(146, 72);
            this.btnCalibMode.TabIndex = 3;
            this.btnCalibMode.Text = "Calib";
            this.btnCalibMode.UseVisualStyleBackColor = true;
            this.btnCalibMode.Click += new System.EventHandler(this.btnCalibMode_Click);
            // 
            // btnSettingMode
            // 
            this.btnSettingMode.Image = ((System.Drawing.Image)(resources.GetObject("btnSettingMode.Image")));
            this.btnSettingMode.Location = new System.Drawing.Point(10, 190);
            this.btnSettingMode.Name = "btnSettingMode";
            this.btnSettingMode.Size = new System.Drawing.Size(146, 72);
            this.btnSettingMode.TabIndex = 2;
            this.btnSettingMode.Text = "Setting";
            this.btnSettingMode.UseVisualStyleBackColor = true;
            this.btnSettingMode.Click += new System.EventHandler(this.btnSettingMode_Click);
            // 
            // btnManualMode
            // 
            this.btnManualMode.Image = ((System.Drawing.Image)(resources.GetObject("btnManualMode.Image")));
            this.btnManualMode.Location = new System.Drawing.Point(10, 110);
            this.btnManualMode.Name = "btnManualMode";
            this.btnManualMode.Size = new System.Drawing.Size(146, 72);
            this.btnManualMode.TabIndex = 1;
            this.btnManualMode.Text = "Manual";
            this.btnManualMode.UseVisualStyleBackColor = true;
            this.btnManualMode.Click += new System.EventHandler(this.btnManualMode_Click);
            // 
            // btnAutoMode
            // 
            this.btnAutoMode.Image = ((System.Drawing.Image)(resources.GetObject("btnAutoMode.Image")));
            this.btnAutoMode.Location = new System.Drawing.Point(10, 30);
            this.btnAutoMode.Name = "btnAutoMode";
            this.btnAutoMode.Size = new System.Drawing.Size(146, 72);
            this.btnAutoMode.TabIndex = 0;
            this.btnAutoMode.Text = "Auto";
            this.btnAutoMode.UseVisualStyleBackColor = true;
            this.btnAutoMode.Click += new System.EventHandler(this.btnAutoMode_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 765);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label lblIO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSetting;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalibMode;
        private System.Windows.Forms.Button btnSettingMode;
        private System.Windows.Forms.Button btnManualMode;
        private System.Windows.Forms.Button btnAutoMode;
        private System.Windows.Forms.Label lbLight00;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbLight03;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbLight02;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbLight01;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblLamp04UI;
        private System.Windows.Forms.Label lblLamp01UI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblLamp02UI;
        private System.Windows.Forms.Label lblLamp03UI;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblPauseIOPage;
        private System.Windows.Forms.Label lblStopIOPage;
        private System.Windows.Forms.Label lblStartIOPage;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

