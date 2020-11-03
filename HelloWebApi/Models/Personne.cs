using System;

namespace HelloWebApi.Models
{
    public class Personne
    {
        public long Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
    }
}