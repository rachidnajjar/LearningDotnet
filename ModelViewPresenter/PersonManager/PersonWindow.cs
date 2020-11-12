using System;
using PersonManager.Presenters;
using PersonManager.Services;
using PersonManager.Views;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;
using PersonManager.Models;
using System.Collections.Generic;
using PersonManager.Data;
using PersonManager.Repositories;

namespace PersonManager
{
    class PersonWindow : Window, IPersonView
    {
        [UI] private Entry _entryId = null;
        [UI] private Entry _entryName = null;
        [UI] private Button _buttonRetrieve = null;
        [UI] private Button _buttonClear = null;
        [UI] private Button _buttonCreate = null;
        [UI] private Button _buttonUpdate = null;
        [UI] private Button _buttonDelete = null;
        [UI] private TreeView _treeViewPersons = null;
        [UI] private TreeStore _treeStorePerson = null;
        [UI] private TreeSelection _treeSelection = null;
        [UI] private TreeViewColumn _treeViewColumnPersonId = null;
        [UI] private CellRendererText _cellRendererTextPersonId = null;
        [UI] private TreeViewColumn _treeViewColumnPersonName = null;
        [UI] private CellRendererText _cellRendererTextPersonName = null;

        public string PersonId 
        { 
            get => _entryId.Text; 
            set => _entryId.Text = value; 
        }

        public string PersonName 
        { 
            get => _entryName.Text; 
            set => _entryName.Text = value; 
        }
        public List<Person> Persons 
        { 
            get; 
            set; 
        }

        private PersonPresenter _presenter;

        public PersonWindow() : this(new Builder("PersonWindow.glade")) { }

        private PersonWindow(Builder builder) : base(builder.GetObject("PersonWindow").Handle)
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
            _buttonRetrieve.Clicked += ButtonRetrieve_Clicked;
            _buttonClear.Clicked += ButtonClear_Clicked;
            _buttonCreate.Clicked += ButtonCreate_Clicked;
            _buttonUpdate.Clicked += ButtonUpdate_Clicked;
            _buttonDelete.Clicked += ButtonDelete_Clicked;
            _treeViewPersons.RowActivated += TreeViewPersons_RowActivated;

            // Tell the Cell Renderers which items in the model to display
            _treeViewColumnPersonId.AddAttribute (_cellRendererTextPersonId, "text", 0);
            _treeViewColumnPersonName.AddAttribute (_cellRendererTextPersonName, "text", 1);
            _treeViewPersons.Model = _treeStorePerson;

            var applicationContext = new ApplicationContext();
            var unitOfWork = new UnitOfWork(applicationContext);
            var service = new PersonService(unitOfWork);
            _presenter = new PersonPresenter(this, service);
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            this.Hide();
        }

        private void ButtonClear_Clicked(object sender, EventArgs a)
        {
            Clear();
        }

        private void ButtonCreate_Clicked(object sender, EventArgs a)
        {
            Person person = new Person();
            person.Id = int.Parse(_entryId.Text);
            person.Name = _entryName.Text;

            _presenter.Create(person);

            Retrieve();
        }

        private void ButtonUpdate_Clicked(object sender, EventArgs a)
        {
            int id = int.Parse(_entryId.Text);
            Person person = this.Persons.Find(p => p.Id == id);
            person.Name = _entryName.Text;

            _presenter.Update(person);

            Retrieve();
        }

        private void ButtonDelete_Clicked(object sender, EventArgs a)
        {
            int id = int.Parse(this.PersonId);
            _presenter.Delete(id);

            Retrieve();
            Clear();
        }
        private void ButtonRetrieve_Clicked(object sender, EventArgs a)
        {
            Retrieve();
            Clear();
        }

        
        private void TreeViewPersons_RowActivated(object sender, EventArgs a)
        {
            _treeSelection.GetSelected(out ITreeModel model, out TreeIter iter);
            this.PersonId = model.GetValue(iter,0).ToString();
            this.PersonName = model.GetValue(iter,1).ToString();
        }

        private void Retrieve()
        {
            _presenter.Retrieve();

            _treeStorePerson.Clear();
            foreach (var person in this.Persons)
            {
                _treeStorePerson.AppendValues(person.Id.ToString(), person.Name);
            }
            _treeViewPersons.Model = _treeStorePerson;
        }

        private void Clear()
        {
            this.PersonId = string.Empty;
            this.PersonName = string.Empty;
        }



    }
}
