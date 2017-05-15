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
    public partial class EventsForm : Form
    {
        private Watch watch;
        private List<IObserver> eventsList;

        public EventsForm(Watch watch)
        {
            InitializeComponent();
            this.watch = watch;
            eventsList = new List<IObserver>();
        }

        private void EventsForm_Load(object sender, EventArgs e)
        {
            comboBox.SelectedItem = "Alarm";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
            IObserver newEvent = new AlarmObserver();
            DateTime aimTime = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, DateTime.Now.Date.Day, (int)numericUpDownH.Value, (int)numericUpDownM.Value, (int)numericUpDownS.Value);
            if (DateTime.Now.CompareTo(aimTime)>0)
            {
                aimTime= aimTime.AddDays(1);
            }
            switch (comboBox.Text)
            {
                case "Alarm":
                    newEvent = new AlarmObserver(watch, "alarm.wav", aimTime);
                    eventsList.Add(newEvent);
                    break;
                case "Timer":
                    Timer eventTimer = new Timer("alarm.wav", aimTime);
                    break;
                case "Stopwatch":
                    Stopwatch eventStwtch = new Stopwatch();
                    break;
                default:
                    MessageBox.Show("No such option!");
                    break;
            }
           
            PrintEvents(newEvent);
            if (comboBox.Text.Equals("Alarm")) MessageBox.Show(comboBox.Text + " added");
        }

        private void showEventsBtn_Click(object sender, EventArgs e)
        {
           
            if (showEventsBtn.Text.Equals("Hide"))
            {
                HideEvents();
            }
            else
            {
                eventsListBox.Items.Clear();
                this.Height += 170;
                showEventsBtn.Text = "Hide";
                if (eventsList.Count >= 1)
                {
                    foreach (IObserver ev in eventsList)
                        PrintEvents(ev);
                }
            }
        }

        private void removeEvent_Btn_Click(object sender, EventArgs e)
        {
            if (eventsListBox.SelectedIndex != -1)
            {
                watch.RemoveObserver(eventsList[eventsListBox.SelectedIndex]);
                eventsList.RemoveAt(eventsListBox.SelectedIndex);
                eventsListBox.Items.RemoveAt(eventsListBox.SelectedIndex);
            }
        }

        private void comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!comboBox.Text.Equals("Alarm"))
            {
                showEventsBtn.Enabled = false;
                HideEvents();
            }
            else showEventsBtn.Enabled = true;

            if (comboBox.Text.Equals("Stopwatch")) groupBox.Enabled = false;
            else groupBox.Enabled = true;
        }

        private void PrintEvents(IObserver newEvent)
        {
            eventsListBox.Items.Add("Alarm " + ((AlarmObserver)newEvent).AlarmTime.ToLongTimeString()+" "+ ((AlarmObserver)newEvent).AlarmTime.ToString("dd.MM"));
        }

        private void HideEvents()
        {
            eventsListBox.Items.Clear();
            this.Height -= 170;
            showEventsBtn.Text = "Show all";
        }
    }
}
