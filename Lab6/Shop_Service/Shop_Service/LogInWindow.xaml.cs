using System;

using System.Windows;

using System.Windows.Input;
using System.Windows.Interop;

namespace Shop_Service
{
    /// <summary>
    /// Interaction logic for LogInWindow.xaml
    /// </summary>
    public partial class LogInWindow : Window
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
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Top = Top;
            registrationWindow.Left = Left;
            registrationWindow.Show();
        }
    }
}
