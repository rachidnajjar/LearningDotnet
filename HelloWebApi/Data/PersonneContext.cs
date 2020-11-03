using HelloWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloWebApi.Data
{
    public class PersonneContext : DbContext
    {
        public PersonneContext()
        {
            
        }


        public PersonneContext(DbContextOptions<PersonneContext> options) : base(options)
        {
        }

        public DbSet<Personne> Personnes { get; set; }
        
    }
}