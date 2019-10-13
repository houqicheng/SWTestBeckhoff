using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_WindowForm
{
    public partial class HistoryPage : Form
    {
        public HistoryPage()
        {
            InitializeComponent();
        }

        private void HistoryPage_Load(object sender, EventArgs e)
        {
            Logger.WriteLog("Try to load all log to history page");
            try
            {
                richTextBox1.Text = Logger.ReadLog();
            }
            catch (Exception err)
            {

                MessageBox.Show("load history page: " + err.Message);
            }
           
        }
    }
}
