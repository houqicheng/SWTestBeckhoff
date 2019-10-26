using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinCAT.Ads;
using System.IO;


namespace HMI_Winform
{    
   public class TcADS
    {

    //    // this class is not in use now.
       
    //    private int[] hLampConnect;
    //    private TcAdsClient _client;
    //     AdsStream streamLamp = new AdsStream(4);
         

             
        


    //    public void ConnectPLC()
    //    {
    //        _client = new TcAdsClient();
    //        try
    //        {
    //            _client.Connect(851);
    //        }
    //        catch (Exception err)
    //        {
    //            MessageBox.Show("try to connect to PLC ADS failed" + Environment.NewLine, "fatal error" + err.Message, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);             
    //        }
    //    }

    //    public void LampAddNotification()
    //    {
    //        hLampConnect = new int[8];
    //        streamLamp = new AdsStream(4);
    //        //-----------------plc---------------
    //        hLampConnect[0] = _client.AddDeviceNotification("GVL_Machine.HWIO.HWOutput.Lamp01", streamLamp, AdsTransMode.OnChange, 100, 0, null);

    //        _client.AdsNotification += _client_AdsNotification;

    //    }

    //    private void _client_AdsNotification(object sender, AdsNotificationEventArgs e)
    //    {
    //        //string str;
    //        //throw new NotImplementedException();
    //        if (e.NotificationHandle == hLampConnect[0])
    //        {
                  
    //        }
    //    }

    //    public TcADS(TcAdsClient client)
    //    {
    //        _client = client;            
    //}

    }
}
