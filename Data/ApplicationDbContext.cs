using Microsoft.EntityFrameworkCore;
using webapp.Models;

namespace webapp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId=1,content="Introduction",contentnumber=1},
                new Category { CategoryId = 2, content = "Overview", contentnumber = 2 }
                );
        }
    }
}
