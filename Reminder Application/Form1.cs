using System;
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
        IDictionary<String, Reminder> reminders = new Dictionary<String, Reminder>();
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

            if (ValidateUserInput(message))
            {
                String creationDate = new DateTime().ToString();
                DateTime time = TimeInput.Value;
                bool repeat = RepeatInput.Checked;
                Reminder temp = new Reminder(message, time, repeat, creationDate);
                reminders.Add(creationDate, temp);
            }
        }
    }
}
