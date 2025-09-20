using GomlaMarket.Models;
using Microsoft.EntityFrameworkCore;

namespace GomlaMarket.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category {Id = 1, Name = "Electronics", DisplayOrder = 1 },
                new Category {Id = 2, Name = "Jewelery", DisplayOrder = 2 },
                new Category {Id = 3, Name = "Men's Clothing", DisplayOrder = 3 },
                new Category {Id = 4, Name = "Women's Clothing", DisplayOrder = 4 }
                );
        }

    }
}
