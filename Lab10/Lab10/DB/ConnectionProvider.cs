using System.Data.SqlClient;
using System.Configuration;

namespace Lab10.DB
{
    public class ConnectionProvider
    {
        private SqlConnection connection;

        public SqlConnection GetConnection()
        {
            return connection ?? (connection =
                new SqlConnection(ConfigurationManager.ConnectionStrings["MessengerContext"].ConnectionString));
        }
    }
}
