using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace WatchPatterns
{
    class AnologTimeDecorator : TimeDecorator
    {
        public override void Draw(Size size,Graphics graphTime)
        {
            int max;
            if (size.Height > size.Width)
                max = size.Height;
            else max = size.Width;

            if (size.Height.Equals(size.Width)) max = size.Height;// любое вообще
            Size pictureSize = new Size(max, max);

            //получить  сборку, которая сожержит выполняемый в данный момент код
            //загрузить указанный ресурс из сборки
            //создать bitmap из этого потока данных
            Bitmap bitmap = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("CtlClockLibrary.clock.jpg"));
            graphTime.DrawImage(bitmap, 0, 0, pictureSize.Width, pictureSize.Height);
            bitmap = new Bitmap(pictureSize.Width, pictureSize.Height);
            Graphics grBuffer = Graphics.FromImage(bitmap);
            float center = pictureSize.Height / 2;
          
           double length= (pictureSize.Width / 2)*0.9;
            grBuffer.DrawLine(new Pen(Brushes.Black, 1), center, center, (float)(length* Math.Sin(this.Time.Seconds * 6 * (Math.PI / 180)) + center), (float)(length * Math.Cos(this.Time.Seconds * 6 * (Math.PI / 180)) * (-1) + center));
            length = (pictureSize.Width / 2) * 0.85;
            grBuffer.DrawLine(new Pen(Brushes.Black, 2),center, center, (float)(length * Math.Sin((this.Time.Minutes+ this.Time.Seconds / 60.0 )* 6* (Math.PI / 180)) +center), (float)(60 * Math.Cos((this.Time.Minutes +this.Time.Seconds/60.0)* 6 * (Math.PI / 180)) * (-1) + center));
            double h = (this.Time.Hours);
            if (h > 12)  h -= 12;
            h = (h+ this.Time.Minutes / 60.0)*30*(Math.PI / 180);
            length = (pictureSize.Width / 2) * 0.55;
            grBuffer.DrawLine(new Pen(Brushes.Black, 3), center, center, (float)(length * Math.Sin(h) +center), (float)(35* Math.Cos(h)*(-1)  + center));
            graphTime.DrawImage(bitmap, 0, 0);
            grBuffer.Dispose();
        }
    }
}
