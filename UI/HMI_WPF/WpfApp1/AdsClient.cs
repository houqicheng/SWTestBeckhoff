using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TwinCAT.Ads;

namespace WpfApp1
{
    class AdsClient
    {
        TcAdsClient _client = null;
        public void ConnentClient()
        {
            try
            {
               // _client = new TcAdsClient();
                _client.Connect(851);
            }
            catch (Exception err)
            {
                MessageBox.Show("connect ADS client error" + err.Message);
            }
        }
        public AdsClient(TcAdsClient client)
        {
            this._client = client;
            this.ConnentClient();
        }
        public void WriteModetoPLC(string variableName, string mode)
        {
            try
            {
                int handle = _client.CreateVariableHandle(variableName);
                _client.WriteAny(handle, mode, new int[] { 80 });
            }
            catch (Exception err)
            {
                MessageBox.Show("Write machine mode error" + err.Message);
               // throw;
            }
            
        }
        
    }
}
