using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Data.SqlClient;
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
            
            for (var i = 0; i < Users.Items.Count - 1; i++)
            {
                var transaction = connection.BeginTransaction();
                var command = connection.CreateCommand();
                command.Transaction = transaction;
                
                var id = Convert.ToInt32((Users.Columns[0].GetCellContent(Users.Items[i]) as TextBlock)?.Text);
                var loginUpdate = $"update Users set login = '{(Users.Columns[1].GetCellContent(Users.Items[i]) as TextBlock)?.Text}' where id = {id} ";
                var passwordUpdate = $"update Users set password = '{(Users.Columns[2].GetCellContent(Users.Items[i]) as TextBlock)?.Text}' where id = {id} ";
                var descriptionUpdate = $"update Users set description = '{(Users.Columns[4].GetCellContent(Users.Items[i]) as TextBlock)?.Text}' where id = {id} ";
                try
                {
                    command.CommandText = loginUpdate;
                    command.ExecuteNonQuery();
                    command.CommandText = passwordUpdate;
                    command.ExecuteNonQuery();
                    command.CommandText = descriptionUpdate;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch(Exception exception)
                {
                    transaction.Rollback();
                }
            }
        }

        private void Delete_OnClick(object sender, RoutedEventArgs e)
        {
            if (!(Users.Columns[0].GetCellContent(Users.Items[Users.SelectedIndex]) is TextBlock textBlock)) return;
            var cmd = $"delete from Users where id = {textBlock.Text}";
            var command = new SqlCommand(cmd, connection);
            command.ExecuteNonQuery();
            Connect_OnClick(this, new RoutedEventArgs());
        }

        // private void Left_OnClick(object sender, RoutedEventArgs e)
        // {
        //     //Users.SelectedIndex--;
        // }
    }
}