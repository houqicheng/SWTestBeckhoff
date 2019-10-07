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
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            btnPause.Enabled = true;
            try
            {
                client.WriteAny(hStart, true);
                client.WriteAny(hPause, false);
                client.WriteAny(hStop, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnStart: " + ex.Message);
            }            
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            try
            {
                client.WriteAny(hPause, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnPause: " + ex.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                client.WriteAny(hStop, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("btnStop: " + ex.Message);
            }
        }
        private void btnIO_Click(object sender, EventArgs e)
        {
            IOPage io = new IOPage();
            io.Show();
        }
    }
}
