using System.Windows.Controls;
using System.Windows.Input;
using Shop_Service.ProductCommand;
using Shop_Service.ProductFactory;

namespace Shop_Service.Elements
{
    public partial class Card
    {
        private Invoker invoker;
        public Card()
        {
            InitializeComponent();
        }

        private void Remove_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            invoker ??= new Invoker();
            var command = new RemoveCommand(HeaderTextBlock.Text);
            invoker.SetCommand(command);
            invoker.Run();
            //ProductList.GetInstance().Remove(HeaderTextBlock.Text);
        }
    }
}