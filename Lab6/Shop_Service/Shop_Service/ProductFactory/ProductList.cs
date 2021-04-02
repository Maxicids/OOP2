using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;

namespace Shop_Service.ProductFactory
{
    public class ProductList : IProductContainer
    {
        private static ProductList instance;
        private List<Product> products;
        private readonly DataContractJsonSerializer jsonSerializer;
        private const string JsonPath = "JsonProducts.json";

        private ProductList()
        {
            products = new List<Product>();
            jsonSerializer = new DataContractJsonSerializer(typeof(List<Product>));
        }
        
        public static ProductList GetInstance()
        {
            if (instance != null) return instance;
            
            instance = new ProductList();
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
            products = products.OrderBy(x => x.Rating).ToList();
        }

        public void SortByPriceAscending()
        {
            products = products.OrderBy(x => x.Price).ToList();
            products = products.OrderBy(x => x.Price).ToList();
        }
        public void SortByPriceDescending()
        {
            products = products.OrderByDescending(x => x.Price).ToList();
        }

        #endregion

        #region Serialization

        public void Serialize()
        {
            using var file = new FileStream(JsonPath, FileMode.OpenOrCreate);
            jsonSerializer.WriteObject(file, products);
        }
        
        public void Deserialize()
        {
            var fileInfo = new FileInfo(JsonPath);
            if (!fileInfo.Exists) return;
            if (fileInfo.Length == 0) return;
            
            using var file = new FileStream(JsonPath, FileMode.OpenOrCreate);
            if (jsonSerializer.ReadObject(file) is not List<Product> deserializedProducts) return;
            foreach (var product in deserializedProducts)
            {
                products.Add(product);
            }
        }
        #endregion
    }
}