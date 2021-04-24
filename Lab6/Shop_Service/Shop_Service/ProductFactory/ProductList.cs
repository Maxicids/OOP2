using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;

namespace Shop_Service.ProductFactory
{
    public class ProductList
    {
        private static ProductList instance;
        private ObservableCollection<Product> products;
        private readonly DataContractJsonSerializer jsonSerializer;
        private const string JsonPath = "JsonProducts.json";

        private ProductList()
        {
            products = new ObservableCollection<Product>();
            jsonSerializer = new DataContractJsonSerializer(typeof(List<Product>));
        }
        
        public static ProductList GetInstance()
        {
            if (instance != null) return instance;
            
            instance = new ProductList();
            instance.Deserialize();
            return instance;
        }

        public ObservableCollection<Product> GetProductsList()
        {
            return products;
        }
        public void SetProductsList(ObservableCollection<Product> productsCollection)
        {
            this.products = productsCollection;
        }

        #region Commands

        public void Add(Product product)
        {
            products.Add(product);
        }

        public void Remove(string name)
        {
            products.Remove(products.FirstOrDefault(x => x.Name == name));
        }

        public void SortByPopularity()
        {
            products = new ObservableCollection<Product>(products.OrderBy(x => x.Rating).ToList()) ;
        }

        public void SortByPriceAscending()
        {
            products = new ObservableCollection<Product>(products.OrderBy(x => x.Price).ToList());
            products = new ObservableCollection<Product>(products.OrderBy(x => x.Price).ToList());
        }
        public void SortByPriceDescending()
        {
            products = new ObservableCollection<Product>(products.OrderByDescending(x => x.Price).ToList());
        }

        #endregion

        #region Serialization

        public void Serialize()
        {
            using var file = new FileStream(JsonPath, FileMode.OpenOrCreate);
            jsonSerializer.WriteObject(file, products);
        }
        
        private void Deserialize()
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