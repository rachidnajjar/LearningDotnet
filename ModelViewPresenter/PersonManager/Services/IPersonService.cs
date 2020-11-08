using PersonManager.Models;

namespace PersonManager.Services
{
    public interface IPersonService
    {
        Person Retrieve(int id);
        void Create(Person person);
    }
}