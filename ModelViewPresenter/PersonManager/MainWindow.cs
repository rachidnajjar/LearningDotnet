using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace PersonManager
{
    class MainWindow : Window
    {
        [UI] private Label _label1 = null;
        [UI] private Button _button1 = null;
        [UI] private ImageMenuItem _menuItemPersonCreate = null;
        [UI] private ImageMenuItem _menuItemPersonRetrieve = null;
        [UI] private ImageMenuItem _menuItemPersonUpdate = null;
        [UI] private ImageMenuItem _menuItemPersonDelete = null;

        private int _counter;

        public MainWindow() : this(new Builder("MainWindow.glade")) { }

        private MainWindow(Builder builder) : base(builder.GetObject("MainWindow").Handle)
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
            _button1.Clicked += Button1_Clicked;
            _menuItemPersonCreate.Activated += MenuItemPersonCreate_Activated;
            _menuItemPersonRetrieve.Activated += MenuItemPersonRetrieve_Activated;
            _menuItemPersonUpdate.Activated += MenuItemPersonUpdate_Activated;
            _menuItemPersonDelete.Activated += MenuItemPersonDelete_Activated;
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }

        private void Button1_Clicked(object sender, EventArgs a)
        {
            _counter++;
            _label1.Text = "Hello World! This button has been clicked " + _counter + " time(s).";
        }

        private void MenuItemPersonCreate_Activated(object sender, EventArgs a)
        {
            var window = new PersonCreateWindow();
            window.Show();
        }
        private void MenuItemPersonRetrieve_Activated(object sender, EventArgs a)
        {
            var window = new PersonRetrieveWindow();
            window.Show();
        }
        private void MenuItemPersonUpdate_Activated(object sender, EventArgs a)
        {
            var window = new PersonUpdateWindow();
            window.Show();
        }
        private void MenuItemPersonDelete_Activated(object sender, EventArgs a)
        {
            var window = new PersonDeleteWindow();
            window.Show();
        }

    }
}
