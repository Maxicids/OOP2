using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Shop_Service.ProductCommand;
using Shop_Service.ProductFactory;

namespace Shop_Service.Elements
{
    public partial class Shop
    {
        private Invoker invoker;
        
        public Shop()
        {
            InitializeComponent();
            ShowProducts();           
        }
        private void ShowProducts()
        {
            ProductList.Children.Clear();
            var productList = ProductFactory.ProductList.GetInstance();
            var products = productList.GetProductsList();
            foreach (var product in products)
            {
                ProductList.Children.Add(new ProductView(product));
            }
        }

        private void Order_OnSelected(object sender, RoutedEventArgs e)
        {
            invoker ??= new Invoker();
            switch (OrderSelector.SelectedIndex)
            {
                case 0:
                {
                    var command = new SortByPopularityCommand();
                    invoker.SetCommand(command);
                    break;
                }
                case 1:
                {
                    var command = new CheapFirstCommand();
                    invoker.SetCommand(command);
                    break;
                }
                case 2:
                {
                    var command = new ExpensiveFirstCommand();
                    invoker.SetCommand(command);
                    break;
                }
            }
            invoker.Run();
            ShowProducts();
        }

        private void AddProduct_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            foreach (Window window in Application.Current.Windows) window.IsEnabled = false;
            var locationFromScreen = this.AddIcon.PointToScreen(new Point(0, 0));
            var addProduct = new AddProduct {Top = locationFromScreen.Y + 20, 
                Left = locationFromScreen.X - 10, Topmost = true};
            
            addProduct.Show();
        }

        private void Category_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (CategorySelector.SelectedIndex)
            {
                case 0:
                {
                    ShowProducts();
                    break;
                }
                case 1:
                {
                    ProductList.Children.Clear();
                    var productList = ProductFactory.ProductList.GetInstance();
                    var products = productList.GetProductsList();
                    foreach (var product in products)
                    {
                        if (product is SmartPhoneOrTablet)
                        {
                            ProductList.Children.Add(new ProductView(product));
                        }
                    }
                    break;
                }
                case 2:
                {
                    ProductList.Children.Clear();
                    var productList = ProductFactory.ProductList.GetInstance();
                    var products = productList.GetProductsList();
                    foreach (var product in products)
                    {
                        if (product is Laptop)
                        {
                            ProductList.Children.Add(new ProductView(product));
                        }
                    }
                    break;
                }
                case 3:
                {
                    ProductList.Children.Clear();
                    var productList = ProductFactory.ProductList.GetInstance();
                    var products = productList.GetProductsList();
                    foreach (var product in products)
                    {
                        if (product is Pc)
                        {
                            ProductList.Children.Add(new ProductView(product));
                        }
                    }
                    break;
                }
                case 4:
                {
                    ProductList.Children.Clear();
                    var productList = ProductFactory.ProductList.GetInstance();
                    var products = productList.GetProductsList();
                    foreach (var product in products)
                    {
                        if (product is Appliance)
                        {
                            ProductList.Children.Add(new ProductView(product));
                        }
                    }
                    break;
                }
            }
        }
    }
}