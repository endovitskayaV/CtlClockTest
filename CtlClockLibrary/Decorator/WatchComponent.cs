using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchPatterns
{
    public abstract class WatchComponent
    {
        private int timeOffset;

        public  WatchComponent(int timeOffset)
        {
            this.timeOffset = timeOffset;
        }

        public WatchComponent()
        {
            this.timeOffset = 0;
        }

        public TimeSpan Time
        {
            get
            {
                return DateTime.Now.TimeOfDay.Add(new TimeSpan (timeOffset,0,0)); 
            }
        }

        public int TimeOffset
        {
            get
            {
                return timeOffset;
            }
            set
            {
                timeOffset = value;
            }
        }

        public abstract void Draw(Size size,Graphics graphTime);
    }
}
