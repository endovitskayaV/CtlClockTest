using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtlClockLibrary
{
    public partial class CtlClock: UserControl
    {
        private enum ClockMode { Analog, Digital };
        //private ClockMode mode = ClockMode.Digital;
        private WatchPatterns.TimeDecorator clock;
        private WatchPatterns.Watch watch;
        private Graphics graphics;
        private System.Timers.Timer timer;
        private bool drawing = false;


        public CtlClock()
        {
            InitializeComponent();

            watch = new WatchPatterns.Watch();
            clock = new WatchPatterns.DigitalTimeDecorator();
            clock.SetWatch(watch);
            graphics = pictureBox.CreateGraphics();
           // changeModeBtn.Text = "Analog"; // изменить гдн-то это

            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
            timer.Enabled = true;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Draw();
        }


        protected override void OnPaint(PaintEventArgs cl)
        {
            // в конце блока using для pen будет вызван Dispose
            /*using (Pen pen = new Pen(Color.Black))
            {
                pe.Graphics.DrawLine(pen, 0, 0, Width - 1, Height - 1);
                pe.Graphics.DrawLine(pen, Width - 1, 0, 0, Height - 1);
            }*/


            // cl.Graphics.DrawString(DateTime.Now.ToString("hh':'mm':'ss"), new Font(new FontFamily("Times New Roman"), 30), new SolidBrush(Color.Blue), 0, 50);
            Draw();
            base.OnPaint(cl);
        }

        private void Draw()
        {
            if (!drawing)
            {
                drawing = true;
                clock.SetWatch(watch);
                graphics.Clear(Color.White);
                clock.Draw(dateLbl, graphics);
                drawing = false;
            }
        }

    }
}
