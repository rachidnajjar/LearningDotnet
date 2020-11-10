using PersonManager.Models;

namespace PersonManager.Repositories
{
    public interface IUnitOfWork
    {
        IRepository<Person> PersonRepository { get; }

        // IRepository<Phone> PhoneRepository { get; }

        void Commit();
    }
}