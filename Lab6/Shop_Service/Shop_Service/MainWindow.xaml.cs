using System;
using Shop_Service.Roles;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Shop_Service.Elements;

namespace Shop_Service
{ 
    public partial class MainWindow
    {
        private bool isSettingsOpened;
        private bool isEnglish;
        //private Settings settings;
        public MainWindow()
        {
            InitializeComponent();
            isSettingsOpened = false;
            isEnglish = true;

            var user = Users.GetInstance().GetActive();
            TbAccountName.Text = user.ToString();
        }
        private void ButtonLogOut_OnClick(object sender, RoutedEventArgs e)
        {
            Users.GetInstance().Find(TbAccountName.Text).IsActive = false;
            Hide();
            var logInWindow = new LogInWindow() {Top = Top, Left = Left};
            logInWindow.Show();
        }

        private void ButtonOff_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonMinimize_OnClick(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void MainGrid_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
            if (!isSettingsOpened) return;
            //SettingsGrid.Children.Remove(settings);
            isSettingsOpened = false;
        }
        
        private void MoveCursorMenu(int index)
        {
            MenuTransition.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, 100 + 60*index,0,0);
        }
        private void MenuElement_OnMouseEnter(object sender, MouseEventArgs e)
        {
            ((StackPanel) sender).Background = new SolidColorBrush(Colors.LightSteelBlue);
        }

        private void MenuElement_OnMouseLeave(object sender, MouseEventArgs e)
        {
            ((StackPanel) sender).Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#effafc"));
            //GridCursor.
            GridCursor.Background = new SolidColorBrush(Colors.Aqua);
        }

        private void Main_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            ContentGrid.Children.Clear();
            MoveCursorMenu(0);
        }

        private void Shop_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(new Shop());
            MoveCursorMenu(1);
        }

        private void Stores_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(new ObservCards());
            MoveCursorMenu(2);
        }

        private void Cart_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            ContentGrid.Children.Clear();
            MoveCursorMenu(3);
        }

        private void About_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            ContentGrid.Children.Clear();
            MoveCursorMenu(4);
        }

        private void ButtonSettings_OnClick(object sender, RoutedEventArgs e)
        {
            if (isEnglish)
            {
                Resources.MergedDictionaries.Clear();
                Resources.MergedDictionaries.Add (new ResourceDictionary()
                {
                    Source = new Uri(
                        @"D:\Epam\OOP\Repositories\OOP2\OOP2\Lab6\Shop_Service\Shop_Service\Properties\Langs\language.ru-RU.xaml")
                });
                isEnglish = false;
            }
            else
            {
                Resources.MergedDictionaries.Clear();
                Resources.MergedDictionaries.Add (new ResourceDictionary()
                {
                    Source = new Uri(
                        @"D:\Epam\OOP\Repositories\OOP2\OOP2\Lab6\Shop_Service\Shop_Service\Properties\Langs\language.en.xaml")
                });
                isEnglish = true;
            }
            
        }
    }
}