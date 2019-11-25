using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TwinCAT.Ads;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Tab_SwitchMode.xaml
    /// </summary>
    public partial class Tab_SwitchMode : UserControl
    {
        public Tab_SwitchMode()
        {
            InitializeComponent();
        }
        TcAdsClient client = new TcAdsClient();
        AdsClient tcClient = null;
        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            // I try to use this method to hand all four buttons'(Auto,manual,calib and setting) click event.
            Button btn = (Button)e.OriginalSource;
            string btnSwitchModeStr = btn.Name;
            if (btnSwitchModeStr.Contains("Auto"))
            {
                tcClient.WriteModetoPLC("GVL_Machine.ModeUI", "Auto");
            }
            else if (btnSwitchModeStr.Contains("Manual"))
            {
                tcClient.WriteModetoPLC("GVL_Machine.ModeUI", "Manual");
            }
            else if (btnSwitchModeStr.Contains("Calib"))
            {
                tcClient.WriteModetoPLC("GVL_Machine.ModeUI", "Calibration");
            }
            else if (btnSwitchModeStr.Contains("Setting"))
            {
                tcClient.WriteModetoPLC("GVL_Machine.ModeUI", "Setting");
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            tcClient = new AdsClient(client);
        }
    }
}
