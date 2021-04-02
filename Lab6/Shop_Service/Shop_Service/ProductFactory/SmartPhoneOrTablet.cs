using System;

namespace Shop_Service.ProductFactory
{
    [Serializable]
    public class SmartPhoneOrTablet : Product
    {
        internal SmartPhoneOrTablet(string name, int price, int rating, string description)
        {
            this.Name = name;
            this.Price = price;
            this.Rating = rating;
            this.Description = description;
        }
    }
}