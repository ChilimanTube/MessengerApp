using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_3._3___Messenger
{
    public partial class SentMsgs : Form
    {
        SqlConnection connection = DatabaseCon.GetInstance();
        public SentMsgs()
        {
            InitializeComponent();
        }

        private void LoadSentMessagesPanel()
        {
            string query = "SELECT message.Subject, message.Text, message.SendDateTime, user.Username, message.Recipient, message.IsDeleted, message.MessageID FROM Messages message JOIN Users user ON message.UserID = user.UserID WHERE message.UserID = @User ORDER BY message.SendDateTime DESC";
            
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@User", Login.id);
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Panel message = new Panel();
                        message.AutoSize = true;

                        Label recipient = new Label();
                        recipient.Text = "Recipient: " + dataReader["recipient"].ToString();

                        message.Controls.Add(recipient);

                        MessageList.Controls.Add(message);
                    }
                }
            }                        
        }

        private void DeleteMsg_Click(object sender, EventArgs e)
        {
            
            // SQL query to delete the message
            string query = "DELETE FROM messages WHERE id = @id";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Set the parameters for the query
                //command.Parameters.AddWithValue("@id", idTextBox.Text);

                // Execute the query and get the result
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Message deleted");
                }
                else
                {
                    // Display an error message if the message doesn't exist
                    MessageBox.Show("Message doesn't exist");
                }
            }
        }
    }
}
