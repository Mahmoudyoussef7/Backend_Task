using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().Property(p=>p.SKU).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Product>().Property(p=>p.Description).HasMaxLength(200);
            modelBuilder.Entity<Product>().Property(p=>p.Quantity).IsRequired();
            modelBuilder.Entity<Product>().Property(p=>p.Price).IsRequired();
            modelBuilder.Entity<Product>().Property(p=>p.IsActive).IsRequired();



            modelBuilder.Entity<Product>().HasData(new Product[] {
                new Product {ID = 1, SKU = "Product1",Description="Product 1 Description",Quantity=5,Price=100.00f,IsActive=true},
                new Product {ID = 2, SKU = "Product2",Description="Product 2 Description",Quantity=7,Price=150.00f,IsActive=true},
                new Product {ID = 3, SKU = "Product3",Description="Product 3 Description",Quantity=15,Price=190.00f,IsActive=true},
                new Product {ID = 4, SKU = "Product4",Description="Product 4 Description",Quantity=9,Price=220.00f,IsActive=true},
                new Product {ID = 5, SKU = "Product5",Description="Product 5 Description",Quantity=13,Price=520.00f,IsActive=true},
            });

            base.OnModelCreating(modelBuilder);
        }


    }
}
