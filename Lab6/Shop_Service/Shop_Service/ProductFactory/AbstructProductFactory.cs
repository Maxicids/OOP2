namespace Shop_Service.ProductFactory
{
    public abstract class AbstractProductFactory
    {
        public abstract SmartPhoneOrTablet CreateSmartPhoneOrTablet(string name);

    }
}