using HelloAutofac.Core;

namespace HelloAutofac.Notification
{
    public interface INotificationService
    {
         void NotifyUsernameChanged(User user);
    }
}