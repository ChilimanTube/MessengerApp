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
    public partial class ReceivedMsgs : Form
    {
        public ReceivedMsgs()
        {
            InitializeComponent();
        }

        SqlConnection connection = DatabaseCon.GetInstance();

        private Button selectedMessageID;
        private void LoadRecievedMessagesPanel()
        {
            string query = "SELECT message.Subject, message.Text, message.SendDateTime, useros.Username, message.SenderID, message.IsDeleted," +
                " message.MessageID FROM Messages message JOIN Users useros ON message.RecipientID = useros.UserID" +
                " WHERE message.SenderID = @UserID ORDER BY message.SendDateTime DESC";

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
                            // Create and configure the panel
                            Panel messagePanel = new Panel
                            {
                                BorderStyle = BorderStyle.FixedSingle,
                                Margin = new Padding(5),
                                Padding = new Padding(5),
                                AutoSize = true,
                                Dock = DockStyle.Top
                            };

                            // Create and configure the labels
                            Label subjectLabel = new Label
                            {
                                Text = "Subject: " + dataReader[0].ToString(),
                                AutoSize = true,
                                Dock = DockStyle.Top
                            };

                            Label senderLabel = new Label
                            {
                                Text = "SenderID: " + dataReader[5].ToString(),
                                AutoSize = true,
                                Dock = DockStyle.Top,
                                Padding = new Padding(0, 10, 0, 0)
                            };

                            Label sentLabel = new Label
                            {
                                Text = "Sent: " + dataReader[2].ToString(),
                                AutoSize = true,
                                Dock = DockStyle.Top,
                                Padding = new Padding(0, 10, 0, 0)
                            };

                            Label messageLabel = new Label
                            {
                                Text = "Text:" + dataReader[1].ToString(),
                                AutoSize = true,
                                Dock = DockStyle.Bottom
                            };

                            // Add the labels to the panel
                            messagePanel.Controls.Add(subjectLabel);
                            messagePanel.Controls.Add(senderLabel);
                            messagePanel.Controls.Add(sentLabel);
                            messagePanel.Controls.Add(messageLabel);


                            // Create and configure the delete button
                            Button deleteBtn = new Button
                            {
                                Text = "Delete",
                                Tag = dataReader[6],
                                BackColor = Color.Red,
                                ForeColor = Color.White,
                                Font = new Font(Font, FontStyle.Bold),
                                AutoSize = true,
                                Dock = DockStyle.Right
                            };
                            deleteBtn.Click += new EventHandler(DelButton_Click);

                            Button viewBtn = new Button
                            {
                                Text = "View",
                                Tag = dataReader[6],
                                BackColor = Color.Green,
                                ForeColor = Color.White,
                                Font = new Font(Font, FontStyle.Bold),
                                AutoSize = true,
                                Anchor = AnchorStyles.Right | AnchorStyles.Top,
                                Padding = new Padding(0, 0, 10, 0)
                            };


                            viewBtn.Click += new EventHandler(ViewMessageBtn_Click);

                            messagePanel.Controls.Add(deleteBtn);
                            messagePanel.Controls.Add(viewBtn);

                            // Add the message panel to the message list
                            MessageList.Controls.Add(messagePanel);
                        }
                    }
                }
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            object messageID = btn.Tag.ToString();
            Control messagePanel = btn.Parent;

            // SQL query to delete the message
            string query = "UPDATE Messages SET IsDeleted = 1 WHERE MessageID = @Id";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Set the parameters for the query
                command.Parameters.AddWithValue("@id", messageID);
                command.ExecuteNonQuery();

                MessageList.Controls.Remove(messagePanel);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DelButton_Click(selectedMessageID, e);
        }

        private void ViewMessageBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            object messageID = btn.Tag.ToString();
            selectedMessageID = btn;

            // SQL query to delete the message
            string query = "SELECT Text, Subject, SenderID FROM Messages WHERE MessageID = @Id";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                int SenderID = 0;
                // Set the parameters for the query
                command.Parameters.AddWithValue("@id", messageID);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MessageView.Text = reader[0].ToString();
                        SubjectTextBox.Text = reader[1].ToString();
                        SenderID = reader.GetInt32(2);
                    }
                }

                string query2 = "SELECT Username FROM Users WHERE UserID = @UserID;";
                using (SqlCommand command2 = new SqlCommand(query2, connection))
                {
                    command2.Parameters.AddWithValue("@UserID", SenderID);
                    using (SqlDataReader dataReader = command2.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            SenderTextBox.Text = (string)dataReader["Username"];
                        }
                    }
                }
            }
        }

        private void ReceivedMsgs_Load(object sender, EventArgs e)
        {
            LoadRecievedMessagesPanel();
        }
    }
}
