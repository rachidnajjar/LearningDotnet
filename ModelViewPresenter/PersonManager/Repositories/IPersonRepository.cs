using PersonManager.Models;

namespace PersonManager.Repositories
{
    public interface IPersonRepository
    {
        void Create(Person person);
        Person Retrieve(int id);
    }
}