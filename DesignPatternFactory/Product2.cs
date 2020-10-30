using System;

namespace DesignPatternFactory
{
    public class Product2 : IProduct
    {
        public void GetDetails()
        {
            Console.WriteLine("Getting details for product 2.");
        }
    }
}