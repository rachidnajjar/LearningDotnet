namespace HelloAutofac
{
    public class User
    {
        private INotifier _notifier;


        public User(string name, INotifier notifier)
        {
            this.Name = name;
            _notifier = notifier;

        }

        public string Name { get; private set; }

        public void ChangeName(string name)
        {
            this.Name = name;
            _notifier.NotifyUsernameChanged(this);
        }

    }
}