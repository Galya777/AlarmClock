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
namespace ClockLib
{
    
    public partial class DigitalClock : UserControl
    {
        EventHandler ClockStarted;
        EventHandler TimeUpdated;
        DispatcherTimer timer;
        public DigitalClock()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            this.timer.Tick += new EventHandler(this.OnTimed);
            this.timer.Interval = new TimeSpan(0, 0, 1);
            this.timer.Start();
        }
        private void OnTimed(object source, EventArgs args)
        {
            DateTime now = DateTime.Now;
            int hours = now.Hour;
            int minutes = now.Minute;
            int seconds = now.Second;
            ClockTickArgs clockTick=new ClockTickArgs(hours, minutes, seconds);
           
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void stop_Click_1(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            clock.Text="00:00:00";
        }
    }
}
