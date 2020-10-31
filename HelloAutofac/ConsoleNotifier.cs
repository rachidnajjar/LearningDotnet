using System;

namespace HelloAutofac
{
    public class ConsoleNotifier : INotifier
    {
        public void NotifyUsernameChanged(User user)
        {
            Console.WriteLine($"Username has changed to {user.Name}");
        }
    }
}