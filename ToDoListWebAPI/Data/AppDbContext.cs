using Microsoft.EntityFrameworkCore;
using ToDoListWebAPI.Model;

namespace ToDoListWebAPI.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        // Define a DbSet for the Item entity here.
        public DbSet<Item> Items { get; set; }
    }
}
