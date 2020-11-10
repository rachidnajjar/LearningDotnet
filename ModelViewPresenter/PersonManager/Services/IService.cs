using System.Collections.Generic;
using PersonManager.Models;

namespace PersonManager.Services
{
    public interface IService<T> where T : Model
    {
        void Save(T entity);
        T Retrieve(int id);
        void Delete(int id);
        List<T> Retrieve();         
    }
}