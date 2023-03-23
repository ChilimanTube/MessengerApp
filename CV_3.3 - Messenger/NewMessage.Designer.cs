namespace CV_3._3___Messenger
{
    partial class NewMessage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RecipientTextBox = new System.Windows.Forms.TextBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RecipientTextBox
            // 
            this.RecipientTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RecipientTextBox.Location = new System.Drawing.Point(9, 11);
            this.RecipientTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecipientTextBox.Name = "RecipientTextBox";
            this.RecipientTextBox.PlaceholderText = "Recipient";
            this.RecipientTextBox.Size = new System.Drawing.Size(341, 23);
            this.RecipientTextBox.TabIndex = 1;
            this.RecipientTextBox.TextChanged += new System.EventHandler(this.RecipientTextBox_TextChanged);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MessageTextBox.Location = new System.Drawing.Point(9, 38);
            this.MessageTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.PlaceholderText = "Message";
            this.MessageTextBox.Size = new System.Drawing.Size(1029, 302);
            this.MessageTextBox.TabIndex = 2;
            this.MessageTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SubjectTextBox.Location = new System.Drawing.Point(356, 11);
            this.SubjectTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.PlaceholderText = "Subject";
            this.SubjectTextBox.Size = new System.Drawing.Size(395, 23);
            this.SubjectTextBox.TabIndex = 3;
            this.SubjectTextBox.TextChanged += new System.EventHandler(this.SubjectTextBox_TextChanged);
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(927, 344);
            this.SendBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(110, 39);
            this.SendBtn.TabIndex = 4;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // NewMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 394);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.SubjectTextBox);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.RecipientTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewMessage";
            this.Text = "NewMessage";
            this.Load += new System.EventHandler(this.NewMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox RecipientTextBox;
        private TextBox MessageTextBox;
        private TextBox SubjectTextBox;
        private Button SendBtn;
    }
}