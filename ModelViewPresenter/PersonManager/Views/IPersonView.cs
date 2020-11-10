using System.Collections.Generic;
using PersonManager.Models;

namespace PersonManager.Views
{
    public interface IPersonView
    {
        string PersonId { get; set; }
        string PersonName { get; set; }

        List<Person> Persons { get; set; } 
    }
}