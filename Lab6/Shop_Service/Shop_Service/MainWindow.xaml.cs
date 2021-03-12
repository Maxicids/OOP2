using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Shop_Service
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonLogOut_OnClick(object sender, RoutedEventArgs e)
        {
            //Application.Current.Shutdown();
        }

        private void ButtonOff_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonMinimize_OnClick(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void MainGrid_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
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
            MoveCursorMenu(0);
        }

        private void Shop_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            MoveCursorMenu(1);
        }

        private void Stores_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            MoveCursorMenu(2);
        }

        private void Cart_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            MoveCursorMenu(3);
        }

        private void About_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            MoveCursorMenu(4);
        }
    }
}