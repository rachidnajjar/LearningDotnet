using Microsoft.EntityFrameworkCore;
using PersonManager.Models;

namespace PersonManager.Data
{
    public class ApplicationContext : DbContext
    {
        // TODO :Singleton



        public DbSet<Person> Persons { get; set; }
        // public DbSet<Phone> Phones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=PersonManager.db");
    }
}