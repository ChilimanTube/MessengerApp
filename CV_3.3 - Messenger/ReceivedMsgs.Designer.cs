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
            this.MessageList.ItemHeight = 15;
            this.MessageList.Location = new System.Drawing.Point(10, 9);
            this.MessageList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MessageList.Name = "MessageList";
            this.MessageList.Size = new System.Drawing.Size(233, 319);
            this.MessageList.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 9);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Sender";
            this.textBox1.Size = new System.Drawing.Size(442, 23);
            this.textBox1.TabIndex = 1;
            // 
            // MessageView
            // 
            this.MessageView.FormattingEnabled = true;
            this.MessageView.ItemHeight = 15;
            this.MessageView.Location = new System.Drawing.Point(248, 34);
            this.MessageView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MessageView.Name = "MessageView";
            this.MessageView.Size = new System.Drawing.Size(442, 244);
            this.MessageView.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 281);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mark as read";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DeleteMsg
            // 
            this.DeleteMsg.Location = new System.Drawing.Point(248, 283);
            this.DeleteMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteMsg.Name = "DeleteMsg";
            this.DeleteMsg.Size = new System.Drawing.Size(105, 46);
            this.DeleteMsg.TabIndex = 4;
            this.DeleteMsg.Text = "Delete";
            this.DeleteMsg.UseVisualStyleBackColor = true;
            // 
            // ReceivedMsgs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.DeleteMsg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MessageView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MessageList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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