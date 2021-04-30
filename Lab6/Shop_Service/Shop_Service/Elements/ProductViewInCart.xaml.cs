using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
//using System.Windows.Controls;
using Shop_Service.ProductCommand;

namespace Shop_Service.Elements
{
    public partial class ProductViewInCart //: UserControl
    {
        private static readonly RoutedEvent MouseDownEvents;
        // private static readonly RoutedEvent ClickTunnelEvents;
        // private static readonly RoutedEvent ClickBubbleEvents;
        public static readonly DependencyProperty NameTextBlockTextProperty;
        public static readonly DependencyProperty DescriptionTextBlockTextProperty;
        public static readonly DependencyProperty PriceTextBlockTextProperty;
        public static readonly DependencyProperty RatingTextBlockTextProperty;
        private Invoker invoker;

       static ProductViewInCart()
        {
            var priceValueCheck = new ValidateValueCallback(ValidatePriceValue);
            var ratingValueCheck = new ValidateValueCallback(ValidateRatingValue);
            NameTextBlockTextProperty = DependencyProperty.Register("NameTextBlockText", typeof(string),
                typeof(ProductViewInCart), new UIPropertyMetadata(""));
            DescriptionTextBlockTextProperty = DependencyProperty.Register("DescriptionTextBlockText",
                typeof(string), typeof(ProductViewInCart), new UIPropertyMetadata(""));
            PriceTextBlockTextProperty = DependencyProperty.Register("PriceTextBlockText",
                typeof(int), typeof(AddProduct), new UIPropertyMetadata(0), priceValueCheck);
            RatingTextBlockTextProperty = DependencyProperty.Register("RatingTextBlockText",
                typeof(int), typeof(AddProduct), new UIPropertyMetadata(0), ratingValueCheck);
            
            MouseDownEvents = EventManager.RegisterRoutedEvent("MouseDownEventHandler", 
                RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(ProductViewInCart));
            // ClickTunnelEvents = EventManager.RegisterRoutedEvent("ClickTunnelHandler", 
            //     RoutingStrategy.Tunnel, typeof(RoutedEventHandler), typeof(ProductViewInCart));
            // ClickBubbleEvents = EventManager.RegisterRoutedEvent("ClickBubbleHandler", 
            //     RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(ProductViewInCart));
        }
       public event RoutedEventHandler MouseDownEventHandler
       {
           add => AddHandler(MouseDownEvents, value);
           remove => RemoveHandler(MouseDownEvents, value);
       }
       // public event RoutedEventHandler ClickTunnelHandler
       // {
       //     add => AddHandler(ClickTunnelEvents, value);
       //     remove => RemoveHandler(ClickTunnelEvents, value);
       // }
       // public event RoutedEventHandler ClickBubbleHandler
       // {
       //     add => AddHandler(ClickBubbleEvents, value);
       //     remove => RemoveHandler(ClickBubbleEvents, value);
       // }
        private static bool ValidatePriceValue(object value)
        {
            var currentValue = (int)value;
            return currentValue is >= 0 and <= short.MaxValue;
        }
        private static bool ValidateRatingValue(object value)
        {
            var currentValue = (int)value;
            return currentValue is >= 0 and <= 5;
        }
        public string NameTextBlockText
        {
            get => (string)GetValue(NameTextBlockTextProperty);
            set => SetValue(NameTextBlockTextProperty, value);
        }
        public string DescriptionTextBlockText
        {
            get => (string)GetValue(DescriptionTextBlockTextProperty);
            set => SetValue(DescriptionTextBlockTextProperty, value);
        }
        public int PriceTextBlockText
        {
            get => (int)GetValue(PriceTextBlockTextProperty);
            set => SetValue(PriceTextBlockTextProperty, value);
        }
        public int RatingTextBlockText
        {
            get => (int)GetValue(RatingTextBlockTextProperty);
            set => SetValue(RatingTextBlockTextProperty, value);
        }
        public ProductViewInCart()
        {
            InitializeComponent();
            DataContext = this;
            Save.AddHandler(ButtonBase.ClickEvent, new RoutedEventHandler(Save_OnMouseDown));
            //ButtonIn.AddHandler(ButtonBase.ClickEvent, new RoutedEventHandler(ButtonIn_OnMouseDown));
           // Button.AddHandler(ClickTunnelEvents, new RoutedEventHandler(Button_OnMouseDown));
        }
        private void Save_OnMouseDown(object sender, RoutedEventArgs e)
        {
            invoker ??= new Invoker();
            var productFactory = new ProductFactory.ProductFactory();
            var product = productFactory.CreateSmartPhoneOrTablet(
                NameTextBlockText, PriceTextBlockText,
                RatingTextBlockText, DescriptionTextBlockText);
            var command = new AddCommand(product);
            invoker.SetCommand(command);
            invoker.Run();
        }
        private void Button_OnMouseDown(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("sender: " + sender + "\n"+ "source: " + e.Source + "\n\n");
        }

        public void Exit_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        public void Exit_Executed(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
    public class MyCommands
    {
        private static readonly RoutedUICommand exit = new RoutedUICommand("Exit", "Exit", typeof(ProductViewInCart),
            new InputGestureCollection() {new KeyGesture(Key.Escape)});

        public static RoutedUICommand Exit => exit;
    }
    
}