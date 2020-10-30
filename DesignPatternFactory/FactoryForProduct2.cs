namespace DesignPatternFactory
{
    public class FactoryForProduct2 : Factory
    {
        public override IProduct GetProduct()
        {
            return new Product2();
        }
    }
}