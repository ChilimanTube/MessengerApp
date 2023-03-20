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
            this.SuspendLayout();
            // 
            // NewMsgBtn
            // 
            this.NewMsgBtn.Location = new System.Drawing.Point(12, 50);
            this.NewMsgBtn.Name = "NewMsgBtn";
            this.NewMsgBtn.Size = new System.Drawing.Size(185, 57);
            this.NewMsgBtn.TabIndex = 0;
            this.NewMsgBtn.Text = "New Message";
            this.NewMsgBtn.UseVisualStyleBackColor = true;
            this.NewMsgBtn.Click += new System.EventHandler(this.NewMsgBtn_Click);
            // 
            // ReceivedMsgsBtn
            // 
            this.ReceivedMsgsBtn.Location = new System.Drawing.Point(12, 113);
            this.ReceivedMsgsBtn.Name = "ReceivedMsgsBtn";
            this.ReceivedMsgsBtn.Size = new System.Drawing.Size(185, 57);
            this.ReceivedMsgsBtn.TabIndex = 1;
            this.ReceivedMsgsBtn.Text = "Received Messages";
            this.ReceivedMsgsBtn.UseVisualStyleBackColor = true;
            this.ReceivedMsgsBtn.Click += new System.EventHandler(this.ReceivedMsgsBtn_Click);
            // 
            // SentMsgsBtn
            // 
            this.SentMsgsBtn.Location = new System.Drawing.Point(12, 176);
            this.SentMsgsBtn.Name = "SentMsgsBtn";
            this.SentMsgsBtn.Size = new System.Drawing.Size(185, 57);
            this.SentMsgsBtn.TabIndex = 2;
            this.SentMsgsBtn.Text = "Sent Messages";
            this.SentMsgsBtn.UseVisualStyleBackColor = true;
            this.SentMsgsBtn.Click += new System.EventHandler(this.SentMsgsBtn_Click);
            // 
            // WelcomeMsg
            // 
            this.WelcomeMsg.AutoSize = true;
            this.WelcomeMsg.Location = new System.Drawing.Point(12, 9);
            this.WelcomeMsg.Name = "WelcomeMsg";
            this.WelcomeMsg.Size = new System.Drawing.Size(145, 20);
            this.WelcomeMsg.TabIndex = 3;
            this.WelcomeMsg.Text = "Welcome Username!";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WelcomeMsg);
            this.Controls.Add(this.SentMsgsBtn);
            this.Controls.Add(this.ReceivedMsgsBtn);
            this.Controls.Add(this.NewMsgBtn);
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
    }
}