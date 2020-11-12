using System;
using PersonManager.Presenters;
using PersonManager.Services;
using PersonManager.Views;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;
using System.Collections.Generic;
using PersonManager.Models;
using PersonManager.Data;
using PersonManager.Repositories;

namespace PersonManager
{
    class PersonDeleteWindow : Window, IPersonView
    {
        [UI] private Entry _entryId = null;
        [UI] private Label _labelPersonId = null;
        [UI] private Label _labelPersonName = null;
        [UI] private Button _buttonDeletePerson = null;

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

        private PersonPresenter _presenter;

        public PersonDeleteWindow() : this(new Builder("PersonDeleteWindow.glade")) { }

        private PersonDeleteWindow(Builder builder) : base(builder.GetObject("PersonDeleteWindow").Handle)
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
            _buttonDeletePerson.Clicked += ButtonDeletePerson_Clicked;

            var applicationContext = new ApplicationContext();
            var unitOfWork = new UnitOfWork(applicationContext);
            var service = new PersonService(unitOfWork);
            _presenter = new PersonPresenter(this, service);
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            this.Hide();
        }

        private void ButtonDeletePerson_Clicked(object sender, EventArgs a)
        {
            int id = int.Parse(_entryId.Text);
            _presenter.Delete(id);
        }
    }
}
