using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WatchPatterns
{
    class DigitalTimeDecorator : TimeDecorator
    {
        public override void Draw(Size size,Graphics graphTime)
        {
            graphTime.DrawString(this.watch.Time.ToString("hh':'mm':'ss"), new Font(new FontFamily("Times New Roman"),size.Width/5), new SolidBrush(Color.Blue), 0, 0);
        }
    }
}
