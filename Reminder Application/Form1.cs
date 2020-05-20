using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reminder_Application
{
    public partial class ReminderApplication : Form
    {
        List<Reminder> reminders = new List<Reminder>();
        private String username;
        private readonly int DEFAULT_POLL_INTERVAL = 30000;
        public ReminderApplication()
        {
            InitializeComponent();
        }

        private void UsernameSubmitButton_Click(object sender, EventArgs e)
        {
            if(ValidateUserInput(UsernameInput.Text))
            {
                username = UsernameInput.Text;
                WelcomeMessage.Text = "Hello " + username + ",\n Welcome to Reminder Application!";
                UsernamePanel.Visible = false;
                ApplicationPanel.Visible = true;
            }
        }

        private Boolean ValidateUserInput(String input)
        {
            if(input.Trim().Length > 1)
            {
                return true;
            }
            return false;
        }

        private Boolean TimeslotNotTaken(DateTime time)
        {
            foreach(Reminder r in reminders)
            {
                if(r.time.ToString("h:mm tt") == time.ToString("h:mm tt"))
                {
                    return false;
                }
            }
            return true;
        }

        private Boolean NameNotTaken(String name)
        {
            foreach(Reminder r in reminders)
            {
                if(r.name == name)
                {
                    return false;
                }
            }
            return true;
        }

        private void SubmitReminder_Click(object sender, EventArgs e)
        {
            String message = ReminderMessage.Text;
            String name = ReminderName.Text;
            DateTime time = TimeInput.Value;
            if (NameNotTaken(name) && TimeslotNotTaken(time) && ValidateUserInput(message) && ValidateUserInput(name))
            {
                bool repeat = RepeatInput.Checked;
                Reminder temp = new Reminder(message, time, repeat, name);
                reminders.Add(temp);
                UpdateReminders();
                ClearFields();
            }
        }

        private void ClearFields()
        {
            ReminderMessage.Text = "";
            ReminderName.Text = "";
        }

        private void UpdateReminders()
        {
            ReminderList.Items.Clear();
            foreach(Reminder r in reminders)
            {
                String time = r.time.ToString("h:mm tt");
                string[] row = { r.name, r.message,time, r.repeat.ToString()};
                ReminderList.Items.Add(new ListViewItem(row));
            }
            Timer_Tick(null, null);
        }

        private void RemoveListItem_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in ReminderList.SelectedItems)
            {
                ReminderList.Items.Remove(item);
                for(int a = 0; a < reminders.Count; a++)
                {
                    if(reminders[a].name == item.Text)
                    {
                        reminders.RemoveAt(a);
                    }
                }
            }
            Timer_Tick(null, null);
        }

        private void CheckReminders()
        {
            DateTime time = DateTime.Now;
            List<int> removeReminder = new List<int>();
            foreach(Reminder r in reminders)
            {
                System.Diagnostics.Debug.WriteLine("CheckReminders: comparison: " + r.name + " " + r.time.ToString("h:mm tt") == time.ToString("h:mm tt"));
                if (r.time.ToString("h:mm tt") == time.ToString("h:mm tt"))
                {
                    removeReminder = SendReminder(r);
                }
            }
            foreach(int index in removeReminder)
            {
                reminders.RemoveAt(index);
            }
        }

        private List<int> SendReminder(Reminder r)
        {
            List<int> removeReminderIndex = new List<int>();
            System.Diagnostics.Debug.WriteLine("\nMessage: " + r.message+ "\n");
            if(!r.repeat)
            {
                for(int a = 0; a < reminders.Count; a++)
                {
                    if(reminders[a].name == r.name)
                    {
                        removeReminderIndex.Add(a);
                    }
                }
                foreach(ListViewItem item in ReminderList.Items)
                {
                    if(item.Text == r.name)
                    {
                        ReminderList.Items.Remove(item);
                    }
                }
            }
            return removeReminderIndex;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Timer_Tick: reminder count " + reminders.Count);
            if (reminders.Count > 0)
            {
                CheckReminders();
                Reminder closestReminder = GetNextReminder();
                SetTimerInterval(closestReminder);
            }
        }

        private void SetTimerInterval(Reminder r)
        {
            DateTime current = DateTime.Now;
            DateTime b = new DateTime(r.time.Year, r.time.Month, r.time.Day, r.time.Hour, r.time.Minute, 00);
            DateTime a = new DateTime(current.Year, current.Month, current.Day, current.Hour, current.Minute, 00);
            double difference = b.Subtract(a).Minutes;
            System.Diagnostics.Debug.WriteLine("Interval " + difference);
            if (difference < 3)
            {
                Timer.Interval = DEFAULT_POLL_INTERVAL;
            } else
            {
                Timer.Interval = (int)((difference - 1) * 60000);
            }
        }

        private Reminder GetNextReminder()
        {
            Reminder closestReminder = reminders[0];
            DateTime current = DateTime.Now;
            double currentMinDifference = double.MaxValue;
            foreach(Reminder r in reminders)
            {
                DateTime b = new DateTime(r.time.Year, r.time.Month, r.time.Day, r.time.Hour, r.time.Minute, 00);
                DateTime a = new DateTime(current.Year, current.Month, current.Day, current.Hour, current.Minute, 00);
                double difference = b.Subtract(a).Minutes;
                System.Diagnostics.Debug.Write("Difference " + difference);
                if (difference > 0 && difference < currentMinDifference)
                {
                    currentMinDifference = difference;
                    closestReminder = r;
                }
            }
            System.Diagnostics.Debug.WriteLine("Closest reminder " + closestReminder.name);
            return closestReminder;
        }

       
    }
}
