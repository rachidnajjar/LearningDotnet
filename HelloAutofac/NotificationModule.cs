using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Autofac;
using HelloAutofac.Notification;

namespace HelloAutofac
{
    public class NotificationModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var executingAssembly = Assembly.GetExecutingAssembly();
            string executingDirectory = Path.GetDirectoryName(new Uri(executingAssembly.CodeBase).LocalPath);

            var notificationServiceTypes = Directory.EnumerateFiles(executingDirectory)
                .Where(fileName => fileName.Contains("HelloAutofac") && fileName.EndsWith("Notification.dll"))
                .Select(filePath => Assembly.LoadFrom(filePath))
                .SelectMany(assembly => assembly.GetTypes().Where(type => typeof(INotificationService).IsAssignableFrom(type) && type.IsClass));

            foreach (var notificationServiceType in notificationServiceTypes)
            {
                builder.RegisterType(notificationServiceType).As<INotificationService>();
            }
        }
    }
}