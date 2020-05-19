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
            this.UsernamePanel = new System.Windows.Forms.Panel();
            this.UsernameSubmitButton = new System.Windows.Forms.Button();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.ApplicationPanel = new System.Windows.Forms.Panel();
            this.WelcomeMessage = new System.Windows.Forms.Label();
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
            this.ApplicationPanel.Controls.Add(this.WelcomeMessage);
            this.ApplicationPanel.Location = new System.Drawing.Point(12, 26);
            this.ApplicationPanel.Name = "ApplicationPanel";
            this.ApplicationPanel.Size = new System.Drawing.Size(426, 290);
            this.ApplicationPanel.TabIndex = 3;
            this.ApplicationPanel.Visible = false;
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
    }
}

