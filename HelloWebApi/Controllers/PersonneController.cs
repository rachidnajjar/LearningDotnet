// using System.Linq;
// using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HelloWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonneController : ControllerBase
    {
        private readonly ILogger<PersonneController> _logger;

        public PersonneController(ILogger<PersonneController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Personne> Get()
        {
            var personnes = new List<Personne>();

            Personne personne;

            personne = new Personne();
            personne.Id = 1;
            personne.Nom = "Najjar";
            personne.Prenom = "Rachid";
            personne.DateNaissance = new DateTime(1974, 10, 24);
            personnes.Add(personne);

            personne = new Personne();
            personne.Id = 1;
            personne.Nom = "Boudou";
            personne.Prenom = "Nadoua";
            personne.DateNaissance = new DateTime(1982, 11, 05);
            personnes.Add(personne);

            return personnes;
        }
    }
}
