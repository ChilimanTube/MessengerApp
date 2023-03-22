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
            string query = "SELECT message.Subject, message.Text, message.SendDateTime, user.Username, message.RecipientID, message.IsDeleted, message.MessageID FROM Messages message JOIN Users user ON message.UserID = user.UserID WHERE message.UserID = @UserID ORDER BY message.SendDateTime DESC";
            
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserID", Login.id);
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        int isDeleted = dataReader.GetInt32(5);

                        if (isDeleted == 0)
                        {



                            //Panel message = new Panel();
                            //message.AutoSize = true;

                            //Label recipient = new Label();
                            //recipient.Text = "Recipient: " + dataReader["recipient"].ToString();

                            //message.Controls.Add(recipient);

                            //MessageList.Controls.Add(message);

                            // Create a new panel for the message
                            Panel messagePanel = new Panel();
                            messagePanel.BorderStyle = BorderStyle.FixedSingle;
                            messagePanel.Margin = new Padding(5);
                            messagePanel.Padding = new Padding(5);
                            messagePanel.AutoSize = true;
                            messagePanel.Dock = DockStyle.Top;

                            // Create a label for the message subject
                            Label subjectLabel = new Label();
                            subjectLabel.Text = "Subject: " + dataReader[0].ToString();
                            subjectLabel.AutoSize = true;
                            subjectLabel.Dock = DockStyle.Top;
                            messagePanel.Controls.Add(subjectLabel);

                            // Create a label for the the sender
                            Label senderLabel = new Label();
                            senderLabel.Text = "To: " + dataReader[4].ToString();
                            senderLabel.AutoSize = true;
                            senderLabel.Dock = DockStyle.Top;
                            senderLabel.Padding = new Padding(0, 10, 0, 0);
                            messagePanel.Controls.Add(senderLabel);

                            // Create a label for the message sent at
                            Label sentLabel = new Label();
                            sentLabel.Text = "Sent: " + dataReader[2].ToString();
                            sentLabel.AutoSize = true;
                            sentLabel.Dock = DockStyle.Top;
                            sentLabel.Padding = new Padding(0, 10, 0, 0);
                            messagePanel.Controls.Add(sentLabel);

                            // Create a label for the message text
                            Label messageLabel = new Label();
                            messageLabel.Text = "Text:" + dataReader[1].ToString();
                            messageLabel.AutoSize = true;
                            messageLabel.Dock = DockStyle.Bottom;
                            messagePanel.Controls.Add(messageLabel);

                            //Create delete button for the message
                            Button deleteButton = new Button();
                            deleteButton.Text = "Delete";
                            deleteButton.Tag = dataReader[6];
                            deleteButton.BackColor = Color.Red;
                            deleteButton.ForeColor = Color.White;
                            deleteButton.Font = new Font(deleteButton.Font, FontStyle.Bold);
                            deleteButton.AutoSize = true;
                            deleteButton.Dock = DockStyle.Right;
                            deleteButton.Click += new EventHandler(DeleteMsg_Click);
                            messagePanel.Controls.Add(deleteButton);


                            // Add the message panel to the FlowLayoutPanel*/
                            MessageList.Controls.Add(messagePanel);
                        }
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

        private void SentMsgs_Load(object sender, EventArgs e)
        {
            LoadSentMessagesPanel();
        }

        
    }
}
