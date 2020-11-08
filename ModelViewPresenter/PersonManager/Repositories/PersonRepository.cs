using System.Linq;
using PersonManager.Data;
using PersonManager.Models;

namespace PersonManager.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public void Create(Person person)
        {
            using (var db = new PersonManagerContext())
            {
                // Create
                db.Add(person);
                db.SaveChanges();
            }
        }


        public Person Retrieve(int id)
        {
            Person person;

            using (var db = new PersonManagerContext())
            {
                // Read
                person = db.Persons.Where(p => p.Id == id).SingleOrDefault();
            }

            return person;
        }

        public void Update(Person person)
        {
            using (var db = new PersonManagerContext())
            {
                // Update
                db.Update(person);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var person = Retrieve(id);

            using (var db = new PersonManagerContext())
            {
                // Delete
                db.Remove(person);
                db.SaveChanges();
            }
        }

        private bool Exists(int id)
        {
            Person person;

            using (var db = new PersonManagerContext())
            {
                // Read
                person = db.Persons.Where(p => p.Id == id).SingleOrDefault();
            }

            return (person == null ? false : true);
        }

    }
}