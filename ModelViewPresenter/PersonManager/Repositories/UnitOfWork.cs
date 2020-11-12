using PersonManager.Data;
using PersonManager.Models;

namespace PersonManager.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationContext _context;

        private IPersonRepository _personRepository;
        public IPersonRepository PersonRepository 
        { 
            get { return _personRepository; } 
        }


        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            _personRepository = new PersonRepository(_context);
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        
    }
}