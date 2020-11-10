using System.Collections.Generic;
using PersonManager.Models;

namespace PersonManager.Repositories
{
    public interface IRepository<T> where T : Model
    {
        void Create(T model);
        T Retrieve(int id);
        void Update(T model);
        void Delete(int id);
        IEnumerable<T> Retrieve();
    }
}