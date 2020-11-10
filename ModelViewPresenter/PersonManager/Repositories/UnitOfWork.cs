using PersonManager.Data;
using PersonManager.Models;

namespace PersonManager.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationContext _context;

        private Repository<Person> _personRepository;

        // private Repository<Phone> _phoneRepository;

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
        }

        public IRepository<Person> PersonRepository
        {
            get
            {
                if (_personRepository == null)
                    _personRepository = new Repository<Person>(_context);
                
                return _personRepository;
            }
        }


        // public IRepository<Phone> PhoneRepository
        // {
        //     get
        //     {
        //         if (_phoneRepository == null)
        //             _phoneRepository = new Repository<Phone>(_context);
                
        //         return _phoneRepository;
        //     }
        // }


        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}