using System.Collections.Generic;
using System.Runtime.Serialization.Json;

namespace Shop_Service.ProductFactory
{
    public class Cart : IProductContainer
    {
        private static Cart instance;
        private readonly List<Product> products;
        private readonly DataContractJsonSerializer jsonSerializer;
        private const string JsonPath = "JsonCart.json";

        private Cart()
        {
            products = new List<Product>();
            jsonSerializer = new DataContractJsonSerializer(typeof(List<Product>));
        }

        public static Cart GetInstance()
        {
            if (instance != null) return instance;
            
            instance = new Cart();
            instance.Deserialize();
            return instance;
        }
        public IEnumerable<Product> GetProductsList()
        {
            return products;
        }

        #region Commands

        public void Add(Product product)
        {
            products.Add(product);
        }

        public void Remove(Product product)
        {
            products.Remove(product);
        }

        public void SortByPopularity()
        {
            throw new System.NotImplementedException();
        }

        public void SortByPriceAscending()
        {
            throw new System.NotImplementedException();
        }

        public void SortByPriceDescending()
        {
            throw new System.NotImplementedException();
        }

        #endregion Command

        #region Serialization

        public void Serialize()
        {
            throw new System.NotImplementedException();
        }

        public void Deserialize()
        {
            throw new System.NotImplementedException();
        }

        #endregion
        
    }
}