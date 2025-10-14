using GomlaMarket.Models;
using Microsoft.EntityFrameworkCore;
using GomlaMarket.ViewModel;

namespace GomlaMarket.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;Database=GomlaMarket;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true");
        //    base.OnConfiguring(optionsBuilder);
        //}

        public DbSet<Category> Categories { get; set; }
        //public DbSet<GomlaMarket.ViewModel.UserRegisterViewModel> UserRegisterViewModel { get; set; } = default!;
        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electronics", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Jewelery", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Men's Clothing", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Women's Clothing", DisplayOrder = 4 }
                );
        }

    }
}
