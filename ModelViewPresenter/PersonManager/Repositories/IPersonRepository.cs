using System.Collections.Generic;
using PersonManager.Models;

namespace PersonManager.Repositories
{
    public interface IPersonRepository : IRepository<Person>
    {
        IEnumerable<Person> RetrieveTop(int top);
    }
}