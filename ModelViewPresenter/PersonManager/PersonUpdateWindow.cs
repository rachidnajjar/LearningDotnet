using System;
using PersonManager.Presenters;
using PersonManager.Services;
using PersonManager.Views;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;
using PersonManager.Models;

namespace PersonManager
{
    class PersonUpdateWindow : Window, IPersonView
    {
        [UI]
        private Entry _entryId = null;
        [UI]
        private Entry _entryName = null;
        [UI]
        private Button _buttonUpdatePerson = null;

        public string IdText 
        { 
            get => _entryId.Text; 
            set => _entryId.Text = value; 
        }

        public string NameText 
        { 
            get => _entryName.Text; 
            set => _entryName.Text = value; 
        }


        public PersonUpdateWindow() : this(new Builder("PersonUpdateWindow.glade")) { }

        private PersonUpdateWindow(Builder builder) : base(builder.GetObject("PersonUpdateWindow").Handle)
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
            _buttonUpdatePerson.Clicked += ButtonUpdatePerson_Clicked;
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            this.Hide();
        }

        private void ButtonUpdatePerson_Clicked(object sender, EventArgs a)
        {
            Person person = new Person();
            person.Id = int.Parse(_entryId.Text);
            person.Name = _entryName.Text;

            PersonPresenter presenter = new PersonPresenter(this);
            presenter.UpdatePerson(person);
        }
    }
}
