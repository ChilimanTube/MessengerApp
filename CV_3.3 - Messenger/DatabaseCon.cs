using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_3._3___Messenger
{
    public class DatabaseCon
    {
        private static SqlConnection connection = null;
        private DatabaseCon(){}
        public static SqlConnection GetInstance()
        {
            if (connection == null)
            {
                SqlConnectionStringBuilder consStringBuilder = new SqlConnectionStringBuilder();
                consStringBuilder.DataSource = ReadSetting("DataSource");
                consStringBuilder.IntegratedSecurity = bool.Parse(ReadSetting("IntergratedSecurity"));
                consStringBuilder.InitialCatalog = ReadSetting("InitialCatalog");
                connection = new SqlConnection(consStringBuilder.ConnectionString);
                connection.Open();
            }
            return connection;
        }

        public static void CloseConnection()
        {
            try
            {
                if (connection != null){connection.Close(); connection.Dispose();}
            }
            catch {}
            finally{connection = null;}
        }

        private static string ReadSetting(string key)
        {
            var appSettings = ConfigurationManager.AppSettings;
            string result = appSettings[key] ?? "Not Found";
            return result;
        }
    }
}