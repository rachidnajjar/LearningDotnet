using System.Collections.Generic;
using PersonManager.Models;

namespace PersonManager.Repositories
{
    public interface IPersonSimpleRepository
    {
        void Save(Person person);
        Person Retrieve(int id);
        void Delete(int id);
        List<Person> Retrieve();
    }
}