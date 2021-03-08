namespace Shop_Service.ProductFactory
{
    public class ProductFactory
    {
        public SmartPhoneOrTablet CreateSmartPhoneOrTablet(string name, int price, int rating, int quantity)
        {
            return new SmartPhoneOrTablet(name, price, rating, quantity);
        }

        public Appliance CreateAppliance(string name, int price, int rating, int quantity)
        {
            return new Appliance(name, price, rating, quantity);
        }

        public Laptop CreateLaptop(string name, int price, int rating, int quantity)
        {
            return new Laptop(name, price, rating, quantity);
        }

        public Pc CreatePc(string name, int price, int rating, int quantity)
        {
            return new Pc(name, price, rating, quantity);
        }
    }
}