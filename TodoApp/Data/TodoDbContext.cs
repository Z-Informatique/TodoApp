using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

namespace TodoApp.Data
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions options):base(options)
        {
                
        }

        public DbSet<Todo> Todos { get; set; }
    }
}
