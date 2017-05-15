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
        public TimeSpan Time
        {
            get
            {
                return DateTime.Now.TimeOfDay;
            }
        }

        public DateTime Date
        {
            get
            {
                return DateTime.Today;
            }
        }

        public abstract void Draw(Label lb, Graphics graphTime);
    }
}
