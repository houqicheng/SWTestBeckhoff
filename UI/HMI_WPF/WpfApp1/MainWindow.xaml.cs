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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Tab_Main tabMain = new Tab_Main();
            contentControl01.Content = tabMain;
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            Tab_Main tabMain = new Tab_Main();
            contentControl01.Content = tabMain;
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            // I try to use this method to hand all four buttons'(Auto,manual,calib and setting) click event.
            Button btn = (Button)e.OriginalSource;
            string btnSwitchStr = btn.Name;
            if (btnSwitchStr.Contains("Auto"))
            {

            }
        }
    }
}
