using System;
using AreaCalculator.Presenters;
using AreaCalculator.Views;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace AreaCalculator
{
    class RectangleWindow : Window, IRectangleView
    {
        [UI]
        private Entry _entryLength = null;
        [UI]
        private Entry _entryBreadth = null;
        [UI]
        private Entry _entryArea = null;
        [UI]
        private Button _buttonCalculateArea = null;

        public string LenghtText 
        { 
            get => _entryLength.Text; 
            set => _entryLength.Text = value; 
        }
        public string BreadthText 
        { 
            get => _entryBreadth.Text; 
            set => _entryBreadth.Text = value; 
        }
        public string AreaText 
        { 
            get => _entryArea.Text; 
            set => _entryArea.Text = value; 
        }

        public RectangleWindow() : this(new Builder("RectangleWindow.glade")) { }

        private RectangleWindow(Builder builder) : base(builder.GetObject("RectangleWindow").Handle)
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
            _buttonCalculateArea.Clicked += ButtonCalculateArea_Clicked;
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }

        private void ButtonCalculateArea_Clicked(object sender, EventArgs a)
        {
            RectanglePresenter presenter = new RectanglePresenter(this);
            presenter.CalculateArea();
        }
    }
}
