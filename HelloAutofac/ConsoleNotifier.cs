using System;

namespace HelloAutofac
{
    public class ConsoleNotifier
    {
        public void NotifyUsernameChanged(User user)
        {
            Console.WriteLine($"Username has changed to {user.Name}");
        }
    }
}