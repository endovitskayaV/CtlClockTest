using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtlClockTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctlClock1.TimeOffset = 3;
           // ctlClock2.Mode = CtlClockLibrary.CtlClock.ClockMode.Digital;
           // ctlClock3.Size = new Size(100,100);
           // ctlClock4.Size = new Size(50, 50);
        }
    }
}
