using System;
using System.Windows;
using System.Windows.Input;
using Shop_Service.ProductCommand;

namespace Shop_Service.Elements
{
    public partial class AddProduct
    {
        private Invoker invoker;
        public AddProduct()
        {
            InitializeComponent();
        }

        private void OnClose()
        {
            Close();
            foreach (Window window in Application.Current.Windows) window.IsEnabled = true;
        }

        private void Cancel_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            OnClose();
        }

        private void Save_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            invoker ??= new Invoker();
            var productFactory = new ProductFactory.ProductFactory();
            var product = productFactory.CreateSmartPhoneOrTablet(
                TbName.Text, Convert.ToInt32(TbPrice.Text),
                Convert.ToInt32(TbRating.Text), TbDescription.Text);
            var command = new AddCommand(product);
            invoker.SetCommand(command);
            invoker.Run();
            OnClose();
        }
    }
}