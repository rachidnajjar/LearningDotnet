using System.Collections.Generic;
using PersonManager.Models;
using PersonManager.Repositories;

namespace PersonManager.Services
{
    public class PersonService : IPersonService
    {
        private IUnitOfWork _unitOfWork;

        public PersonService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(Person person)
        {
            _unitOfWork.PersonRepository.Create(person);
            _unitOfWork.Commit();
        }


        public Person Retrieve(int id)
        {
            Person person = _unitOfWork.PersonRepository.Retrieve(id);
            return person;
        }

        public void Update(Person person)
        {
            _unitOfWork.PersonRepository.Update(person);
            _unitOfWork.Commit();
        }

        public void Delete(int id)
        {
            _unitOfWork.PersonRepository.Delete(id);
            _unitOfWork.Commit();
         }

        public IEnumerable<Person> Retrieve()
        {
            return _unitOfWork.PersonRepository.Retrieve();
        }

        
    }
}