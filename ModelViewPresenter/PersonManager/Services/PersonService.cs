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

        public void Create(Person person)
        {
            _repository.Create(person);
        }


        public Person Retrieve(int id)
        {
            Person person = _repository.Retrieve(id);
            return person;
        }

        public void Update(Person person)
        {
            _repository.Update(person);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

    }
}