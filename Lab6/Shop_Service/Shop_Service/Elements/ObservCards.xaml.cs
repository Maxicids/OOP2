using Shop_Service.ProductFactory;

namespace Shop_Service.Elements
{
    public partial class ObservCards
    {
        public ObservCards()
        {
            InitializeComponent();
            Update();
        }
        public void Update()
        {
            ShoppingCardsList.ItemsSource = ProductList.GetInstance().GetProductsList();
        }
    }
}