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
        private TimeSpan time;
        private TimeSpan timeOffset;

        public  WatchComponent()
        {
            timeOffset = new TimeSpan(0, 0, 0);
        }

        public TimeSpan Time
        {
            get
            {
                return DateTime.Now.TimeOfDay.Add(timeOffset);
            }

            set
            {
                time = DateTime.Now.TimeOfDay.Add(value);
                timeOffset = value;

            }
        }

       
        public abstract void Draw(Graphics graphTime);
    }
}
