using Autofac;
using Autofac.Core;
using Autofac.Core.Registration;
using HelloAutofac.Notification;

namespace HelloAutofac
{
    public class ProgramModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserService>().AsSelf();
        }
    }
}