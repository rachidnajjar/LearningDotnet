using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace WindowApplication
{
    class DisplayInfoWindow : Window
    {
        [UI] private Label _labelCode = null;
        [UI] private Label _labelNom = null;
        [UI] private Label _labelPrenom = null;
        [UI] private Label _labelType = null;


        public string Code 
        { 
            get { return _labelCode.Text; } 
            set { _labelCode.Text = value; }
        }
        public string Nom 
        { 
            get { return _labelNom.Text; } 
            set { _labelNom.Text = value; }
        }
        public string Prenom 
        { 
            get { return _labelPrenom.Text; } 
            set { _labelPrenom.Text = value; }
        }

        public new string Type 
        { 
            get { return _labelType.Text; } 
            set { _labelType.Text = value; }
        }

        public DisplayInfoWindow() : this(new Builder("DisplayInfoWindow.glade")) 
        { 
        }

        private DisplayInfoWindow(Builder builder) : base(builder.GetObject("DisplayInfoWindow").Handle)
        {
            builder.Autoconnect(this);
            DeleteEvent += Window_DeleteEvent;
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            this.Hide();
        }
    }
}
