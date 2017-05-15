using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchPatterns
{
    public partial class ClockForm : Form
    {
        private enum ClockMode { Analog, Digital };
        private ClockMode mode = ClockMode.Digital;
        private TimeDecorator clock;
        private Watch watch;
        private Graphics graphics;
        private System.Timers.Timer timer;
        private bool drawing = false;


        public ClockForm()
        {
            InitializeComponent();
            watch = new Watch();
            clock = new DigitalTimeDecorator();
            clock.SetWatch(watch);
            graphics = pictureBox.CreateGraphics();
            changeModeBtn.Text = "Analog";

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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Draw();       
        }

        private void changeModeBtn_Click(object sender, EventArgs e)
        {
            if (mode == ClockMode.Digital) //to analog mode
            {
                clock = new AnologTimeDecorator();
                mode = ClockMode.Analog;
                changeModeBtn.Text = "Digital";
            }
            else // to digital mode
            {
                clock = new DigitalTimeDecorator();
                mode = ClockMode.Digital;
                changeModeBtn.Text = "Analog";
            }
            Draw();
        }

        private void Draw()
        {
            if (!drawing)
            {
                drawing = true;
                clock.SetWatch(watch);
                graphics.Clear(Color.White);
                clock.Draw(graphics);
                drawing = false;
            }
        }

        private void EventsBtn_Click(object sender, EventArgs e)
        {
            EventsForm form = new EventsForm(watch);
            form.Show();
        }
    }
}
 