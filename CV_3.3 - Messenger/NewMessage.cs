using System.Data.SqlClient;

namespace CV_3._3___Messenger
{
    public partial class NewMessage : Form
    {
        public NewMessage()
        {
            InitializeComponent();
        }

        SqlConnection connection = DatabaseCon.GetInstance();

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewMessage_Load(object sender, EventArgs e)
        {

        }

        private void RecipientTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubjectTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            int recipientID = 0;
            string query = "INSERT INTO Messages (RecipientID, SenderID, Subject, Text) VALUES (@RecipientID, @SenderID, @Subject, @MessageText);";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                string query2 = "SELECT UserID FROM Users WHERE Username = @Username;";
                using (SqlCommand command2 = new SqlCommand(query2, connection))
                {
                    command2.Parameters.AddWithValue("@Username", RecipientTextBox.Text);
                    using (SqlDataReader dataReader = command2.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            recipientID = (int)dataReader["UserID"];
                        }
                    }
                }

                command.Parameters.AddWithValue("@RecipientID", recipientID);
                command.Parameters.AddWithValue("@SenderID", Login.id);
                command.Parameters.AddWithValue("@Subject", SubjectTextBox.Text);
                command.Parameters.AddWithValue("@MessageText", MessageTextBox.Text);

                MessageBox.Show("Message sent.");
                this.Close();
            }
        }
    }
}