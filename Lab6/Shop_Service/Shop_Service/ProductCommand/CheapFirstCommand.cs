using Shop_Service.ProductFactory;

namespace Shop_Service.ProductCommand
{
    public class CheapFirstCommand : Command
    {
        private readonly ProductList receiver;
        public CheapFirstCommand()
        {
            receiver = ProductList.GetInstance();
        }
        public override void Execute()
        {
            receiver.SortByPriceAscending();
        }
    }
}