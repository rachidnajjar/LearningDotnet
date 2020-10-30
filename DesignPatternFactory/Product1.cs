using System;

namespace DesignPatternFactory
{
    public class Product1 : IProduct
    {
        public void GetDetails()
        {
            Console.WriteLine("Getting details for product 1.");
        }
    }
}