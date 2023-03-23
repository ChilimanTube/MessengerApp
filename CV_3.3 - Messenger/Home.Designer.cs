namespace CV_3._3___Messenger
{
    partial class Home
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
            this.NewMsgBtn = new System.Windows.Forms.Button();
            this.ReceivedMsgsBtn = new System.Windows.Forms.Button();
            this.SentMsgsBtn = new System.Windows.Forms.Button();
            this.WelcomeMsg = new System.Windows.Forms.Label();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.AppName = new System.Windows.Forms.Label();
            this.LoggedInAsLabel = new System.Windows.Forms.Label();
            this.LoggedInAsUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewMsgBtn
            // 
            this.NewMsgBtn.Location = new System.Drawing.Point(276, 133);
            this.NewMsgBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewMsgBtn.Name = "NewMsgBtn";
            this.NewMsgBtn.Size = new System.Drawing.Size(162, 43);
            this.NewMsgBtn.TabIndex = 0;
            this.NewMsgBtn.Text = "New Message";
            this.NewMsgBtn.UseVisualStyleBackColor = true;
            this.NewMsgBtn.Click += new System.EventHandler(this.NewMsgBtn_Click);
            // 
            // ReceivedMsgsBtn
            // 
            this.ReceivedMsgsBtn.Location = new System.Drawing.Point(276, 180);
            this.ReceivedMsgsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReceivedMsgsBtn.Name = "ReceivedMsgsBtn";
            this.ReceivedMsgsBtn.Size = new System.Drawing.Size(162, 43);
            this.ReceivedMsgsBtn.TabIndex = 1;
            this.ReceivedMsgsBtn.Text = "Received Messages";
            this.ReceivedMsgsBtn.UseVisualStyleBackColor = true;
            this.ReceivedMsgsBtn.Click += new System.EventHandler(this.ReceivedMsgsBtn_Click);
            // 
            // SentMsgsBtn
            // 
            this.SentMsgsBtn.Location = new System.Drawing.Point(276, 227);
            this.SentMsgsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SentMsgsBtn.Name = "SentMsgsBtn";
            this.SentMsgsBtn.Size = new System.Drawing.Size(162, 43);
            this.SentMsgsBtn.TabIndex = 2;
            this.SentMsgsBtn.Text = "Sent Messages";
            this.SentMsgsBtn.UseVisualStyleBackColor = true;
            this.SentMsgsBtn.Click += new System.EventHandler(this.SentMsgsBtn_Click);
            // 
            // WelcomeMsg
            // 
            this.WelcomeMsg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WelcomeMsg.AutoSize = true;
            this.WelcomeMsg.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WelcomeMsg.Location = new System.Drawing.Point(276, 91);
            this.WelcomeMsg.Name = "WelcomeMsg";
            this.WelcomeMsg.Size = new System.Drawing.Size(152, 25);
            this.WelcomeMsg.TabIndex = 3;
            this.WelcomeMsg.Text = "Good Morning!";
            this.WelcomeMsg.Click += new System.EventHandler(this.WelcomeMsg_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BackColor = System.Drawing.SystemColors.Control;
            this.LogOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.LogOutBtn.ForeColor = System.Drawing.Color.Red;
            this.LogOutBtn.Location = new System.Drawing.Point(528, 286);
            this.LogOutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(162, 43);
            this.LogOutBtn.TabIndex = 4;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AppName.Location = new System.Drawing.Point(196, 52);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(328, 39);
            this.AppName.TabIndex = 6;
            this.AppName.Text = "M E S S E N G E R";
            // 
            // LoggedInAsLabel
            // 
            this.LoggedInAsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoggedInAsLabel.AutoSize = true;
            this.LoggedInAsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoggedInAsLabel.Location = new System.Drawing.Point(12, 309);
            this.LoggedInAsLabel.Name = "LoggedInAsLabel";
            this.LoggedInAsLabel.Size = new System.Drawing.Size(87, 17);
            this.LoggedInAsLabel.TabIndex = 7;
            this.LoggedInAsLabel.Text = "Logged in as:";
            // 
            // LoggedInAsUsername
            // 
            this.LoggedInAsUsername.AutoSize = true;
            this.LoggedInAsUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoggedInAsUsername.Location = new System.Drawing.Point(105, 309);
            this.LoggedInAsUsername.Name = "LoggedInAsUsername";
            this.LoggedInAsUsername.Size = new System.Drawing.Size(69, 17);
            this.LoggedInAsUsername.TabIndex = 8;
            this.LoggedInAsUsername.Text = "Username";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.LoggedInAsUsername);
            this.Controls.Add(this.LoggedInAsLabel);
            this.Controls.Add(this.AppName);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.WelcomeMsg);
            this.Controls.Add(this.SentMsgsBtn);
            this.Controls.Add(this.ReceivedMsgsBtn);
            this.Controls.Add(this.NewMsgBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button NewMsgBtn;
        private Button ReceivedMsgsBtn;
        private Button SentMsgsBtn;
        private Label WelcomeMsg;
        private Button LogOutBtn;
        private Label AppName;
        private Label LoggedInAsLabel;
        private Label LoggedInAsUsername;
    }
}