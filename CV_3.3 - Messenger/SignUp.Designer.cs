﻿namespace CV_3._3___Messenger
{
    partial class SignUp
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
            this.AppName = new System.Windows.Forms.Label();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StrengthIndicator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(244, 116);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PlaceholderText = "Username";
            this.usernameTextBox.Size = new System.Drawing.Size(204, 23);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(244, 152);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PlaceholderText = "Password";
            this.passwordTextBox.Size = new System.Drawing.Size(204, 23);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AppName.Location = new System.Drawing.Point(177, 56);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(328, 39);
            this.AppName.TabIndex = 6;
            this.AppName.Text = "M E S S E N G E R";
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.Enabled = false;
            this.SignUpBtn.Location = new System.Drawing.Point(306, 205);
            this.SignUpBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(82, 22);
            this.SignUpBtn.TabIndex = 7;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.UseVisualStyleBackColor = true;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SignUpLabel.Location = new System.Drawing.Point(244, 246);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(185, 19);
            this.SignUpLabel.TabIndex = 8;
            this.SignUpLabel.Text = "Already a user?   Login here!";
            this.SignUpLabel.Click += new System.EventHandler(this.SignUpLabel_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(306, 266);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(82, 22);
            this.LoginBtn.TabIndex = 9;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(244, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Password Strength:";
            this.label1.Visible = false;
            // 
            // StrengthIndicator
            // 
            this.StrengthIndicator.AutoSize = true;
            this.StrengthIndicator.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StrengthIndicator.ForeColor = System.Drawing.Color.Red;
            this.StrengthIndicator.Location = new System.Drawing.Point(358, 177);
            this.StrengthIndicator.Name = "StrengthIndicator";
            this.StrengthIndicator.Size = new System.Drawing.Size(37, 15);
            this.StrengthIndicator.TabIndex = 11;
            this.StrengthIndicator.Text = "Weak";
            this.StrengthIndicator.Visible = false;
            this.StrengthIndicator.Click += new System.EventHandler(this.StrengthIndicator_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.StrengthIndicator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.SignUpLabel);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.AppName);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label AppName;
        private Button SignUpBtn;
        private Label SignUpLabel;
        private Button LoginBtn;
        private Label label1;
        private Label StrengthIndicator;
    }
}