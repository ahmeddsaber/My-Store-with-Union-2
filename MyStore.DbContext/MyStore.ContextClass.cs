using Microsoft.EntityFrameworkCore;

using MyStore.Models;
namespace MyStore.DbContext
{
    public class MyStoreDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-8F7PSID; Initial Catalog=MyStoreDbUSINGUnoin; Integrated Security=true; TrustServerCertificate=True; Encrypt=false;");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Catagory> catagories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Catagory>().HasData(

              new Catagory() { Id = 1, Name = "Electronics " },
              new Catagory() { Id = 2, Name = "Clothes" },
              new Catagory() { Id = 3, Name = "Phones" },
              new Catagory() { Id = 4, Name = "Labs " },
              new Catagory() { Id = 5, Name = "Computers" },
              new Catagory() { Id = 6, Name = "Screens " }

         );
            modelBuilder.Entity<Product>().HasData(
              new Product() { Id = 1, Name = "Maxer", Description = " Electronics", UnitPrice = 12000, UnitInStock = 10, CatagoryId = 1 },
              new Product() { Id = 2, Name = "Shorts", Description = " Clothes", UnitPrice = 12000, UnitInStock = 10, CatagoryId = 2 },
              new Product() { Id = 3, Name = "Oppo", Description = " Phones", UnitPrice = 12000, UnitInStock = 10, CatagoryId = 3 },
              new Product() { Id = 4, Name = "HP", Description = " Lap", UnitPrice = 12000, UnitInStock = 10, CatagoryId = 4 },
              new Product() { Id = 5, Name = "Dell", Description = " Computer", UnitPrice = 12000, UnitInStock = 10, CatagoryId = 5 },
              new Product() { Id = 6, Name = "LG", Description = " Screens", UnitPrice = 12000, UnitInStock = 10, CatagoryId = 6 }


                );
        }


    }
}
