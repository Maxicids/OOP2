namespace Shop_Service.ProductFactory
{
    public class Laptop : Product
    {
        public Laptop(string name, int price, int rating, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Rating = rating;
            this.Quantity = quantity;
        }
    }
}