using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.Configuration;
using System.IO;
using Microsoft.Data.SqlClient;
using System;

namespace Lab10.DB
{
    public class ConnectionProvider
    {
        private SqlConnection connection;
        private static ConnectionProvider instance;
        private static readonly object Locker = new object();
        private const string QueryPath = @"D:\Epam\OOP\Repositories\Messenger\Database\SQLQuery1.sql";

        private ConnectionProvider() {}
        public SqlConnection GetConnection()
        {
            if (connection != null) return connection;
            try
            {
                connection =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["MessengerContext"].ConnectionString);
                connection.Open();
            }
            catch(Exception e)
            {
                connection =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["ServerContext"].ConnectionString);
                connection.Open();
                ExecuteScriptFile(QueryPath);
            }
            return connection;
        }
        private void ExecuteScriptFile(string scriptFile)
        {
            var script = File.ReadAllText(Path.GetFullPath(QueryPath));
            Server server = new Server(new ServerConnection(connection));
            server.ConnectionContext.ExecuteNonQuery(script);
        }

        public static ConnectionProvider GetInstance()
        {
            lock (Locker)
            {
                if (instance == null)
                {
                    instance = new ConnectionProvider();
                }
            }
            return instance;
        }
    }
}
