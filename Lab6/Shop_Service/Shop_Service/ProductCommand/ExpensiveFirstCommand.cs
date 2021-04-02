using Shop_Service.ProductFactory;

namespace Shop_Service.ProductCommand
{
    public class ExpensiveFirstCommand : Command
    {
        private readonly ProductList receiver;
        public ExpensiveFirstCommand()
        {
            receiver = ProductList.GetInstance();
        }
        public override void Execute()
        {
            receiver.SortByPriceDescending();
        }
    }
}