using Shop_Service.ProductFactory;
namespace Shop_Service.ProductCommand
{
    public class RemoveFromCart : Command
    {
        private readonly Cart receiver;
        private readonly Product product;
        public RemoveFromCart(Product product)
        {
            receiver = Cart.GetInstance();
            this.product = product;
        }
        public override void Execute()
        {
            receiver.Remove(product);
        }
    }
}