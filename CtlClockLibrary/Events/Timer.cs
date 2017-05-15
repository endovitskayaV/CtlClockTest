using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Media;

namespace WatchPatterns
{
    class Timer
    {
        private SoundPlayer sound;
        private DateTime timerTime;
        private Form form;
        private bool IsRinging;
        private System.Windows.Forms.Timer timer;
        private Label label;

        public Timer(string soundString, DateTime time)
        {
            this.timerTime = time;
            sound = new SoundPlayer(soundString);
            CreateForm();
            IsRinging = false;
        }

        private void CreateForm()
        {
            form = new Form();
            form.Size = new System.Drawing.Size(165, 100);
            label = new Label();
            label.Font = new Font(label.Font.FontFamily, label.Font.Size * 2);
            label.Location = new Point(30, 15);
            form.Controls.Add(label);
            label.Text = this.timerTime.ToLongTimeString();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += Timer_Tick;
            form.Show();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timerTime.Hour == 0 && timerTime.Minute == 0 && timerTime.Second == 0 && (!IsRinging))
            {
                timer.Stop();
                IsRinging = true;
                Ring();
            }
            else
            {
                this.timerTime = this.timerTime.AddSeconds(-1);
                label.Text = this.timerTime.ToLongTimeString();
            }
        }

        private void Ring()
        {
            sound.Play();
            if (MessageBox.Show("Time is up!") == DialogResult.OK)
            {
                sound.Stop();
                IsRinging = false;
                form.Close();
            }
        }
    }
}

