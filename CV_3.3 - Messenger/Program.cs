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
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}