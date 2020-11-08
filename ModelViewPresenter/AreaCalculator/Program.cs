using System;
using Gtk;

namespace AreaCalculator
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.Init();

            var app = new Application("org.AreaCalculator.AreaCalculator", GLib.ApplicationFlags.None);
            app.Register(GLib.Cancellable.Current);

            // var win = new MainWindow();
            var win = new RectangleWindow();
            app.AddWindow(win);

            win.Show();
            Application.Run();
        }
    }
}
