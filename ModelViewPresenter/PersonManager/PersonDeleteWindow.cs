using System;
using PersonManager.Presenters;
using PersonManager.Services;
using PersonManager.Views;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace PersonManager
{
    class PersonDeleteWindow : Window, IPersonView
    {
        [UI] private Entry _entryId = null;
        [UI] private Label _labelPersonId = null;
        [UI] private Label _labelPersonName = null;
        [UI] private Button _buttonDeletePerson = null;

        public string IdText 
        { 
            get => _labelPersonId.Text; 
            set => _labelPersonId.Text = value; 
        }

        public string NameText 
        { 
            get => _labelPersonName.Text; 
            set => _labelPersonName.Text = value; 
        }


        public PersonDeleteWindow() : this(new Builder("PersonDeleteWindow.glade")) { }

        private PersonDeleteWindow(Builder builder) : base(builder.GetObject("PersonDeleteWindow").Handle)
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
            _buttonDeletePerson.Clicked += ButtonDeletePerson_Clicked;
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            this.Hide();
        }

        private void ButtonDeletePerson_Clicked(object sender, EventArgs a)
        {
            int id = int.Parse(_entryId.Text);
            PersonPresenter presenter = new PersonPresenter(this);
            presenter.DeletePerson(id);
        }
    }
}
