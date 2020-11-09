using System.Collections.Generic;
using PersonManager.Models;
using PersonManager.Repositories;
using PersonManager.Services;
using PersonManager.Views;

namespace PersonManager.Presenters
{
    public class PersonPresenter
    {
        private IPersonView _view;


        public PersonPresenter(IPersonView view)
        {
            _view = view;
        }

        public void Retrieve(int id)
        {
            var repository = new PersonRepository();
            var service = new PersonService(repository);
            Person person = service.Retrieve(id);

            if (person == null)
            {
                _view.IdText = "-1";
                _view.NameText = "not found";
            }
            else
            {
                _view.IdText = person.Id.ToString();
                _view.NameText = person.Name;
            }

        }

        public void Save(Person person)
        {
            var repository = new PersonRepository();
            var service = new PersonService(repository);
            service.Save(person);
        }

        public void Delete(int id)
        {
            var repository = new PersonRepository();
            var service = new PersonService(repository);
            service.Delete(id);
        }

        public void Retrieve()
        {
            var repository = new PersonRepository();
            var service = new PersonService(repository);
            _view.Persons = service.Retrieve();
        }

    }
}