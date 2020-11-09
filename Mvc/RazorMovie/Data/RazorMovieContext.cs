using Microsoft.EntityFrameworkCore;
using RazorMovie.Models;

namespace RazorMovie.Data
{
    public class RazorMovieContext : DbContext
    {
        public RazorMovieContext()
        {
            
        }

        public RazorMovieContext(DbContextOptions<RazorMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

    }
}