using System;
using Shop_Service.ProductFactory;

namespace Shop_Service.ProductCommand
{
    public class RemoveCommand : Command
    {
        private readonly ProductList receiver;
        private readonly string product;
        public RemoveCommand(string product)
        {
            receiver = ProductList.GetInstance();
            this.product = product;
        }
        public override void Execute()
        {
            receiver.Remove(product);
            MainWindow.appHistory.AddState(receiver.GetProductsList());
        }
    }
}