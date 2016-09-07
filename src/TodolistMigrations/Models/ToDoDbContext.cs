using Microsoft.EntityFrameworkCore;

namespace ToDoListWithMigrations.Models
{
    public class ToDoDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Item> Items { get; set; }

        public ToDoDbContext(DbContextOptions<ToDoDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}