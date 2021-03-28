namespace Shop_Service.ProductFactory
{
    public class ProductFactory
    {
        public SmartPhoneOrTablet CreateSmartPhoneOrTablet(string name, int price, int rating, string description)
        {
            return new SmartPhoneOrTablet(name, price, rating, description);
        }

        public Appliance CreateAppliance(string name, int price, int rating, string description)
        {
            return new Appliance(name, price, rating, description);
        }

        public Laptop CreateLaptop(string name, int price, int rating, string description)
        {
            return new Laptop(name, price, rating, description);
        }

        public Pc CreatePc(string name, int price, int rating, string description)
        {
            return new Pc(name, price, rating, description);
        }
    }
}