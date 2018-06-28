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
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer Timer = new System.Windows.Threading.DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            Timer.Tick += new EventHandler(Timer_Click);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();

        }

        //private void time_Loaded(object sender, RoutedEventArgs e)
        
            //System.DateTime currentTime = new System.DateTime();
        

        private void add_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UserControl1 userControl = new UserControl1();
            list.Children.Add(userControl);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            List<string> datas = new List<string>();
            foreach (UserControl1 item in list.Children)
            {
                string uuu = "";
                uuu += "|" + item.bbb + "|" + item.name;
                datas.Add(uuu);

            }
        }

        private void Timer_Click(object sender, EventArgs e)
        {
            DateTime d;
            d = DateTime.Now;
            time.Content = "現在時間:"+d.Hour + ";" + d.Minute + ";" + d.Second; 
        }
    }
}

    


