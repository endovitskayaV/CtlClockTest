using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WatchPatterns
{
    class Stopwatch
    { 
        private Form form;
        private DateTime time;
        private System.Windows.Forms.Timer timer;
        private Label label;

        public Stopwatch()
        {
            time = new DateTime(1, 1, 1, 0, 0, 0);
            CreateForm();
        }

        private void CreateForm()
        {
            form = new Form();
            form.Size = new System.Drawing.Size(165, 100);
            label = new Label();
            label.Font = new Font(label.Font.FontFamily, label.Font.Size *2);
            label.Location = new Point(30, 15);
            form.Controls.Add(label);
            label.Text = this.time.ToLongTimeString();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += Timer_Tick;
            form.Show();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
           this.time = this.time.AddSeconds(1);
           label.Text = this.time.ToLongTimeString();
        }
    }
}
