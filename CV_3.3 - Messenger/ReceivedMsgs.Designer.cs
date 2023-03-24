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
            this.SenderTextBox = new System.Windows.Forms.TextBox();
            this.DeleteMsg = new System.Windows.Forms.Button();
            this.MessageView = new System.Windows.Forms.TextBox();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MessageList
            // 
            this.MessageList.FormattingEnabled = true;
            this.MessageList.ItemHeight = 15;
            this.MessageList.Location = new System.Drawing.Point(10, 9);
            this.MessageList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MessageList.Name = "MessageList";
            this.MessageList.Size = new System.Drawing.Size(361, 319);
            this.MessageList.TabIndex = 0;
            // 
            // SenderTextBox
            // 
            this.SenderTextBox.Location = new System.Drawing.Point(377, 9);
            this.SenderTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SenderTextBox.Name = "SenderTextBox";
            this.SenderTextBox.PlaceholderText = "Sender";
            this.SenderTextBox.Size = new System.Drawing.Size(331, 23);
            this.SenderTextBox.TabIndex = 1;
            // 
            // DeleteMsg
            // 
            this.DeleteMsg.Location = new System.Drawing.Point(960, 284);
            this.DeleteMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteMsg.Name = "DeleteMsg";
            this.DeleteMsg.Size = new System.Drawing.Size(105, 46);
            this.DeleteMsg.TabIndex = 4;
            this.DeleteMsg.Text = "Delete";
            this.DeleteMsg.UseVisualStyleBackColor = true;
            // 
            // MessageView
            // 
            this.MessageView.Location = new System.Drawing.Point(377, 37);
            this.MessageView.Multiline = true;
            this.MessageView.Name = "MessageView";
            this.MessageView.PlaceholderText = "Message View";
            this.MessageView.ReadOnly = true;
            this.MessageView.Size = new System.Drawing.Size(688, 242);
            this.MessageView.TabIndex = 5;
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Location = new System.Drawing.Point(714, 9);
            this.SubjectTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.PlaceholderText = "Subject";
            this.SubjectTextBox.Size = new System.Drawing.Size(351, 23);
            this.SubjectTextBox.TabIndex = 8;
            // 
            // ReceivedMsgs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 338);
            this.Controls.Add(this.SubjectTextBox);
            this.Controls.Add(this.MessageView);
            this.Controls.Add(this.DeleteMsg);
            this.Controls.Add(this.SenderTextBox);
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
        private TextBox SenderTextBox;
        private Button DeleteMsg;
        private TextBox MessageView;
        private TextBox SubjectTextBox;
    }
}