namespace CV_3._3___Messenger
{
    partial class ReceivedMsgs
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
            this.MessageList = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MessageView = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteMsg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageList
            // 
            this.MessageList.FormattingEnabled = true;
            this.MessageList.ItemHeight = 20;
            this.MessageList.Location = new System.Drawing.Point(11, 12);
            this.MessageList.Name = "MessageList";
            this.MessageList.Size = new System.Drawing.Size(697, 424);
            this.MessageList.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(714, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Sender";
            this.textBox1.Size = new System.Drawing.Size(505, 27);
            this.textBox1.TabIndex = 1;
            // 
            // MessageView
            // 
            this.MessageView.FormattingEnabled = true;
            this.MessageView.ItemHeight = 20;
            this.MessageView.Location = new System.Drawing.Point(714, 45);
            this.MessageView.Name = "MessageView";
            this.MessageView.Size = new System.Drawing.Size(505, 324);
            this.MessageView.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1099, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 61);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mark as read";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DeleteMsg
            // 
            this.DeleteMsg.Location = new System.Drawing.Point(714, 378);
            this.DeleteMsg.Name = "DeleteMsg";
            this.DeleteMsg.Size = new System.Drawing.Size(120, 61);
            this.DeleteMsg.TabIndex = 4;
            this.DeleteMsg.Text = "Delete";
            this.DeleteMsg.UseVisualStyleBackColor = true;
            // 
            // ReceivedMsgs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 451);
            this.Controls.Add(this.DeleteMsg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MessageView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MessageList);
            this.Name = "ReceivedMsgs";
            this.Text = "ReceivedMsgs";
            this.Load += new System.EventHandler(this.ReceivedMsgs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox MessageList;
        private TextBox textBox1;
        private ListBox MessageView;
        private Button button1;
        private Button DeleteMsg;
    }
}