using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_3._3___Messenger
{
    public partial class SignUp : Form
    {
        SqlConnection connection = DatabaseCon.GetInstance();
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUpLabel_Click(object sender, EventArgs e)
        {

        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (SignUpBtn.Enabled)
            {
                bool success = CreateUser(connection, usernameTextBox.Text, passwordTextBox.Text);
                if (success == true)
                {
                    Login login = new Login();
                    login.Show();
                    this.Close();
                }
            } else
            {
                MessageBox.Show("Password must be have at least medium strength.");
            }
            
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e){
}

        static bool CreateUser(SqlConnection connection, string username, string password)
        {
            string query = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password);"; //fix typo in database

            using (SqlCommand command = new SqlCommand(query, connection))
            {  

                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                
                int result = 0;
                
                try
                {
                    result = command.ExecuteNonQuery();
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    MessageBox.Show("Account named " + username +" already exists.");
                }

                if (result > 0)
                {
                    MessageBox.Show("Account created succesfully");
                    Home.ActiveForm.Show();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            int strength = passwordCheck(passwordTextBox.Text);

            if (strength <= 3)
            {
                StrengthIndicator.Text = "Weak";
                StrengthIndicator.ForeColor = Color.Red;
                StrengthIndicator.Visible = true;
                SignUpBtn.Enabled = false;
            }

            if (strength > 3 && strength <= 4)
            {
                StrengthIndicator.Text = "Medium";
                StrengthIndicator.ForeColor = Color.Yellow;
                StrengthIndicator.Visible = true;
                SignUpBtn.Enabled = true;
            }

            if (strength > 4)
            {
                StrengthIndicator.Text = "Strong";
                StrengthIndicator.ForeColor = Color.Green;
                StrengthIndicator.Visible = true;
                SignUpBtn.Enabled = true;
            }
        }

        private int passwordCheck(string password)
        {
            int passwordStrength = 0;

            string specialSymbolRegex = @"[@!#$%^&*()_+\-=\[\]{};':""\\|,.<>\/?]";
            string numberRegex = @"\d";
            string upperCaseRegex = @"[A-Z]";
            string lowerCaseRegex = @"[a-z]";
            
            Match specialSymbol = Regex.Match(password, specialSymbolRegex);
            Match numbers = Regex.Match(password, numberRegex);
            Match upperCase = Regex.Match(password, upperCaseRegex);
            Match lowerCase = Regex.Match(password, lowerCaseRegex);
            
            
            
            if (specialSymbol.Success)
            {
                passwordStrength++;
            }

            if (numbers.Success)
            {
                passwordStrength++;
            }

            if (upperCase.Success)
            {
                passwordStrength++;
            }

            if (lowerCase.Success)
            {
                passwordStrength++;
            }

            if (password.Length >= 8)
            {
                passwordStrength++;
            }

            if (password.Length >= 12)
            {
                passwordStrength++;
            }

            return passwordStrength;
        }

        private void StrengthIndicator_Click(object sender, EventArgs e)
        {

        }
    }
}

