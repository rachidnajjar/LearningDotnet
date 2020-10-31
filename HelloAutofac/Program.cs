using System;
using Autofac;

namespace HelloAutofac
{
    class Program
    {
        static void Main(string[] args)
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<ConsoleNotifier>().As<INotifier>();
            var container = containerBuilder.Build();
            
            var notifier = container.Resolve<INotifier>();
            var user = new User("Tim", notifier);
            user.ChangeName("Bob");
        }
    }
}
