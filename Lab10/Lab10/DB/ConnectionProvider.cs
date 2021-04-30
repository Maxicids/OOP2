using System.Data.SqlClient;
using System.Configuration;

namespace Lab10.DB
{
    public class ConnectionProvider
    {
        private SqlConnection connection;
        private static ConnectionProvider instance;
        private static readonly object Locker = new object();

        private ConnectionProvider() {}
        public SqlConnection GetConnection()
        {
            return connection ?? (connection =
                new SqlConnection(ConfigurationManager.ConnectionStrings["MessengerContext"].ConnectionString));
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
