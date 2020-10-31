using System;

namespace HelloAutofac
{
    class Program
    {
        static void Main(string[] args)
        {
            var notifier = new ConsoleNotifier();
            var user = new User("Tim", notifier);
            user.ChangeName("Bob");
        }
    }
}
