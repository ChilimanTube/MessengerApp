using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
            CreateUser(connection, usernameTextBox.Text, passwordTextBox.Text);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e){
}

        static void CreateUser(SqlConnection connection, string username, string password)
        {
            string query = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password);";

            using (SqlCommand command = new SqlCommand(query, connection))
            {  

                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("User created successfully.");
                }
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
