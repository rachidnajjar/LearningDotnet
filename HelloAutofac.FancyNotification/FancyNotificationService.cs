using System;
using HelloAutofac.Core;
using HelloAutofac.Notification;

namespace HelloAutofac.FancyNotification
{
    public class FancyNotificationService : INotificationService
    {
        public void NotifyUsernameChanged(User user)
        {
            Console.WriteLine("************************************");
            Console.WriteLine($"Username has changed to {user.Name}");
            Console.WriteLine("************************************");
        }
    }
}