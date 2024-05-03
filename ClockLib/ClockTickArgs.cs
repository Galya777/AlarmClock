using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Threading;

namespace ClockLib
{
    public class ClockTickArgs
    {
        public delegate void ClockTick(int hour, int minute, int second);

        private ClockTick clockTick;
        

       public ClockTickArgs(int hour, int minute, int second)
        {
            this.clockTick?.Invoke(hour, minute, second);
        }
        public void Add(ClockTick clockTick)
        {
            this.clockTick += clockTick;
        }
        
    }
}
