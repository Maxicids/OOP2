using System;

namespace Shop_Service.ProductFactory
{
    [Serializable]
    public class Laptop : Product
    {
        public Laptop(string name, int price, int rating, string description)
        {
            this.Name = name;
            this.Price = price;
            this.Rating = rating;
            this.Description = description;
        }
    }
}