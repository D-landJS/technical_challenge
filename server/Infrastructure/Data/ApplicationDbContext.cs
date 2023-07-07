using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product()
                { 
                    Id = 1, 
                    BrandName = "MOTOROLA", 
                    DetailName = "Celular Motorola Moto G13\"", 
                    Price = 500,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                }, 
                new Product()
                {
                    Id = 2, 
                    BrandName = "LG", 
                    DetailName = "Televisor LG LED 50\"", 
                    Price = 1000,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                },
                new Product()
                {
                    Id = 3,
                    BrandName = "LG",
                    DetailName = "Televisor LG LED 55\"",
                    Price = 1199,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                },
                new Product()
                {
                    Id = 4,
                    BrandName = "SAMSUNG",
                    DetailName = "Celular Samsung Galaxy A24",
                    Price = 949,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                },
                new Product()
                {
                    Id = 5,
                    BrandName = "LENOVO",
                    DetailName = "Laptop Lenovo IdeaPad Gaming 3i 15.6\"",
                    Price = 2000,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                },
                new Product()
                {
                    Id = 6,
                    BrandName = "SONY",
                    DetailName = "Consola Playstation 5",
                    Price = 2400,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                },
                new Product()
                {
                    Id = 7,
                    BrandName = "SONY",
                    DetailName = "Consola Playstation 4",
                    Price = 1500,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                },
                new Product()
                {
                    Id = 8,
                    BrandName = "APPLE",
                    DetailName = "Phone 13 128GB Azul",
                    Price = 3229,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                },
                new Product()
                {
                    Id = 9,
                    BrandName = "APPLE",
                    DetailName = "Phone 12 128GB Azul",
                    Price = 2999,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                },
                new Product()
                {
                    Id = 10,
                    BrandName = "APPLE",
                    DetailName = "Phone 11 128GB Azul",
                    Price = 1549,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                },
                new Product()
                {
                    Id = 11,
                    BrandName = "LG",
                    DetailName = "Televisor SONY 65\"",
                    Price = 3000,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                },
                new Product()
                {
                    Id = 12,
                    BrandName = "APPLE",
                    DetailName = "Apple AirPods 3ra Gen",
                    Price = 699,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                },
                new Product()
                {
                    Id = 13,
                    BrandName = "SAMSUNG",
                    DetailName = "Celular Samsung Galaxy A73 ",
                    Price = 1699,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                },
                new Product()
                {
                    Id = 14,
                    BrandName = "LG",
                    DetailName = "Televisor LG LED 50\"",
                    Price = 999,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                },
                new Product()
                {
                    Id = 15,
                    BrandName = "LG",
                    DetailName = "Televisor LG LED 60\"",
                    Price = 1899,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                });
        }
    }
}
