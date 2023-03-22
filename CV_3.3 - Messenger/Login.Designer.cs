namespace CV_3._3___Messenger
{
    partial class Login
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
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.AppName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(244, 108);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PlaceholderText = "Username";
            this.usernameTextBox.Size = new System.Drawing.Size(204, 23);
            this.usernameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(244, 143);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PlaceholderText = "Password";
            this.passwordTextBox.Size = new System.Drawing.Size(204, 23);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(306, 186);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(82, 22);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.Location = new System.Drawing.Point(306, 262);
            this.SignUpBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(82, 22);
            this.SignUpBtn.TabIndex = 3;
            this.SignUpBtn.Text = "SignUp";
            this.SignUpBtn.UseVisualStyleBackColor = true;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SignUpLabel.Location = new System.Drawing.Point(262, 234);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(161, 19);
            this.SignUpLabel.TabIndex = 4;
            this.SignUpLabel.Text = "New user? Sign up here!";
            this.SignUpLabel.Click += new System.EventHandler(this.SignUpLabel_Click);
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AppName.Location = new System.Drawing.Point(177, 52);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(328, 39);
            this.AppName.TabIndex = 5;
            this.AppName.Text = "M E S S E N G E R";
            this.AppName.Click += new System.EventHandler(this.AppName_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.AppName);
            this.Controls.Add(this.SignUpLabel);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button LoginBtn;
        private Button SignUpBtn;
        private Label SignUpLabel;
        private Label AppName;
    }
}