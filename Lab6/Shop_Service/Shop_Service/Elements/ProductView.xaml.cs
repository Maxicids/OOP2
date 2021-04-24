using System.Windows;
using System.Windows.Input;
using MaterialDesignThemes.Wpf;
using Shop_Service.ProductCommand;
using Shop_Service.ProductFactory;

namespace Shop_Service.Elements
{
    public partial class ProductView
    {
        private Invoker invoker;
        private Product inspectedProduct;
        public ProductView(Product product)
        {
            InitializeComponent();
            inspectedProduct = product;
            ShowInspectedProduct();
        }

        private void ShowInspectedProduct()
        {
            Header.Text = inspectedProduct.Name;
            Description.Text = "\t" + inspectedProduct.Description;
            Price.Text = "Price: " + inspectedProduct.Price.ToString();
        }

        private void AddToCart_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            CartIcon.Kind = CartIcon.Kind == PackIconKind.CartAdd ? PackIconKind.Check : PackIconKind.CartAdd;
        }

        private void RemoveIcon_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            // invoker ??= new Invoker();
            // var command = new RemoveCommand(inspectedProduct);
            // invoker.SetCommand(command);
            // invoker.Run();
        }

        private void EditButton_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            foreach (Window window in Application.Current.Windows) window.IsEnabled = false;
            var locationFromScreen = this.EditButton.PointToScreen(new Point(0, 0));
            var editProduct = new EditProduct(inspectedProduct) {Top = locationFromScreen.Y + 20, 
                Left = locationFromScreen.X - 400, Topmost = true};
            
            editProduct.Show();
        }
    }
}