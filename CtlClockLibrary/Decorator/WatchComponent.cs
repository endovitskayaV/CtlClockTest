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

       /* public DateTime Date
        {
            get
            {
                return DateTime.Today;
            }
        }
        */
        public abstract void Draw(Graphics graphTime);
    }
}
