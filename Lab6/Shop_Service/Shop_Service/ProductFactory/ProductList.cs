using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;

namespace Shop_Service.ProductFactory
{
    public class ProductList
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
            instance.Add(new SmartPhoneOrTablet("Samsung Galaxy M31", 2450, 5, "Android, экран 6.4 AMOLED (1080x2340), Exynos 9611, ОЗУ 6 ГБ, флэш-память 128 ГБ, карты памяти, камера 64 Мп, аккумулятор 6000 мАч, 2 SIM"));
            instance.Add(new SmartPhoneOrTablet("Samsung Galaxy A31", 2450, 4, "Android, экран 6.4 AMOLED (1080x2400), Mediatek MT6768 Helio P65, ОЗУ 4 ГБ, флэш-память 64 ГБ, карты памяти, камера 48 Мп, аккумулятор 5000 мАч, 2 SIM"));
            instance.Add(new SmartPhoneOrTablet("Samsung Galaxy A31", 2450, 4, "Android, экран 6.4 AMOLED (1080x2400), Mediatek MT6768 Helio P65, ОЗУ 4 ГБ, флэш-память 64 ГБ, карты памяти, камера 48 Мп, аккумулятор 5000 мАч, 2 SIM"));
            instance.Add(new SmartPhoneOrTablet("Samsung Galaxy A31", 2450, 4, "Android, экран 6.4 AMOLED (1080x2400), Mediatek MT6768 Helio P65, ОЗУ 4 ГБ, флэш-память 64 ГБ, карты памяти, камера 48 Мп, аккумулятор 5000 мАч, 2 SIM"));
            instance.Add(new SmartPhoneOrTablet("Samsung Galaxy A31", 2450, 4, "Android, экран 6.4 AMOLED (1080x2400), Mediatek MT6768 Helio P65, ОЗУ 4 ГБ, флэш-память 64 ГБ, карты памяти, камера 48 Мп, аккумулятор 5000 мАч, 2 SIM"));
            instance.Add(new SmartPhoneOrTablet("Samsung Galaxy A31", 2450, 4, "Android, экран 6.4 AMOLED (1080x2400), Mediatek MT6768 Helio P65, ОЗУ 4 ГБ, флэш-память 64 ГБ, карты памяти, камера 48 Мп, аккумулятор 5000 мАч, 2 SIM"));
            instance.Add(new SmartPhoneOrTablet("Samsung Galaxy A31", 2450, 4, "Android, экран 6.4 AMOLED (1080x2400), Mediatek MT6768 Helio P65, ОЗУ 4 ГБ, флэш-память 64 ГБ, карты памяти, камера 48 Мп, аккумулятор 5000 мАч, 2 SIM"));
            instance.Add(new SmartPhoneOrTablet("Samsung Galaxy A31", 2450, 4, "Android, экран 6.4 AMOLED (1080x2400), Mediatek MT6768 Helio P65, ОЗУ 4 ГБ, флэш-память 64 ГБ, карты памяти, камера 48 Мп, аккумулятор 5000 мАч, 2 SIM"));
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