using System.Collections.Generic;
using PersonManager.Models;

namespace PersonManager.Services
{
    public interface IPersonService
    {
        void Save(Person person);
        Person Retrieve(int id);
        void Delete(int id);
        List<Person> Retrieve();

    }
}