using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PersonManager.Data;
using PersonManager.Models;

namespace PersonManager.Repositories
{
    public class Repository<T> : IRepository<T> where T : Model
    {
        protected ApplicationContext _context;

        protected DbSet<T> _entities;

        public Repository(ApplicationContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        public void Create(T entity)
        {
            _entities.Add(entity);
        }

        public void Create(IEnumerable<T> entities)
        {
            _entities.AddRange(entities);
        }

        public T Retrieve(int id)
        {
            return _entities.Find(id);
        }

        public IEnumerable<T> Retrieve()
        {
            return _entities.ToList();
        }

        public IEnumerable<T> Retrieve(Expression<Func<T, bool>> predicate)
        {
            return _entities.Where(predicate);
        }

        public void Update(T entity)
        {
            Attach(entity);
            // _context.Entry(entity).State = EntityState.Modified;
            _entities.Update(entity);
        }

        public void Update(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                Attach(entity);
            }

            _entities.UpdateRange(entities);
        }

        public void Delete(int id)
        {
            T entity = _entities.Find(id);
            Delete(entity);
        }

        public void Delete(T entity)
        {
            Attach(entity);
            _entities.Remove(entity);
        }

        public void Delete(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                Attach(entity);
            }

            _entities.RemoveRange(entities);
        }

        private void Attach(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _entities.Attach(entity);
            }
        }
    }
}