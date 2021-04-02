namespace Shop_Service.ProductFactory
{
    public interface IProductContainer
    {
        public void Add(Product product);
        public void Remove(Product product);
        public void SortByPopularity();
        public void SortByPriceAscending();
        public void SortByPriceDescending();
        public void Serialize();
        public void Deserialize();
    }
}