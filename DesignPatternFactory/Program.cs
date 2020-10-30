using System;

namespace DesignPatternFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Factory[] factories = new Factory[2];
            factories[0] = new FactoryForProduct1();
            factories[1] = new FactoryForProduct2();

            foreach (var factory in factories)
            {
                IProduct product = factory.GetProduct();
                product.GetDetails();
            }


        }
    }
}
