using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinCAT.Ads;
namespace UI_WindowForm
{
    public partial class IOPage : Form
    {
        TcAdsClient ioClient;

        public IOPage()
        {
            InitializeComponent();
        }

        private void IOPage_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            ioClient = new TcAdsClient();

            try
            {
                ioClient.Connect(851);
            }
            catch (Exception err)
            {
                MessageBox.Show("IO page: client to PLC: " + err.Message);
            }  
            
            try
            {                
               ioClient.AddDeviceNotificationEx("GVL_General.bLamp01", AdsTransMode.OnChange, 100, 0, ioBtnLamp01, typeof(Boolean));
               ioClient.AddDeviceNotificationEx("GVL_General.bLamp02", AdsTransMode.OnChange, 100, 0, ioBtnLamp02, typeof(Boolean));
               ioClient.AddDeviceNotificationEx("GVL_General.bLamp03", AdsTransMode.OnChange, 100, 0, ioBtnLamp03, typeof(Boolean));
               ioClient.AddDeviceNotificationEx("GVL_General.bLamp04", AdsTransMode.OnChange, 100, 0, ioBtnLamp04, typeof(Boolean));

               ioClient.AdsNotificationEx += Client_AdsNotificationEx;               
            }
            catch (Exception)
            {
                // throw;
                MessageBox.Show("add device notification");
            } 
        }
        private void Client_AdsNotificationEx(object sender, AdsNotificationExEventArgs e)
        {
            //throw new NotImplementedException();
            Button btn = (Button)e.UserData;

            if ((bool)e.Value)
            {
                btn.BackColor = Color.Green;
            }
            else
            {
                btn.BackColor = Color.Red;
            }            
        }        
    } 
}
