using System.Collections.Generic;
using PersonManager.Models;
using PersonManager.Repositories;

namespace PersonManager.Services
{
    public class Person2Service
    {
        private IUnitOfWork _unitOfWork;

        public Person2Service(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(Person person)
        {
            _unitOfWork.PersonRepository.Create(person);
        }


        public Person Retrieve(int id)
        {
            Person person = _unitOfWork.PersonRepository.Retrieve(id);
            return person;
        }

        public void Update(Person person)
        {
            _unitOfWork.PersonRepository.Update(person);
        }

        public void Delete(int id)
        {
            _unitOfWork.PersonRepository.Delete(id);
        }

        public IEnumerable<Person> Retrieve()
        {
            return _unitOfWork.PersonRepository.Retrieve();
        }

        public void Commit()
        {
            _unitOfWork.Commit();
        }
        
    }
}