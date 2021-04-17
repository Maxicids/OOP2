using System;
using System.Runtime.Serialization;

namespace Shop_Service.ProductFactory
{
    [DataContract]
    [KnownType(typeof(Laptop))]
    [KnownType(typeof(Appliance))]
    [KnownType(typeof(SmartPhoneOrTablet))]
    [KnownType(typeof(Pc))]
    public abstract class Product
    {
        [DataMember(Name = "ProductName")]
        public string Name { get; set; }
        [DataMember(Name = "Price")]
        public int Price { get; set;}

        [DataMember(Name = "Rating")] 
        private int rating;
        public int Rating
        {
            get => rating;
            set
            {
                if (value >= 0 && value <= 5)
                {
                    rating = value;
                }
            }
        }

        [DataMember(Name = "Description")]
        public string Description { get; set;}

        public override string ToString()
        {
            return string.Concat(Name, " ", Price, " ", Rating, " ", Description);
        }
    }
}