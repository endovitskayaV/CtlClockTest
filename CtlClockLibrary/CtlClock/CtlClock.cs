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
        private WatchPatterns.TimeDecorator clock;
        private WatchPatterns.Watch watch;
        private Graphics graphics;
        private System.Timers.Timer timer;
        private bool isDrawing = false;

        public enum ClockMode {Digital,Analog};
        private ClockMode mode;
        private int timeOffset;
        private bool stopped;
        private Color bgColor;

        [Category("Внешний вид")]
        [Description("Тип представления часов")]
        [DefaultValue(ClockMode.Digital)]
        public ClockMode Mode
        {
            get
            {
                return mode;
            }
            set
            {
                mode = value;
                // вызов метода обновления формы
                // приведет к вызову метода перерисовки OnPaint;
                // вызывать OnPaint напрямую неправильно !!!
                Invalidate();
            }
        }

        [Category("Поведение")]
        [Description("Смещение для отображаемого времени относительно системного")]
        [DefaultValue(3)]
        public int TimeOffset
        {
            get
            {
                return timeOffset;
            }
            set
            {
                timeOffset = value;
                watch.Time = new TimeSpan(value, 0, 0);
                Invalidate();
            }
        }
        [Category("Поведение")]
        [Description("Остановлен ли элемент")]
        [DefaultValue(false)]
        public bool Stopped
        {
            get
            {
                return stopped;
            }
            set
            {
               stopped = value;
               isDrawing = value;
                if (value) timer.Stop(); else timer.Start();
            }
        }


       // private const Color color = Color.Yellow;
        [Category("Внешний вид")]
        [Description("Фоновый цвет компонента")]
        //[DefaultValue (color)]

        public new Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                bgColor = value;
            }
        }

        public CtlClock()
        {
            InitializeComponent();

            watch = new WatchPatterns.Watch();
            clock = new WatchPatterns.DigitalTimeDecorator();
            clock.SetWatch(watch);
            graphics = pictureBox.CreateGraphics();

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

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //пустой, чтобы вся логика была в OnPaint, чтобы не было мерцания
        }

        protected override void OnPaint(PaintEventArgs cl)
        {
            Draw ();
           // base.OnPaint(cl);
        }

        private void Draw()
        {
            if (!isDrawing) // if isDrawing==false // если не рисуется, то можно рисовать
            {
                isDrawing = true;
                if (mode.Equals(ClockMode.Analog)) clock = new WatchPatterns.AnologTimeDecorator();
                else clock = new WatchPatterns.DigitalTimeDecorator();
                clock.SetWatch(watch);
                graphics.Clear(bgColor);
                clock.Draw(graphics);
                isDrawing = false;
            }
            if (stopped)
            {
                if (mode.Equals(ClockMode.Analog)) clock = new WatchPatterns.AnologTimeDecorator();
                else clock = new WatchPatterns.DigitalTimeDecorator();
                clock.SetWatch(watch);
                graphics.Clear(bgColor);
                clock.Draw(graphics);
            }
        }

        

    }
}
