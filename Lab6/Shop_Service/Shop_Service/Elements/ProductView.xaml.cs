using System.Windows.Controls;
using System.Windows.Input;
using Shop_Service.ProductFactory;

namespace Shop_Service.Elements
{
    public partial class ProductView : UserControl
    {
        public ProductView(Product product)
        {
            InitializeComponent();
            Header.Text = product.Name;
            Description.Text = "\t" + product.Description;
            Price.Text = "Price: " + product.Price.ToString();
        }

        private void AddToCart_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}