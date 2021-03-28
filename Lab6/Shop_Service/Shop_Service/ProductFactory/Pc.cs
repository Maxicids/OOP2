using System;

namespace Shop_Service.ProductFactory
{
    [Serializable]
    public class Pc : Product
    {
        public Pc(string name, int price, int rating, string description)
        {
            this.Name = name;
            this.Price = price;
            this.Rating = rating;
            this.Description = description;
        }
    }
}