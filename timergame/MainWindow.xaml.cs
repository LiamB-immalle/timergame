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
using System.Windows.Threading;

namespace timergame
{

    public partial class MainWindow : Window
    {
        private DispatcherTimer spawntimer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();

            spawntimer.Interval = TimeSpan.FromMilliseconds(200);
            //spawntimer.Tick += Spawntimer_Tick;
        }
        

        private void Spawntimer_tick()
        {
            vuller.Height = +10;
            vuller.Width = +10;
            
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            spawntimer.Start();
        }

        private void tinier_Click(object sender, RoutedEventArgs e)
        {
            vuller.Height = -5;
            vuller.Width = -5;
        }
    }
}
