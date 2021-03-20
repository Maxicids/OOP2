using System.Windows;
using System.Windows.Input;

namespace Shop_Service
{
    /// <summary>
    /// Interaction logic for LogInWindow.xaml
    /// </summary>
    public partial class LogInWindow
    {
        public LogInWindow()
        {
            InitializeComponent();
        }

        private void ButtonOff_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void LoginWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {

                DragMove();
        }

        private void ToRegistration(object sender, MouseButtonEventArgs e)
        {
            Hide();
            var registrationWindow = new RegistrationWindow {Top = Top, Left = Left};
            registrationWindow.Show();
        }

        private void Login(object sender, MouseButtonEventArgs e)
        {
            Hide();
            var mainWindow = new MainWindow {Top = Top, Left = Left};
            mainWindow.Show();
        }
    }
}
