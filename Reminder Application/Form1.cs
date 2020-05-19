﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reminder_Application
{
    public partial class ReminderApplication : Form
    {
        List<Reminder> reminders = new List<Reminder>();
        private String username;
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

        private void SubmitReminder_Click(object sender, EventArgs e)
        {
            String message = ReminderMessage.Text;
            String name = ReminderName.Text;

            if (ValidateUserInput(message) && ValidateUserInput(name))
            {
                DateTime time = TimeInput.Value;
                bool repeat = RepeatInput.Checked;
                Reminder temp = new Reminder(message, time, repeat, name);
                reminders.Add(temp);
                UpdateReminders();
            }
        }

        private void UpdateReminders()
        {
            foreach(Reminder r in reminders)
            {
                string[] row = { r.name, r.message, r.time.ToString(), r.repeat.ToString()};
                ReminderList.Items.Add(new ListViewItem(row));
            }
        }
    }
}
