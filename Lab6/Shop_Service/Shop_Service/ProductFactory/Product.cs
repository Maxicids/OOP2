namespace Shop_Service.ProductFactory
{
    public abstract class Product
    {
        public string Name { get; }
        public int Price { get; }
        public int Rating { get; }
        public int Quantity { get; }
    }
}