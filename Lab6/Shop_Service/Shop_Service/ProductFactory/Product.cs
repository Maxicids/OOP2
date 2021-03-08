using System;

namespace Shop_Service.ProductFactory
{
    public abstract class Product
    {
        protected string Name { get; set; }
        protected int Price { get; set;}
        protected int Rating { get; set;}
        protected int Quantity { get; set;}

        public override string ToString()
        {
            return String.Concat(Name, " ", Price, " ", Rating, " ", Quantity);
        }
    }
}