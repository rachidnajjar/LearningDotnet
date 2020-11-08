using System;
using PersonManager.Presenters;
using PersonManager.Services;
using PersonManager.Views;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;
using PersonManager.Models;

namespace PersonManager
{
    class PersonCreateWindow : Window, IPersonView
    {
        [UI]
        private Entry _entryId = null;
        [UI]
        private Entry _entryName = null;
        [UI]
        private Button _buttonCreatePerson = null;

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


        public PersonCreateWindow() : this(new Builder("PersonCreateWindow.glade")) { }

        private PersonCreateWindow(Builder builder) : base(builder.GetObject("PersonCreateWindow").Handle)
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
            _buttonCreatePerson.Clicked += ButtonCreatePerson_Clicked;
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }

        private void ButtonCreatePerson_Clicked(object sender, EventArgs a)
        {
            Person person = new Person();
            person.Id = int.Parse(_entryId.Text);
            person.Name = _entryName.Text;

            PersonPresenter presenter = new PersonPresenter(this);
            presenter.CreatePerson(person);
        }
    }
}
