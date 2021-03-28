using Shop_Service.ProductFactory;

namespace Shop_Service.ProductCommand
{
    public class RemoveCommand : Command
    {
        private readonly ProductList receiver;
        private readonly Product product;
        public RemoveCommand(Product product)
        {
            receiver = ProductList.GetInstance();
            this.product = product;
        }
        public override void Execute()
        {
            receiver.Remove(product);
        }
    }
}