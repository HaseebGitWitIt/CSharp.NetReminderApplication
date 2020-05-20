namespace Reminder_Application
{
    partial class ReminderApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.UsernamePanel = new System.Windows.Forms.Panel();
            this.UsernameSubmitButton = new System.Windows.Forms.Button();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.ApplicationPanel = new System.Windows.Forms.Panel();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.ReminderName = new System.Windows.Forms.TextBox();
            this.RepeatInput = new System.Windows.Forms.CheckBox();
            this.SubmitReminder = new System.Windows.Forms.Button();
            this.TimeInput = new System.Windows.Forms.DateTimePicker();
            this.ReminderMessage = new System.Windows.Forms.TextBox();
            this.ReminderLabel = new System.Windows.Forms.Label();
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.ReminderList = new System.Windows.Forms.ListView();
            this.RName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RRepeat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RemoveListItem = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.UsernamePanel.SuspendLayout();
            this.ApplicationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsernamePanel
            // 
            this.UsernamePanel.Controls.Add(this.UsernameSubmitButton);
            this.UsernamePanel.Controls.Add(this.UsernameInput);
            this.UsernamePanel.Controls.Add(this.UsernameLabel);
            this.UsernamePanel.Location = new System.Drawing.Point(13, 26);
            this.UsernamePanel.Name = "UsernamePanel";
            this.UsernamePanel.Size = new System.Drawing.Size(426, 290);
            this.UsernamePanel.TabIndex = 0;
            // 
            // UsernameSubmitButton
            // 
            this.UsernameSubmitButton.Location = new System.Drawing.Point(171, 107);
            this.UsernameSubmitButton.Name = "UsernameSubmitButton";
            this.UsernameSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.UsernameSubmitButton.TabIndex = 2;
            this.UsernameSubmitButton.Text = "Submit";
            this.UsernameSubmitButton.UseVisualStyleBackColor = true;
            this.UsernameSubmitButton.Click += new System.EventHandler(this.UsernameSubmitButton_Click);
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(132, 67);
            this.UsernameInput.MaxLength = 16;
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(149, 20);
            this.UsernameInput.TabIndex = 1;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(168, 33);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(93, 13);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Enter a username:";
            // 
            // ApplicationPanel
            // 
            this.ApplicationPanel.Controls.Add(this.RemoveListItem);
            this.ApplicationPanel.Controls.Add(this.ReminderList);
            this.ApplicationPanel.Controls.Add(this.SaveLabel);
            this.ApplicationPanel.Controls.Add(this.ReminderName);
            this.ApplicationPanel.Controls.Add(this.RepeatInput);
            this.ApplicationPanel.Controls.Add(this.SubmitReminder);
            this.ApplicationPanel.Controls.Add(this.TimeInput);
            this.ApplicationPanel.Controls.Add(this.ReminderMessage);
            this.ApplicationPanel.Controls.Add(this.ReminderLabel);
            this.ApplicationPanel.Controls.Add(this.WelcomeMessage);
            this.ApplicationPanel.Location = new System.Drawing.Point(12, 26);
            this.ApplicationPanel.Name = "ApplicationPanel";
            this.ApplicationPanel.Size = new System.Drawing.Size(426, 290);
            this.ApplicationPanel.TabIndex = 3;
            this.ApplicationPanel.Visible = false;
            // 
            // SaveLabel
            // 
            this.SaveLabel.AutoSize = true;
            this.SaveLabel.Location = new System.Drawing.Point(4, 131);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(150, 13);
            this.SaveLabel.TabIndex = 10;
            this.SaveLabel.Text = "I want to save this reminder as";
            // 
            // ReminderName
            // 
            this.ReminderName.Location = new System.Drawing.Point(160, 128);
            this.ReminderName.MaxLength = 10;
            this.ReminderName.Name = "ReminderName";
            this.ReminderName.Size = new System.Drawing.Size(102, 20);
            this.ReminderName.TabIndex = 9;
            // 
            // RepeatInput
            // 
            this.RepeatInput.AutoSize = true;
            this.RepeatInput.Checked = true;
            this.RepeatInput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RepeatInput.Location = new System.Drawing.Point(236, 94);
            this.RepeatInput.Name = "RepeatInput";
            this.RepeatInput.Size = new System.Drawing.Size(61, 17);
            this.RepeatInput.TabIndex = 8;
            this.RepeatInput.Text = "Repeat";
            this.RepeatInput.UseVisualStyleBackColor = true;
            // 
            // SubmitReminder
            // 
            this.SubmitReminder.Location = new System.Drawing.Point(268, 126);
            this.SubmitReminder.Name = "SubmitReminder";
            this.SubmitReminder.Size = new System.Drawing.Size(75, 23);
            this.SubmitReminder.TabIndex = 7;
            this.SubmitReminder.Text = "Save";
            this.SubmitReminder.UseVisualStyleBackColor = true;
            this.SubmitReminder.Click += new System.EventHandler(this.SubmitReminder_Click);
            // 
            // TimeInput
            // 
            this.TimeInput.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeInput.Location = new System.Drawing.Point(236, 66);
            this.TimeInput.Name = "TimeInput";
            this.TimeInput.ShowUpDown = true;
            this.TimeInput.Size = new System.Drawing.Size(173, 20);
            this.TimeInput.TabIndex = 6;
            // 
            // ReminderMessage
            // 
            this.ReminderMessage.Location = new System.Drawing.Point(17, 67);
            this.ReminderMessage.MaxLength = 100;
            this.ReminderMessage.Multiline = true;
            this.ReminderMessage.Name = "ReminderMessage";
            this.ReminderMessage.Size = new System.Drawing.Size(212, 51);
            this.ReminderMessage.TabIndex = 5;
            // 
            // ReminderLabel
            // 
            this.ReminderLabel.AutoSize = true;
            this.ReminderLabel.Location = new System.Drawing.Point(14, 51);
            this.ReminderLabel.Name = "ReminderLabel";
            this.ReminderLabel.Size = new System.Drawing.Size(281, 13);
            this.ReminderLabel.TabIndex = 4;
            this.ReminderLabel.Text = "Enter a reminder message and select a time to me notified:";
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.Location = new System.Drawing.Point(130, 0);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(52, 13);
            this.WelcomeMessage.TabIndex = 0;
            this.WelcomeMessage.Text = "Welcome";
            this.WelcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReminderList
            // 
            this.ReminderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RName,
            this.RMessage,
            this.RTime,
            this.RRepeat});
            this.ReminderList.FullRowSelect = true;
            this.ReminderList.HideSelection = false;
            this.ReminderList.Location = new System.Drawing.Point(3, 155);
            this.ReminderList.Name = "ReminderList";
            this.ReminderList.Size = new System.Drawing.Size(416, 97);
            this.ReminderList.TabIndex = 11;
            this.ReminderList.UseCompatibleStateImageBehavior = false;
            this.ReminderList.View = System.Windows.Forms.View.Details;
            // 
            // RName
            // 
            this.RName.Text = "Name";
            // 
            // RMessage
            // 
            this.RMessage.Text = "Message";
            this.RMessage.Width = 232;
            // 
            // RTime
            // 
            this.RTime.Text = "Time";
            this.RTime.Width = 70;
            // 
            // RRepeat
            // 
            this.RRepeat.Text = "Repeat";
            this.RRepeat.Width = 50;
            // 
            // RemoveListItem
            // 
            this.RemoveListItem.Location = new System.Drawing.Point(4, 258);
            this.RemoveListItem.Name = "RemoveListItem";
            this.RemoveListItem.Size = new System.Drawing.Size(75, 23);
            this.RemoveListItem.TabIndex = 12;
            this.RemoveListItem.Text = "Remove";
            this.RemoveListItem.UseVisualStyleBackColor = true;
            this.RemoveListItem.Click += new System.EventHandler(this.RemoveListItem_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 30000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ReminderApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 328);
            this.Controls.Add(this.ApplicationPanel);
            this.Controls.Add(this.UsernamePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ReminderApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminder Aplication";
            this.UsernamePanel.ResumeLayout(false);
            this.UsernamePanel.PerformLayout();
            this.ApplicationPanel.ResumeLayout(false);
            this.ApplicationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UsernamePanel;
        private System.Windows.Forms.Button UsernameSubmitButton;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Panel ApplicationPanel;
        private System.Windows.Forms.Label WelcomeMessage;
        private System.Windows.Forms.TextBox ReminderMessage;
        private System.Windows.Forms.Label ReminderLabel;
        private System.Windows.Forms.DateTimePicker TimeInput;
        private System.Windows.Forms.Button SubmitReminder;
        private System.Windows.Forms.CheckBox RepeatInput;
        private System.Windows.Forms.Label SaveLabel;
        private System.Windows.Forms.TextBox ReminderName;
        private System.Windows.Forms.ListView ReminderList;
        private System.Windows.Forms.ColumnHeader RName;
        private System.Windows.Forms.ColumnHeader RMessage;
        private System.Windows.Forms.ColumnHeader RTime;
        private System.Windows.Forms.ColumnHeader RRepeat;
        private System.Windows.Forms.Button RemoveListItem;
        private System.Windows.Forms.Timer Timer;
    }
}

