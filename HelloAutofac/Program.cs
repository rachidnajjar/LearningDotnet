using System;

namespace HelloAutofac
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Tim");
            user.ChangeName("Bob");
        }
    }
}
