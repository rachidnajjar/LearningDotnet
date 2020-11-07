using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace ModelViewPresenter
{
    public class MainWindow : Window, IView
    {
        private Presenter _presenter = null;
        private readonly Model _model;

        [UI] private Label _label1 = null;
        [UI] private Button _button1 = null;
        [UI] private Button _button2 = null;
        [UI] private Entry _entry1 = null;

        public MainWindow(Model model) : this(new Builder("MainWindow.glade")) 
        { 
            _model = model;
            _presenter = new Presenter(this, _model);
            SubscribeToModelEvents();
        }

        private MainWindow(Builder builder) : base(builder.GetObject("MainWindow").Handle)
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
            _button1.Clicked += Button1_Clicked;
            _button2.Clicked += Button2_Clicked;
        }

        public string TextValue
        {
            get
            {
                return _entry1.Text;
            }
            set
            {
                _entry1.Text = value;
            }
 
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }

        private void Button1_Clicked(object sender, EventArgs a)
        {
            _presenter.SetTextValue();
        }

        private void Button2_Clicked(object sender, EventArgs a)
        {
            _presenter.ReverseTextValue();
        }

        private void SubscribeToModelEvents()
        {
            _model.TextSet += _model_TextSet;         
        }

        void _model_TextSet(object sender, CustomArgs e)
        {
            this._entry1.Text = e.m_after;
            this._label1.Text = "Text changed from " + e.m_before + " to " + e.m_after;
        }
    }
}
