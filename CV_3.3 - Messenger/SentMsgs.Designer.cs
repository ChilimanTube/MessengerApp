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
            this.MessageView = new System.Windows.Forms.ListBox();
            this.DeleteMsg = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MessageList
            // 
            this.MessageList.FormattingEnabled = true;
            this.MessageList.ItemHeight = 20;
            this.MessageList.Location = new System.Drawing.Point(12, 14);
            this.MessageList.Name = "MessageList";
            this.MessageList.Size = new System.Drawing.Size(266, 424);
            this.MessageList.TabIndex = 1;
            // 
            // MessageView
            // 
            this.MessageView.FormattingEnabled = true;
            this.MessageView.ItemHeight = 20;
            this.MessageView.Location = new System.Drawing.Point(284, 47);
            this.MessageView.Name = "MessageView";
            this.MessageView.Size = new System.Drawing.Size(504, 324);
            this.MessageView.TabIndex = 3;
            // 
            // DeleteMsg
            // 
            this.DeleteMsg.Location = new System.Drawing.Point(284, 377);
            this.DeleteMsg.Name = "DeleteMsg";
            this.DeleteMsg.Size = new System.Drawing.Size(120, 61);
            this.DeleteMsg.TabIndex = 5;
            this.DeleteMsg.Text = "Delete";
            this.DeleteMsg.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(284, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Recipient";
            this.textBox1.Size = new System.Drawing.Size(504, 27);
            this.textBox1.TabIndex = 6;
            // 
            // SentMsgs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DeleteMsg);
            this.Controls.Add(this.MessageView);
            this.Controls.Add(this.MessageList);
            this.Name = "SentMsgs";
            this.Text = "SentMsgs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox MessageList;
        private ListBox MessageView;
        private Button DeleteMsg;
        private TextBox textBox1;
    }
}