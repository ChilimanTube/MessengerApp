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

        private void LoadSentMessagesPanel()
        {
            string query = "SELECT message.Subject, message.Text, message.SendDateTime, useros.Username, message.RecipientID, message.IsDeleted," +
                " message.MessageID FROM Messages message JOIN Users useros ON message.SenderID = useros.UserID" +
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
                            Panel messagePanel = new Panel();
                            messagePanel.BorderStyle = BorderStyle.FixedSingle;
                            messagePanel.Margin = new Padding(5);
                            messagePanel.Padding = new Padding(5);
                            messagePanel.AutoSize = true;
                            messagePanel.Dock = DockStyle.Top;

                            Label subjectLabel = new Label();
                            subjectLabel.Text = "Subject: " + dataReader[0].ToString();
                            subjectLabel.AutoSize = true;
                            subjectLabel.Dock = DockStyle.Top;
                            messagePanel.Controls.Add(subjectLabel);

                            Label senderLabel = new Label();
                            senderLabel.Text = "To: " + dataReader[5].ToString();
                            senderLabel.AutoSize = true;
                            senderLabel.Dock = DockStyle.Top;
                            senderLabel.Padding = new Padding(0, 10, 0, 0);
                            messagePanel.Controls.Add(senderLabel);

                            Label sentLabel = new Label();
                            sentLabel.Text = "Sent: " + dataReader[2].ToString();
                            sentLabel.AutoSize = true;
                            sentLabel.Dock = DockStyle.Top;
                            sentLabel.Padding = new Padding(0, 10, 0, 0);
                            messagePanel.Controls.Add(sentLabel);

                            Label messageLabel = new Label();
                            messageLabel.Text = "Text:" + dataReader[1].ToString();
                            messageLabel.AutoSize = true;
                            messageLabel.Dock = DockStyle.Bottom;
                            messagePanel.Controls.Add(messageLabel);

                            Button deleteBtn = new Button();
                            deleteBtn.Text = "Delete";
                            deleteBtn.Tag = dataReader[6];
                            deleteBtn.BackColor = Color.Red;
                            deleteBtn.ForeColor = Color.White;
                            deleteBtn.Font = new Font(deleteBtn.Font, FontStyle.Bold);
                            deleteBtn.AutoSize = true;
                            deleteBtn.Dock = DockStyle.Right;
                            deleteBtn.Click += new EventHandler(DeleteButton_Click);
                            messagePanel.Controls.Add(deleteBtn);

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
    }
}
