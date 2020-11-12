using System.Collections.Generic;
using System.Linq;
using PersonManager.Data;
using PersonManager.Models;

namespace PersonManager.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(ApplicationContext context) : base(context)
        {
        }

        public IEnumerable<Person> RetrieveTop(int top)
        {
            return _entities.Take(top).ToList();
        }
    }
}