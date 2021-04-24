using System.Windows.Controls;
using System.Windows.Input;
using Shop_Service.ProductCommand;

namespace Shop_Service.Elements
{
    public partial class Cart : UserControl
    {
        private Invoker invoker;
        public Cart()
        {
            InitializeComponent();
        }
        private void Save_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            invoker ??= new Invoker();
            var productFactory = new ProductFactory.ProductFactory();
            var product = productFactory.CreateSmartPhoneOrTablet(
                AddProductView.NameTextBlockText, AddProductView.PriceTextBlockText,
                AddProductView.RatingTextBlockText, AddProductView.DescriptionTextBlockText);
            var command = new AddCommand(product);
            invoker.SetCommand(command);
            invoker.Run();
        }
    }
}