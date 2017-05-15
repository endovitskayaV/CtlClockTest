using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchPatterns
{
    public class Watch : WatchComponent, IObservable
    {
        public List<IObserver> observers;
        private System.Timers.Timer timer;

        public Watch()
        {
            observers = new List<IObserver>();
            timer = new System.Timers.Timer();
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
           // timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
            timer.Enabled = true;
            timer.Start();
        }
        public override void Draw(Label dL, Graphics graphTime)
        {
            DrawDate(dL);
        }

        private void DrawDate(Label dL)
        {
            dL.Text = Date.ToString("d");         
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.OnHandleEvent(this.Time);
            }
        }

       /* private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            NotifyObservers();
        }*/
    }
}
