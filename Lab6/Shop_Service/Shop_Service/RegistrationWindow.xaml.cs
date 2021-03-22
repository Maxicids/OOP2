using System.Windows;
using System.Windows.Input;
using Shop_Service.Roles;

namespace Shop_Service
{
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegistrationWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ButtonClose_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Register(object sender, MouseButtonEventArgs e)
        {
            if (TbPassword.Password.Equals(TbRepeatPassword.Password))
            {
                var users = Users.GetInstance();
                users.Add(new User(TbLogin.Text, TbPassword.Password));
                users.Serialize();
                Hide();
                var mainWindow = new MainWindow {Top = Top, Left = Left};
                mainWindow.Show();
            }
            else
            {
                //error
            }
        }

        private void ToLogin(object sender, MouseButtonEventArgs e)
        {
            Hide();
            var logInWindow = new LogInWindow() {Top = Top, Left = Left};
            logInWindow.Show();
        }
    }
}