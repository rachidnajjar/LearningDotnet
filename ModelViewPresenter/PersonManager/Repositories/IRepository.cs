using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using PersonManager.Models;

namespace PersonManager.Repositories
{
    public interface IRepository<T> where T : Model
    {
        void Create(T entity);
        void Create(IEnumerable<T> entities);
        T Retrieve(int id);
        IEnumerable<T> Retrieve();
        IEnumerable<T> Retrieve(Expression<Func<T, bool>> predicate);
        void Update(T entity);
        void Update(IEnumerable<T> entities);
        void Delete(int id);
        void Delete(T entity);
        void Delete(IEnumerable<T> entities);
    }
}