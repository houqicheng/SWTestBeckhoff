using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using TwinCAT.Ads;
using System.Threading;

namespace HMI_Winform
{
    public partial class MainWindow : Form
    {
        TcAdsClient client;
        //----------try to read Lamp status to UI------------
        int[] hLamp = new int[4];
        AdsStream adsStreamLamp;
        BinaryReader binReader;
        //----------try to read Lamp status to UI------------

        //-------------mode--------------------
        //write mode to PLC------------
        int hModeUI = 0;
        AdsStream modeStream;
        AdsBinaryWriter adsWriter;
        string strMode = "Idle";

        //read PLC mode from PLC--------------
        int hModePLC=0;

        //-------------------------------------
        //---------ui variable handle-----------
        int hStartUI;
        int hPauseUI;
        int hStopUI;
        //---------ui variable handle-----------

        public MainWindow()
        {
            InitializeComponent();
        }
        private void ControlInit()
        {
            lblHome.BackColor = Color.Empty;
            lblIO.BackColor = Color.Empty;
            lblLog.BackColor = Color.Empty;
            lblPause.BackColor = Color.Empty;
            lblSetting.BackColor = Color.Empty;
            lblStart.BackColor = Color.Empty;
            lblStop.BackColor = Color.Empty;
        }
        public void ReadLamp()
        {
            adsStreamLamp = new AdsStream(4);
            binReader = new BinaryReader(adsStreamLamp, ASCIIEncoding.ASCII);
            try
            {
                hLamp[0] = client.AddDeviceNotification("GVL_Machine.HWIO.HWOutput.Lamp01", adsStreamLamp, AdsTransMode.OnChange, 100, 0, lbLight00);
                hLamp[1] = client.AddDeviceNotification("GVL_Machine.HWIO.HWOutput.Lamp02", adsStreamLamp, AdsTransMode.OnChange, 100, 0, lbLight01);
                hLamp[2] = client.AddDeviceNotification("GVL_Machine.HWIO.HWOutput.Lamp03", adsStreamLamp, AdsTransMode.OnChange, 100, 0, lbLight02);
                hLamp[3] = client.AddDeviceNotification("GVL_Machine.HWIO.HWOutput.Lamp04", adsStreamLamp, AdsTransMode.OnChange, 100, 0, lbLight03);
            }
            catch (Exception err)
            {
                MessageBox.Show("Exception: ReadLamp: " + err.Message);                
            }           
            client.AdsNotification += Lamp_AdsNotification;
        }
        public void ReadModeStr()
        {
           hModePLC =  client.AddDeviceNotificationEx("GVL_Machine.ModePLC", AdsTransMode.OnChange, 100, 0,lbMode,typeof(string),new int[] {15});
            client.AdsNotificationEx += Client_AdsNotificationEx;
        }

        private void Client_AdsNotificationEx(object sender, AdsNotificationExEventArgs e)
        {
            //throw new NotImplementedException();
            lbMode.Text = e.Value.ToString();
        }

      

        private void MainWindow_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            //------connect to PLC---------------------------- 
            client = new TcAdsClient();
            client.Connect(851);
            //------connect to PLC---------------------------- 

            //------label and button background initilize---------------------------- 
            ControlInit();             

            //------Read lamp status to HMI Main page---------------------------- 
            ReadLamp();

            //-------------mode select------------------            
            hModeUI = client.CreateVariableHandle("GVL_Machine.ModeUI");

            ReadModeStr();


            hStartUI = client.CreateVariableHandle("GVL_General.bStartBtnUI");
            hPauseUI = client.CreateVariableHandle("GVL_General.bPauseBtnUI");
            hStopUI = client.CreateVariableHandle("GVL_General.bStopBtnUI");
        }
        private void Lamp_AdsNotification(object sender, AdsNotificationEventArgs e)
        {
            e.DataStream.Position = e.Offset;
            string str = "";
           int temp = int.Parse(((Label)e.UserData).Name.ToString()[8].ToString());

            if (e.NotificationHandle == hLamp[temp])
            {
                str = binReader.ReadBoolean().ToString();
                if (str.ToLower() == "true")
                {
                    ((Label)e.UserData).ImageIndex = 1;
                    //((Label)e.UserData).Text = "true";
                }
                else
                {
                    ((Label)e.UserData).ImageIndex = 0;
                    //((Label)e.UserData).Text = "false";
                }
            }

            //below is the traditionaly way to get the Plc value

            //if (e.NotificationHandle == hLamp[0])
            //{
            //    str = binReader.ReadBoolean().ToString();
            //    if (str.ToLower() == "true")
            //    {
            //        //((Label)e.UserData).ImageIndex = 1;
            //        lbLight01.ImageIndex = 1;
            //    }
            //    else
            //    {
            //        lbLight01.ImageIndex = 0;
            //    }
            //}
            //else if (e.NotificationHandle == hLamp[1])
            //{
            //    str = binReader.ReadBoolean().ToString();
            //    if (str.ToLower() == "true")
            //    {
            //        lbLight02.ImageIndex = 1;
            //    }
            //    else
            //    {
            //        lbLight02.ImageIndex = 0;
            //    }
            //}
            //else if (e.NotificationHandle == hLamp[2])
            //{
            //    str = binReader.ReadBoolean().ToString();
            //    if (str.ToLower() == "true")
            //    {
            //        lbLight03.ImageIndex = 1;
            //    }
            //    else
            //    {
            //        lbLight03.ImageIndex = 0;
            //    }
            //}
            //else
            //{
            //    str = binReader.ReadBoolean().ToString();
            //    if (str.ToLower() == "true")
            //    {
            //        lbLight04.ImageIndex = 1;
            //    }
            //    else
            //    {
            //        lbLight04.ImageIndex = 0;
            //    }
            //}
        }


        private void lblHome_Click(object sender, EventArgs e)
        {

            lblHome.BackColor = Color.Green;
            lblIO.BackColor = Color.Empty;
            lblLog.BackColor = Color.Empty;
            tabControl1.SelectedIndex = 0;
        }

        private void lblIO_Click(object sender, EventArgs e)
        {
            lblIO.BackColor = Color.Green;
            lblLog.BackColor = Color.Empty;
            lblHome.BackColor = Color.Empty;
           
            tabControl1.SelectedIndex = 1;
        }

        private void lblLog_Click(object sender, EventArgs e)
        {
            lblLog.BackColor = Color.Green;
            lblHome.BackColor = Color.Empty;
            lblIO.BackColor = Color.Empty;
            tabControl1.SelectedIndex = 2;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                for (int i = 0; i < hLamp.Length; i++)
                {
                    client.DeleteDeviceNotification(hLamp[i]);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: deleteDeviceNotification: " + err.Message);
            }
            client.Dispose();
        }

        private void btnAutoMode_Click(object sender, EventArgs e)
        {
            try
            {
                //lenght of the stream = length of string + 1
                //1,先有adsstream,
                //2,再有binarywriter.write
                //3,再有clien.write()
                //---------把字符串分解成char 在写入plc -------               
                //modeWrite = new BinaryWriter(modeStream);               
                //modeWrite.Write(strMode.ToCharArray());
                //client.Write(hModeUI, modeStream);
                //---------把字符串分解成char 在写入plc


                //From version 1.0.0.10 and higher the classes AdsBinaryReader and AdsBinaryWriter
                // can be used to read and write strings
                //---------用字符串的方式写入--------------- 
                strMode = "Auto";
                modeStream = new AdsStream(30);
                adsWriter = new AdsBinaryWriter(modeStream);
                adsWriter.WritePlcString(strMode, 30, Encoding.ASCII);
                client.Write(hModeUI, modeStream);
                //-----------可以使用的------------
                //---------用字符串的方式写入---------------
            }
            catch (Exception err)
            {
                MessageBox.Show("set Auto to PLC: " + err.Message);
            }
            btnAutoMode.BackColor = Color.Green;
            btnCalibMode.BackColor = Color.Empty;
            btnManualMode.BackColor = Color.Empty;
            btnSettingMode.BackColor = Color.Empty;
        }

        private void btnManualMode_Click(object sender, EventArgs e)
        {
            strMode = "Manual";
            modeStream = new AdsStream(30);
            adsWriter = new AdsBinaryWriter(modeStream);
            try
            {
                adsWriter.WritePlcString(strMode, 30,Encoding.ASCII);
                client.Write(hModeUI, modeStream);
            }
            catch (Exception err)
            {
                MessageBox.Show("try to write Manual mode to PLC: " + err.Message);
            }
            btnAutoMode.BackColor = Color.Empty;
            btnCalibMode.BackColor = Color.Empty;
            btnManualMode.BackColor = Color.Green;
            btnSettingMode.BackColor = Color.Empty;
        }

        private void btnSettingMode_Click(object sender, EventArgs e)
        {
            strMode = "Setting";  
            modeStream = new AdsStream(30);
            adsWriter = new AdsBinaryWriter(modeStream);
            try
            { 
                adsWriter.WritePlcString(strMode, 30, Encoding.ASCII);
                client.Write(hModeUI, modeStream);
            }
            catch (Exception err)
            {
                MessageBox.Show("try to write setting Mode to PLC: " + err.Message);   
            }
            btnAutoMode.BackColor = Color.Empty;
            btnCalibMode.BackColor = Color.Empty;
            btnManualMode.BackColor = Color.Empty;
            btnSettingMode.BackColor = Color.Green;
        }

        private void btnCalibMode_Click(object sender, EventArgs e)
        {
            modeStream = new AdsStream(30);
            adsWriter = new AdsBinaryWriter(modeStream);
            strMode = "Calibration";
            try
            {
                adsWriter.WritePlcAnsiString(strMode, 30);
                client.Write(hModeUI, modeStream);
            }
            catch (Exception err)
            {
                MessageBox.Show("Try to write Calibration to PLC: " + err.Message);
            }
            btnAutoMode.BackColor = Color.Empty;
            btnCalibMode.BackColor = Color.Green;
            btnManualMode.BackColor = Color.Empty;
            btnSettingMode.BackColor = Color.Empty;
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            //
            AdsStream btnStream = new AdsStream(1);
            AdsBinaryWriter btnWriter = new AdsBinaryWriter(btnStream);
            try
            {
                btnWriter.Write(true);
                client.Write(hStartUI, btnStream);

                //------adsClient的WriteAny方法
                client.WriteAny(hPauseUI, false);
                client.WriteAny(hStopUI, false);
                //------adsClient的WriteAny方法
                Thread.Sleep(100);
                client.WriteAny(hStartUI, false);
               
            }
            catch (Exception err)
            {
                MessageBox.Show("write start value to PLC: " + err.Message);
            }
            lblPause.BackColor = Color.Empty;
            lblStart.BackColor = Color.Green;
            lblStop.BackColor = Color.Empty;
        }

        private void lblPause_Click(object sender, EventArgs e)
        {
            //using writeany
            try
            {
                client.WriteAny(hPauseUI, true);
            }
            catch (Exception err)
            {
                MessageBox.Show("try to write pause to PLC: " + err.Message);                
            }
            lblPause.BackColor = Color.Green;
            lblStart.BackColor = Color.Empty;
            lblStop.BackColor = Color.Empty;
        }

        private void lblStop_Click(object sender, EventArgs e)
        {
            lblPause.BackColor = Color.Empty;
            lblStart.BackColor = Color.Empty;
            lblStop.BackColor = Color.Green;
            // 用sample03, adsbinaryWriter and adsstream 方法
            AdsStream stopStream = new AdsStream(1);
            AdsBinaryWriter stopWriter = new AdsBinaryWriter(stopStream);
            try
            {
                stopWriter.Write(true);
                client.Write(hStopUI, stopStream);
                client.WriteAny(hPauseUI, false);               

            }
            catch (Exception err)
            {
                MessageBox.Show("write stop to PLC: " + err.Message);
            }
        }

        private void lblLamp01UI_Click(object sender, EventArgs e)
        {
            //use mouse down/up to write to PLC Lamp
        }

        private void lblLamp01UI_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
