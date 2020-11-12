using System.Collections.Generic;
using System.Linq;
using PersonManager.Models;
using PersonManager.Repositories;
using PersonManager.Services;
using PersonManager.Views;

namespace PersonManager.Presenters
{
    public class PersonPresenter
    {
        private IPersonView _view;
        private IPersonService _service;


        public PersonPresenter(IPersonView view, IPersonService service)
        {
            _view = view;
            _service = service;
        }


        public void Create(Person person)
        {
            _service.Create(person);
        }

        public void Retrieve(int id)
        {
            Person person = _service.Retrieve(id);

            if (person == null)
            {
                _view.PersonId = "-1";
                _view.PersonName = "not found";
            }
            else
            {
                _view.PersonId = person.Id.ToString();
                _view.PersonName = person.Name;
            }

        }

        public void Retrieve()
        {
            _view.Persons = _service.Retrieve().ToList();
        }

        public void Update(Person person)
        {
            _service.Update(person);
        }

        public void Delete(int id)
        {
            _service.Delete(id);
        }

    }
}