using System.Collections.Generic;
using System.Linq;
using PersonManager.Data;
using PersonManager.Models;

namespace PersonManager.Repositories
{
    public class PersonSimpleRepository : IPersonSimpleRepository
    {
        public void Save(Person person)
        {
            if (Exists(person.Id))
            {
                Update(person);
            }
            else
            {
                Create(person);
            }
        }

        private void Create(Person person)
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

        private void Update(Person person)
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

        public List<Person> Retrieve()
        {
            List<Person> persons;

            using (var db = new PersonManagerContext())
            {
                // Read
                persons = db.Persons.ToList<Person>();
            }

            return persons;
        }
    }
}