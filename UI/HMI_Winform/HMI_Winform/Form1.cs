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

namespace HMI_Winform
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            lblHome.BackColor = Color.Empty;
            lblIO.BackColor = Color.Empty;
            lblLog.BackColor = Color.Empty;
            lblPause.BackColor = Color.Empty;
            lblSetting.BackColor = Color.Empty;
            lblStart.BackColor = Color.Empty;
            lblStop.BackColor = Color.Empty;
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
