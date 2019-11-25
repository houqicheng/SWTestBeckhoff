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
        //TcAdsClient client = new TcAdsClient();
        //AdsClient tcClient = null;
        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            Tab_Main tabMain = new Tab_Main();
            contentControl01.Content = tabMain;
        }
        //private void StackPanel_Click(object sender, RoutedEventArgs e)
        //{

        //}
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
