using System.Data.SqlClient;
using System.Windows;
using Lab10.DB;

namespace Lab10
{
    public partial class MainWindow
    {
        private readonly SqlConnection connection;
        
        public MainWindow()
        {
            InitializeComponent();
            var connectionProvider = new ConnectionProvider();
            connection = connectionProvider.GetConnection();
            connection.Open();
        }

        private void Connect_OnClick(object sender, RoutedEventArgs e)
        {
            var getCommand = connection.CreateCommand();
            getCommand.CommandText = "select* from Roles";
            var thisReader = getCommand.ExecuteReader();
            
            while (thisReader.Read())
            {
                Result.Text = thisReader.GetValue(0).ToString() + thisReader.GetValue(1);
            }
            thisReader.Close();
        }
    }
}