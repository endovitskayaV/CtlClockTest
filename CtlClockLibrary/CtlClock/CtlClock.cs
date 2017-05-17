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
    public partial class CtlClock: PictureBox
    {
        public enum ClockMode {Analog, Digital};
        private WatchPatterns.TimeDecorator watchDecorator;
        private WatchPatterns.Watch watch;
        private System.Timers.Timer timer;
        private bool isDrawing = false;       
        private ClockMode mode;
        private int timeOffset;

        [Category("Внешний вид")]
        [Description("Тип представления часов")]
        [DefaultValue(ClockMode.Analog)]
        public ClockMode Mode
        {
            get
            {
                return mode;
            }
            set
            {
                mode = value;
                Invalidate(); // приведет к вызову метода перерисовки OnPaint;
            }
        }

        [Category("Поведение")]
        [Description("Смещение для отображаемого времени относительно системного")]
        [DefaultValue(0)]
        public int TimeOffset
        {
            get
            {
                return timeOffset;
            }
            set
            {
                timeOffset = value; 
                watch.TimeOffset = timeOffset;
                Invalidate();
            }
        }
      
        public CtlClock()
        {
            InitializeComponent();

            mode = ClockMode.Analog;
            timeOffset = 0;
            
            watch = new WatchPatterns.Watch(timeOffset);
            watchDecorator = new WatchPatterns.DigitalTimeDecorator();  
            watchDecorator.SetWatch(watch);

            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
            timer.Enabled = true;
            timer.Start();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Invalidate();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Draw (e.Graphics);
            base.OnPaint(e);
        }

        private void Draw(Graphics graphics)
        {
            if (!isDrawing) // if isDrawing==false // если не рисуется, то можно рисовать
            {
                isDrawing = true;

                if (mode.Equals(ClockMode.Analog))
                    watchDecorator = new WatchPatterns.AnologTimeDecorator();
                else watchDecorator = new WatchPatterns.DigitalTimeDecorator();

                watchDecorator.SetWatch(watch);
                graphics.Clear(Color.White);
                watchDecorator.Draw(this.Size,graphics);

                isDrawing = false;
            }
        }
    }
}
