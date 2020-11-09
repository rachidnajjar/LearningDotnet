using System.Collections.Generic;
using PersonManager.Models;

namespace PersonManager.Views
{
    public interface IPersonView
    {
        string IdText { get; set; }
        string NameText { get; set; }

        List<Person> Persons { get; set; } 
    }
}