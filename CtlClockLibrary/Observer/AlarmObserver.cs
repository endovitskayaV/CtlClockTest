using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchPatterns
{
    class AlarmObserver : IObserver
    {
        private SoundPlayer sound;
        private IObservable watch;
        private DateTime alarmTime;

        public DateTime AlarmTime
        {
            get
            {
                return alarmTime;
            }
        }

        public AlarmObserver()
        {
        }
       
        public AlarmObserver(IObservable watch, string soundString, DateTime time)
        {
            this.alarmTime = time;
            this.watch = watch;
            watch.AddObserver(this);
            sound = new SoundPlayer(soundString);
        }

        public void OnHandleEvent(TimeSpan time)
        {
            if ((time.Hours == alarmTime.Hour) && (time.Minutes == alarmTime.Minute) && (time.Seconds == alarmTime.Second))
            {
                Ring();
            }
        }

        private void Ring()
        {
            sound.Play();
            if (MessageBox.Show("Alarm") == DialogResult.OK)
            {
                sound.Stop();
                alarmTime.AddDays(1);
            }
        }
    }
}
