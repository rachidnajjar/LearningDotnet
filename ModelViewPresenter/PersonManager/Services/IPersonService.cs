using PersonManager.Models;

namespace PersonManager.Services
{
    public interface IPersonService
    {
        void Create(Person person);
        Person Retrieve(int id);
        void Update(Person person);
        void Delete(int id);

    }
}