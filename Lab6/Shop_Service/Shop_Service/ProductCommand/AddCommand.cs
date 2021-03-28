using Shop_Service.ProductFactory;

namespace Shop_Service.ProductCommand
{
    public class AddCommand : Command
    {
        private readonly ProductList receiver;
        private readonly Product product;
        public AddCommand(Product product)
        {
            receiver = ProductList.GetInstance();
            this.product = product;
        }
        public override void Execute()
        {
            receiver.Add(product);
        }
    }
}