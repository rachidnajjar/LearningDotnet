using System;

namespace HelloAutofac
{
    public class ConsoleNotificationService : INotificationService
    {
        public void NotifyUsernameChanged(User user)
        {
            Console.WriteLine($"Username has changed to {user.Name}");
        }
    }
}