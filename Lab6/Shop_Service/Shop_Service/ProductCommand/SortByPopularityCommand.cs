using Shop_Service.ProductFactory;

namespace Shop_Service.ProductCommand
{
    public class SortByPopularityCommand : Command
    {
        private readonly ProductList receiver;
        public SortByPopularityCommand()
        {
            receiver = ProductList.GetInstance();
        }
        public override void Execute()
        {
            receiver.SortByPopularity();
        }
    }
}