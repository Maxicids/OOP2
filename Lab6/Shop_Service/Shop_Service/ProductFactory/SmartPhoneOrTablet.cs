namespace Shop_Service.ProductFactory
{
    public class SmartPhoneOrTablet : Product
    {
        public SmartPhoneOrTablet(string name, int price, int rating, string description)
        {
            this.Name = name;
            this.Price = price;
            this.Rating = rating;
            this.Description = description;
        }
    }
}