using System;
using PersonManager.Models;

namespace PersonManager.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IPersonRepository PersonRepository { get; }

        // IRepository<Phone> PhoneRepository { get; }

        int Commit();
    }
}