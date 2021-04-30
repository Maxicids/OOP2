using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using Lab10.DB;

namespace Lab10
{
    public partial class MainWindow
    {
        private readonly SqlConnection connection;
        public MainWindow()
        {
            InitializeComponent();
            var connectionProvider = ConnectionProvider.GetInstance();
            connection = connectionProvider.GetConnection();
            connection.Open();
            Connect_OnClick(this, new RoutedEventArgs());
        }

        public void Connect_OnClick(object sender, RoutedEventArgs e)
        {
            const string cmd = "select * from Users";
            var createCommand = new SqlCommand(cmd, connection);
            createCommand.ExecuteNonQuery();
            
            var dataAdp = new SqlDataAdapter(createCommand);
            var dt = new DataTable("Users");
            dataAdp.Fill(dt);
            Users.ItemsSource = dt.DefaultView; 
        }

        private void Add_OnClick(object sender, RoutedEventArgs e)
        {
            var locationFromScreen = PointToScreen(new Point(0, 0));
            var addProduct = new AddWindow(this) {Top = locationFromScreen.Y + 20, 
                Left = locationFromScreen.X - 10, Topmost = true};
            
            addProduct.Show();
        }
        private void Update_OnClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void Delete_OnClick(object sender, RoutedEventArgs e)
        {
            if (!(Users.Columns[0].GetCellContent(Users.Items[Users.SelectedIndex]) is TextBlock textBlock)) return;
            var cmd = $"delete from Users where id = {textBlock.Text}";
            var command = new SqlCommand(cmd, connection);
            command.ExecuteNonQuery();
            Connect_OnClick(this, new RoutedEventArgs());
        }

        private void Left_OnClick(object sender, RoutedEventArgs e)
        {
            Users.SelectedIndex--;
        }
    }
}