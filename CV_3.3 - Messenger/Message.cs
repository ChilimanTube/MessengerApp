using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_3._3___Messenger
{
    public class Message
    {
        //this class was just a test, it will be most likely deleted!

        SqlConnection connection = DatabaseCon.GetInstance();
        
        public int id { get; set; }
        public string sender { get; set; }
        public string recipient { get; set; }
        public string message { get; set; }
        public string date { get; set; }

        
        public int GetSentMessageID()
        {
            string query = "SELECT MessageID FROM Messages WHERE SenderID = @SenderID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@SenderID", Login.username);
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        id = (int)dataReader["MessageID"];
                    }
                }
                return id;
            }
        }
    }
}
