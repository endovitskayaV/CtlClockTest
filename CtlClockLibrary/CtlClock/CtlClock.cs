﻿using System;
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
        public enum ClockMode { Analog, Digital };
        private ClockMode mode = ClockMode.Analog;
        private WatchPatterns.TimeDecorator clock;
        private WatchPatterns.Watch watch;
        private Graphics graphics;
        private System.Timers.Timer timer;
        private bool drawing = false;

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
            Draw();
            base.OnPaint(cl);
        }

        private void Draw()
        {
            if (!drawing)
            {
                drawing = true;
                if (mode.Equals(ClockMode.Analog)) clock = new WatchPatterns.AnologTimeDecorator();
                else clock = new WatchPatterns.DigitalTimeDecorator();
                clock.SetWatch(watch);
                graphics.Clear(Color.White);
                clock.Draw(graphics);
                drawing = false;
            }
        }

    }
}
