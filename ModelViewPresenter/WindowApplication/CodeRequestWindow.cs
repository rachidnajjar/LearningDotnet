using System;
using System.Collections.Generic;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace WindowApplication
{
    class CodeRequestWindow : Window
    {
        [UI] private ComboBoxText _comboBoxTextType = null;
        [UI] private Entry _entryCode = null;
        [UI] private Button _button1 = null;

        public string Code
        {
            get { return _entryCode.Text; }
            set { _entryCode.Text = value; }
        }
                

        private UIViewer _caller;

        public CodeRequestWindow(UIViewer caller) : this(new Builder("CodeRequestWindow.glade"), caller) 
        {

        }

        private CodeRequestWindow(Builder builder, UIViewer caller) : base(builder.GetObject("CodeRequestWindow").Handle)
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
            _button1.Clicked += Button1_Clicked;
            
            _caller = caller;
            loadListTypes(_caller.Presenter.LoadListType());
        }

        private void loadListTypes(List<string> types)
        {
            foreach (string type in types)
            {
                // load types in combo box
                _comboBoxTextType.AppendText(type);
            }

        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            this.Hide();
        }

        private void Button1_Clicked(object sender, EventArgs a)
        {
            _caller.Presenter.Type = _comboBoxTextType.ActiveText;
            _caller.Presenter.Code = _entryCode.Text;
            _caller.Presenter.CodeInputEnded();
            this.Hide();
        }
    }
}
