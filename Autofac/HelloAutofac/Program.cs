using System;
using Autofac;
using HelloAutofac.Core;
using HelloAutofac.Notification;

namespace HelloAutofac
{
    class Program
    {
        static void Main(string[] args)
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule<ProgramModule>();
            containerBuilder.RegisterModule<NotificationModule>();
            var container = containerBuilder.Build();
            
            var notifier = container.Resolve<INotificationService>();
            var userService = container.Resolve<UserService>();

            var user = new User("Tim");
            userService.ChangeUserName(user, "Bob");
        }
    }
}
