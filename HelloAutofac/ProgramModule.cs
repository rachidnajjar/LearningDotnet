using Autofac;
using Autofac.Core;
using Autofac.Core.Registration;

namespace HelloAutofac
{
    public class ProgramModule : Module
    {
        
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ConsoleNotificationService>().As<INotificationService>();
            builder.RegisterType<UserService>().AsSelf();
        }
    }
}