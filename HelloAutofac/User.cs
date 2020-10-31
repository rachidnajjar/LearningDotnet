namespace HelloAutofac
{
    public class User
    {
        private ConsoleNotifier _notifier;


        public User(string name)
        {
            this.Name = name;
            _notifier = new ConsoleNotifier();

        }

        public string Name { get; private set; }

        public void ChangeName(string name)
        {
            this.Name = name;
            _notifier.NotifyUsernameChanged(this);
        }

    }
}