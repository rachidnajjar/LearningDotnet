using System;
using Gtk;

namespace ModelViewPresenter
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.Init();

            var app = new Application("org.ModelViewPresenter.ModelViewPresenter", GLib.ApplicationFlags.None);
            app.Register(GLib.Cancellable.Current);

            var model = new Model();
            var win = new MainWindow(model);
            app.AddWindow(win);

            win.Show();
            Application.Run();
        }
    }
}
