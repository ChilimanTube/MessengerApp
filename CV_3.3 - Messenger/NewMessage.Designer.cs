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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RecipientTextBox
            // 
            this.RecipientTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RecipientTextBox.Location = new System.Drawing.Point(10, 23);
            this.RecipientTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecipientTextBox.Name = "RecipientTextBox";
            this.RecipientTextBox.PlaceholderText = "Recipient";
            this.RecipientTextBox.Size = new System.Drawing.Size(188, 23);
            this.RecipientTextBox.TabIndex = 1;
            this.RecipientTextBox.TextChanged += new System.EventHandler(this.RecipientTextBox_TextChanged);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Doručené";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.Text = "Nová zpráva";
            this.toolStripTextBox2.Click += new System.EventHandler(this.toolStripTextBox2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1049, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MessageTextBox.Location = new System.Drawing.Point(10, 48);
            this.MessageTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.PlaceholderText = "Message";
            this.MessageTextBox.Size = new System.Drawing.Size(1029, 175);
            this.MessageTextBox.TabIndex = 2;
            this.MessageTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SubjectTextBox.Location = new System.Drawing.Point(203, 23);
            this.SubjectTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.PlaceholderText = "Subject";
            this.SubjectTextBox.Size = new System.Drawing.Size(188, 23);
            this.SubjectTextBox.TabIndex = 3;
            this.SubjectTextBox.TextChanged += new System.EventHandler(this.SubjectTextBox_TextChanged);
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(956, 226);
            this.SendBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(82, 22);
            this.SendBtn.TabIndex = 4;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Location = new System.Drawing.Point(396, 23);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // NewMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 394);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.SubjectTextBox);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.RecipientTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewMessage";
            this.Text = "NewMessage";
            this.Load += new System.EventHandler(this.NewMessage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox RecipientTextBox;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripTextBox toolStripTextBox2;
        private MenuStrip menuStrip1;
        private TextBox MessageTextBox;
        private TextBox SubjectTextBox;
        private Button SendBtn;
        private DateTimePicker dateTimePicker1;
    }
}