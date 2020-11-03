using HelloWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloWebApi.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext()
        {
            
        }


        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
        
    }
}