using System.Windows.Controls;
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
    }
}