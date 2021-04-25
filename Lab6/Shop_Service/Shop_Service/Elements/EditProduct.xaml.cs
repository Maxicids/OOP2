using System;
using System.Windows;
using System.Windows.Input;
using Shop_Service.ProductFactory;

namespace Shop_Service.Elements
{
    public partial class EditProduct
    {
        private Product inspectedProduct;
        public EditProduct(Product product)
        {
            InitializeComponent();
            inspectedProduct = product;
            TbName.Text = inspectedProduct.Name;
            TbDescription.Text = inspectedProduct.Description;
            TbPrice.Text = inspectedProduct.Price.ToString();
            TbRating.Text = inspectedProduct.Rating.ToString();
        }

        public Product GetInspectedProduct()
        {
            return inspectedProduct;
        }
        
        private void OnClose()
        {
            this.Close();
            foreach (Window window in Application.Current.Windows) window.IsEnabled = true;
        }

        private void Cancel_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            OnClose();
        }

        private void Save_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            inspectedProduct.Name = TbName.Text;
            inspectedProduct.Description =TbDescription.Text;
            inspectedProduct.Price = Convert.ToInt32(TbPrice.Text);
            inspectedProduct.Rating = Convert.ToInt32(TbRating.Text);
            OnClose();
        }
    }
}