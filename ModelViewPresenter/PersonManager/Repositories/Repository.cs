using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PersonManager.Data;
using PersonManager.Models;

namespace PersonManager.Repositories
{
    public class Repository<T> : IRepository<T> where T : Model
    {
        private ApplicationContext _context;

        private DbSet<T> _dbSet;

        public Repository(ApplicationContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Delete(int id)
        {
            T model = _dbSet.Find(id);
            Delete(model);
        }

        private void Delete(T model)
        {
            if (_context.Entry(model).State == EntityState.Detached)
            {
                _dbSet.Attach(model);
            }
            _dbSet.Remove(model);
        }

        public T Retrieve(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<T> Retrieve()
        {
            return _dbSet.ToList();
        }

        public void Create(T model)
        {
            _dbSet.Add(model);
        }

        public void Update(T model)
        {
            _dbSet.Attach(model);
            _context.Entry(model).State = EntityState.Modified;
        }

    }
}