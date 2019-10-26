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
        int[] hLamp = new int[4];
        AdsStream adsStream;
        BinaryReader binReader;
        int tmp = 0;
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
            adsStream = new AdsStream(4);
            binReader = new BinaryReader(adsStream, ASCIIEncoding.ASCII);
            

            hLamp[0] = client.AddDeviceNotification("GVL_Machine.HWIO.HWOutput.Lamp01", adsStream, AdsTransMode.OnChange, 100, 0, lbLight00);
            hLamp[1] = client.AddDeviceNotification("GVL_Machine.HWIO.HWOutput.Lamp02", adsStream, AdsTransMode.OnChange, 100, 0, lbLight01);
            hLamp[2] = client.AddDeviceNotification("GVL_Machine.HWIO.HWOutput.Lamp03", adsStream, AdsTransMode.OnChange, 100, 0, lbLight02);
            hLamp[3] = client.AddDeviceNotification("GVL_Machine.HWIO.HWOutput.Lamp04", adsStream, AdsTransMode.OnChange, 100, 0, lbLight03);
            client.AdsNotification += Lamp_AdsNotification;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //CheckForIllegalCrossThreadCalls = false;
            client = new TcAdsClient();
            client.Connect(851);

            ControlInit();

            //------connect to PLC----------------------------            
            ReadLamp();
            //------connect to PLC----------------------------
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
    }
}
