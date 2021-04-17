using Shop_Service.ProductFactory;
namespace Shop_Service.ProductCommand
{
    public class AddToCart : Command
    {
        private readonly Cart receiver;
        private readonly Product product;
        public AddToCart(Product product)
        {
            receiver = Cart.GetInstance();
            this.product = product;
        }
        public override void Execute()
        {
            receiver.Add(product);
        }
    }
}