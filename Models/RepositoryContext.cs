using Microsoft.EntityFrameworkCore;
using Entities.Models;
namespace StoreApp.Models
{

    //THIS CLASS IS CONSIDERED AS DATABASE
    public class RepositoryContext:DbContext
    {
        //Products table is created in this database
        public DbSet<Product> Products { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options):base(options)
        {
            
        }
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=D:\\ProductApp\\ProductDb.db");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product(){ProductId=1,ProductName="Computer",Price=10_000},
                new Product(){ProductId=2,ProductName="Mouse",Price=100},
                new Product(){ProductId=3,ProductName="Laptop",Price=50_000},
                new Product(){ProductId=4,ProductName="Printer",Price=5_000},
                new Product(){ProductId=5,ProductName="Keyboard",Price=20_000},
                new Product(){ProductId=6,ProductName="Screen",Price=30_000}
            );
        }
    }
}