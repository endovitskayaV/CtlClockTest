using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchPatterns
{
    public class Watch : WatchComponent
    {
        public Watch(int timeOffset) : base(timeOffset)
        {
            //base-наследование действий родителя
        }

        public Watch() : base() 
        {

        }

        public override void Draw(Size size, Graphics graphTime)
        {
           
        }

       
       
    }
}
