using PersonManager.Models;

namespace PersonManager.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public void Create(Person person)
        {
            // Créer la personne en base de données
        }

        public Person Retrieve(int id)
        {
            Person person = new Person();
            person.Id = id;
            person.Name = "Personne " + id;
            return person;
        }
    }
}