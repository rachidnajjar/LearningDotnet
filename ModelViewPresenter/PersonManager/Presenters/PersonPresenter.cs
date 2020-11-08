using PersonManager.Models;
using PersonManager.Repositories;
using PersonManager.Services;
using PersonManager.Views;

namespace PersonManager.Presenters
{
    public class PersonPresenter
    {
        private IPersonView _view;


        public PersonPresenter(IPersonView view)
        {
            _view = view;
        }

        // public void CalculateArea()
        // {
        //     Personne personne = new Personne();
        //     Personne.Lenght = int.Parse(_view.LenghtText);
        //     Personne.Breadth = int.Parse(_view.BreadthText);

        //     var area = Personne.CalculateArea();
        //     _view.AreaText = area.ToString();
        // }

        public void RetrievePerson(int id)
        {
            var repository = new PersonRepository();
            var service = new PersonService(repository);
            Person person = service.Retrieve(id);
            _view.IdText = person.Id.ToString();
            _view.NameText = person.Name;
        }

        public void CreatePerson(Person person)
        {
            var repository = new PersonRepository();
            var service = new PersonService(repository);
            service.Create(person);
        }

    }
}