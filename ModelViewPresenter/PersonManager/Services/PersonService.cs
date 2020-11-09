using System.Collections.Generic;
using PersonManager.Models;
using PersonManager.Repositories;

namespace PersonManager.Services
{
    public class PersonService : IPersonService
    {
        private IPersonRepository _repository;

        public PersonService(IPersonRepository repository)
        {
            _repository = repository;
        }

        public void Save(Person person)
        {
            _repository.Save(person);
        }


        public Person Retrieve(int id)
        {
            Person person = _repository.Retrieve(id);
            return person;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Person> Retrieve()
        {
            return _repository.Retrieve();
        }
    }
}