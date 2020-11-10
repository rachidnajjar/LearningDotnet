using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace ClassicImplementation
{
    class MainWindow : Window, IAstuceView
    {
        [UI] private Label _label1 = null;
        [UI] private Button _button1 = null;

        // private int _counter;

        private AstucePresenter presenter;
        public event EventHandler CloseRequested;
        public event EventHandler NextRequested;

        public string Astuce 
        { 
            set
            {
                _label1.Text = value;
            } 
        }

        public MainWindow() : this(new Builder("MainWindow.glade")) { }

        private MainWindow(Builder builder) : base(builder.GetObject("MainWindow").Handle)
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
            _button1.Clicked += Button1_Clicked;

            presenter = new AstucePresenter(this);
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }

        private void Button1_Clicked(object sender, EventArgs a)
        {
            // _counter++;
            // _label1.Text = "Hello World! This button has been clicked " + _counter + " time(s).";
            NextRequested(this, EventArgs.Empty);
        }
    }
}
