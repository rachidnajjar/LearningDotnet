using System;
using Gtk;

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

            var mainWindow = new MainWindow();
            app.AddWindow(mainWindow);

            mainWindow.Show();
            Application.Run();
        }
    }
}
