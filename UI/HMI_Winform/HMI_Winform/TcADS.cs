using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinCAT.Ads;

namespace HMI_Winform
{    
   public class TcADS
    {
        public void ConnectPLC()
        {
            TcAdsClient client = new TcAdsClient();
            try
            {
                client.Connect(851);
            }
            catch (Exception err)
            {
                MessageBox.Show("try to connect to PLC ADS failed" + Environment.NewLine, "fatal error" + err.Message, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);             
            }
        }
        public void CreateHandle()
        {

        }



    }
}
