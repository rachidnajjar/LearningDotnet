namespace DesignPatternFactory
{
    public class FactoryForProduct1 : Factory
    {
        public override IProduct GetProduct()
        {
            return new Product1();
        }
    }
}