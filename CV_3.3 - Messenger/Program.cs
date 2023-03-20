using System;
using System.Data.SqlClient;

namespace CV_3._3___Messenger
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CorporateMessengerApp;Integrated Security=True";
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();

        //        // Create a new user
        //        CreateUser(connection, "johndoe", "password123");

        //        // Create a new message
        //        CreateMessage(connection, "johndoe", "janedoe", "Hello!", "How are you?");

        //        // Retrieve all messages for a user
        //        GetMessageList(connection, "janedoe");

        //        // Delete a message
        //        DeleteMessage(connection, 1);
        //    }

        //    Console.WriteLine("Press any key to exit...");
        //    Console.ReadKey();
        //}

        //static void CreateUser(SqlConnection connection, string username, string password)
        //{
        //    string query = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password);";

        //    using (SqlCommand command = new SqlCommand(query, connection))
        //    {
        //        command.Parameters.AddWithValue("@Username", username);
        //        command.Parameters.AddWithValue("@Password", password);

        //        int result = command.ExecuteNonQuery();
        //        if (result > 0)
        //        {
        //            Console.WriteLine("User created successfully.");
        //        }
        //    }
        //}

        //static void CreateMessage(SqlConnection connection, string sender, string recipient, string subject, string messageText)
        //{
        //    string query = "INSERT INTO Messages (SenderId, RecipientId, Subject, MessageText, DateSent) " +
        //        "VALUES ((SELECT UserId FROM Users WHERE Username = @Sender), (SELECT UserId FROM Users WHERE Username = @Recipient), @Subject, @MessageText, @DateSent);";

        //    using (SqlCommand command = new SqlCommand(query, connection))
        //    {
        //        command.Parameters.AddWithValue("@Sender", sender);
        //        command.Parameters.AddWithValue("@Recipient", recipient);
        //        command.Parameters.AddWithValue("@Subject", subject);
        //        command.Parameters.AddWithValue("@MessageText", messageText);
        //        command.Parameters.AddWithValue("@DateSent", DateTime.Now);

        //        int result = command.ExecuteNonQuery();
        //        if (result > 0)
        //        {
        //            Console.WriteLine("Message sent successfully.");
        //        }
        //    }
        //}

        //static void GetMessageList(SqlConnection connection, string username)
        //{
        //    string query = "SELECT * FROM Messages WHERE RecipientId = (SELECT UserId FROM Users WHERE Username = @Username) OR SenderId = (SELECT UserId FROM Users WHERE Username = @Username);";

        //    using (SqlCommand command = new SqlCommand(query, connection))
        //    {
        //        command.Parameters.AddWithValue("@Username", username);

        //        SqlDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            Console.WriteLine("MessageId: {0}, SenderId: {1}, RecipientId: {2}, Subject: {3}, MessageText: {4}, DateSent: {5}, IsDeleted: {6}",
        //                reader["MessageId"], reader["SenderId"], reader["RecipientId"], reader["Subject"], reader["MessageText"], reader["DateSent"], reader["IsDeleted"]);
        //        }
        //    }
        //}

        //static void DeleteMessage(SqlConnection connection, int messageId)
        //{
        //    string query = "UPDATE Messages SET IsDeleted = 1 WHERE MessageId = @MessageId;";

        //    using (SqlCommand command = new SqlCommand(query, connection))
        //    {
        //        command.Parameters.AddWithValue("@MessageId", messageId);

        //        int result = command.ExecuteNonQuery();
        //        if (result > 0)
        //        {
        //            Console.WriteLine("Message deleted successfully.");
        //        }
        //    }
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}