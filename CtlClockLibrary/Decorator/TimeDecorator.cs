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
        public WatchComponent watch; //это. я сделала тольо потому что по схеме так. покажи схему

        public new TimeSpan Time
        {
            get { return watch.Time;  }
        }


        public void SetWatch(WatchComponent w) 
        {
            this.watch = w;
        }

        public override void Draw(Size size, Graphics graphTime)
        {
            if (this.watch != null)
                watch.Draw(size,graphTime);
        }
    }
}
