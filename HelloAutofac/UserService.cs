namespace HelloAutofac
{
    public class UserService
    {
        private INotificationService _notificationService;

        public UserService(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void ChangeUserName(User user, string newUserName)
        {
            user.Name = newUserName;
            _notificationService.NotifyUsernameChanged(user);
        }

    }
}