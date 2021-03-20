using System.Windows;
using System.Windows.Input;

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
            Hide();
            var mainWindow = new MainWindow {Top = Top, Left = Left};
            mainWindow.Show();
        }
    }
}