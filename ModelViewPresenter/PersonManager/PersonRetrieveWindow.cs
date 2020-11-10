using System;
using PersonManager.Presenters;
using PersonManager.Services;
using PersonManager.Views;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;
using System.Collections.Generic;
using PersonManager.Models;

namespace PersonManager
{
    class PersonRetrieveWindow : Window, IPersonView
    {
        [UI]
        private Entry _entryId = null;
        [UI]
        private Label _labelPersonId = null;
        [UI]
        private Label _labelPersonName = null;
        [UI]
        private Button _buttonRetrievePerson = null;

        public string PersonId 
        { 
            get => _labelPersonId.Text; 
            set => _labelPersonId.Text = value; 
        }

        public string PersonName 
        { 
            get => _labelPersonName.Text; 
            set => _labelPersonName.Text = value; 
        }
        public List<Person> Persons { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public PersonRetrieveWindow() : this(new Builder("PersonRetrieveWindow.glade")) { }

        private PersonRetrieveWindow(Builder builder) : base(builder.GetObject("PersonRetrieveWindow").Handle)
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
            _buttonRetrievePerson.Clicked += ButtonRetrievePerson_Clicked;
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            this.Hide();
        }

        private void ButtonRetrievePerson_Clicked(object sender, EventArgs a)
        {
            int id = int.Parse(_entryId.Text);
            PersonPresenter presenter = new PersonPresenter(this);
            presenter.Retrieve(id);
        }
    }
}
