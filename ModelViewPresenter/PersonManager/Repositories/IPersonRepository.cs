using PersonManager.Models;

namespace PersonManager.Repositories
{
    public interface IPersonRepository
    {
        void Create(Person person);
        Person Retrieve(int id);
        void Update(Person person);
        void Delete(int id);

    }
}