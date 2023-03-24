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
                                Text = "To: " + dataReader[5].ToString(),
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
                            deleteBtn.Click += new EventHandler(DeleteButton_Click);
                            
                            messagePanel.Controls.Add(deleteBtn);

                            // Add the message panel to the message list
                            MessageList.Controls.Add(messagePanel);
                        }
                    }
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            object messageID = btn.Tag.ToString();
            Control messagePanel = btn.Parent;

            string query = "UPDATE Messages SET IsDeleted = 1 WHERE MessageID = @Id";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", messageID);
                command.ExecuteNonQuery();

                MessageList.Controls.Remove(messagePanel);
            }
        }

        private void ReceivedMsgs_Load(object sender, EventArgs e)
        {
            LoadRecievedMessagesPanel();
        }
    }
}
