using System;
using HelloAutofac.Core;
using HelloAutofac.Notification;

namespace HelloAutofac.ConsoleNotification
{
    public class ConsoleNotificationService : INotificationService
    {
        public void NotifyUsernameChanged(User user)
        {
            Console.WriteLine($"Username has changed to {user.Name}");
        }
    }
}