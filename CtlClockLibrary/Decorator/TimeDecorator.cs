using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;

namespace WatchPatterns
{
    public abstract class TimeDecorator : WatchComponent
    {
        protected WatchComponent watch;

        public void SetWatch(WatchComponent w)
        {
            this.watch = w;
        }

        public override void Draw(Label lbDate, Graphics graphTime)
        {
            if (this.watch != null)
                watch.Draw(lbDate, graphTime);
        }
    }
}
