using Microsoft.EntityFrameworkCore;
using PersonManager.Models;

namespace PersonManager.Data
{
    public class PersonManagerContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=PersonManager.db");
    }
}