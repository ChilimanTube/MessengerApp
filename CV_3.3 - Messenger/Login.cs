using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CV_3._3___Messenger
{
    public partial class Login : Form
    {
        SqlConnection connection = DatabaseCon.GetInstance();
        public Login()
        {
            InitializeComponent();
        }

        private void SignUpLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // SQL query to check if the user exists
            string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Set the parameters for the query
                command.Parameters.AddWithValue("@username", usernameTextBox.Text);
                command.Parameters.AddWithValue("@password", passwordTextBox.Text);

                // Execute the query and get the result
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    Home home = new Home();
                    home.Show();
                }
                else
                {
                    // Display an error message if the user doesn't exist
                    MessageBox.Show("Invalid username or password");
                }
            }
        }

        private void AppName_Click(object sender, EventArgs e)
        {

        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }
    }
}
