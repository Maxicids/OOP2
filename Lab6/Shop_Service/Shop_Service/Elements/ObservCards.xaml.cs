using System.Collections.ObjectModel;
using Shop_Service.ProductFactory;

namespace Shop_Service.Elements
{
    interface IAllCards
    {
        ObservableCollection<Product> GetCardsCollection();
    }
    public partial class ObservCards
    {
        public ObservCards()
        {
            var productList = ProductList.GetInstance();
            var products = productList.GetProductsList();
            InitializeComponent();
            ShoppingCardsList.ItemsSource = products;
        }
    }
}