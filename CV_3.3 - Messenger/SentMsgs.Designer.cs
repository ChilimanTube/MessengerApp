namespace CV_3._3___Messenger
{
    partial class SentMsgs
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
            this.DeleteMsg = new System.Windows.Forms.Button();
            this.RecipientTextBox = new System.Windows.Forms.TextBox();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.MessagePreview = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MessageList
            // 
            this.MessageList.FormattingEnabled = true;
            this.MessageList.ItemHeight = 15;
            this.MessageList.Location = new System.Drawing.Point(10, 10);
            this.MessageList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MessageList.Name = "MessageList";
            this.MessageList.Size = new System.Drawing.Size(438, 469);
            this.MessageList.TabIndex = 1;
            // 
            // DeleteMsg
            // 
            this.DeleteMsg.Location = new System.Drawing.Point(1002, 433);
            this.DeleteMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteMsg.Name = "DeleteMsg";
            this.DeleteMsg.Size = new System.Drawing.Size(105, 46);
            this.DeleteMsg.TabIndex = 5;
            this.DeleteMsg.Text = "Delete";
            this.DeleteMsg.UseVisualStyleBackColor = true;
            this.DeleteMsg.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RecipientTextBox
            // 
            this.RecipientTextBox.Location = new System.Drawing.Point(454, 10);
            this.RecipientTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecipientTextBox.Name = "RecipientTextBox";
            this.RecipientTextBox.PlaceholderText = "Recipient";
            this.RecipientTextBox.Size = new System.Drawing.Size(315, 23);
            this.RecipientTextBox.TabIndex = 6;
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Location = new System.Drawing.Point(792, 11);
            this.SubjectTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.PlaceholderText = "Subject";
            this.SubjectTextBox.Size = new System.Drawing.Size(315, 23);
            this.SubjectTextBox.TabIndex = 7;
            // 
            // MessagePreview
            // 
            this.MessagePreview.Location = new System.Drawing.Point(454, 39);
            this.MessagePreview.Multiline = true;
            this.MessagePreview.Name = "MessagePreview";
            this.MessagePreview.PlaceholderText = "MessagePreview";
            this.MessagePreview.ReadOnly = true;
            this.MessagePreview.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MessagePreview.Size = new System.Drawing.Size(653, 389);
            this.MessagePreview.TabIndex = 8;
            this.MessagePreview.TextChanged += new System.EventHandler(this.MessagePreview_TextChanged);
            // 
            // SentMsgs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 493);
            this.Controls.Add(this.MessagePreview);
            this.Controls.Add(this.SubjectTextBox);
            this.Controls.Add(this.RecipientTextBox);
            this.Controls.Add(this.DeleteMsg);
            this.Controls.Add(this.MessageList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SentMsgs";
            this.Text = "SentMsgs";
            this.Load += new System.EventHandler(this.SentMsgs_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox MessageList;
        private ListBox MessageView;
        private Button DeleteMsg;
        private TextBox RecipientTextBox;
        private TextBox SubjectTextBox;
        private TextBox MessagePreview;
    }
}