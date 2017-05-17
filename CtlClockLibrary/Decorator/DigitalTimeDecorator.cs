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
            float emSize = size.Width / 6; //6=подобрано, чтобы все символы помещались
            graphTime.DrawString(this.Time.ToString("hh':'mm':'ss"), new Font(new FontFamily("Times New Roman"),emSize), new SolidBrush(Color.Blue), 0, 0);
            
        }
    }
}
