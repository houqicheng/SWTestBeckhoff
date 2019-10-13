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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Logger.SetLogEnable(true);
        }        
        public TcAdsClient client;
        int hStart;
        int hPause;
        int hStop;
        private void Form1_Load(object sender, EventArgs e)
        {            
            CheckForIllegalCrossThreadCalls = false;

            client = new TcAdsClient();
            client.Connect(851);

            hStart = client.CreateVariableHandle("GVL_General.bStartBtn");
            hPause = client.CreateVariableHandle("GVL_General.bPauseBtn");
            hStop = client.CreateVariableHandle("GVL_General.bStopBtn");
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            Logger.WriteLog("Main Form Loaded");
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            Logger.WriteLog("Start button pressed");

            btnStop.Enabled = true;
            btnPause.Enabled = true;
            try
            {
                client.WriteAny(hStart, true);
                client.WriteAny(hPause, false);
                client.WriteAny(hStop, false);
                Logger.WriteLog("Write bstart=true,bPause=false,bStop=false to PLC");
            }
            catch (Exception ex)
            {
                Logger.WriteLog("Error: press be Start button exception");
                Logger.WriteLog("Error:" + ex.Message);
                MessageBox.Show("btnStart: " + ex.Message);
            }            
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            Logger.WriteLog("Pause button pressed");
            try
            {
                client.WriteAny(hPause, true);
                Logger.WriteLog("Send pause value =(true)  to plc");
            }
            catch (Exception ex)
            {
                Logger.WriteLog("Error: press Pause button exception");
                Logger.WriteLog("Error:" + ex.Message);
                MessageBox.Show("btnPause: " + ex.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Logger.WriteLog("Stop button pressed");
            try
            {
                client.WriteAny(hStop, true);
            }
            catch (Exception ex)
            {
                Logger.WriteLog("Error: press Stop button exception");
                Logger.WriteLog("Error:" + ex.Message);
                MessageBox.Show("btnStop: " + ex.Message);
            }
        }
        private void btnIO_Click(object sender, EventArgs e)
        {
            Logger.WriteLog("Open IO Page");

            IOPage io = new IOPage();
            io.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Logger.WriteLog("Open history page!");
            HistoryPage historyPage = new HistoryPage();
            historyPage.ShowDialog();
        }
    }
}
