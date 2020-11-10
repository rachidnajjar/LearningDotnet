using System;
using Gtk;
using PersonManager.Data;
using PersonManager.Models;
using PersonManager.Repositories;
using PersonManager.Services;

namespace PersonManager
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.Init();

            var app = new Application("org.PersonManager.PersonManager", GLib.ApplicationFlags.None);
            app.Register(GLib.Cancellable.Current);

            // var applicationContext = new ApplicationContext();
            // var unitOfWork = new UnitOfWork(applicationContext);
            // var personService = new Person2Service(unitOfWork);
            // var najjar = personService.Retrieve(1);
            // var persons = personService.Retrieve();

            // var glass = new Person();
            // glass.Id = 5;
            // glass.Name = "Glass";
            // personService.Create(glass);
            // personService.Commit();
            // persons = personService.Retrieve();

            // glass.Name = "Glassex";
            // personService.Update(glass);
            // personService.Commit();
            // persons = personService.Retrieve();

            // personService.Delete(glass.Id);
            // personService.Commit();
            // persons = personService.Retrieve();

            var mainWindow = new MainWindow();
            app.AddWindow(mainWindow);

            mainWindow.Show();
            Application.Run();
        }
    }
}
