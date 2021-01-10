using Ecommerce.DAL.Concrete.EntityTypeConfiguration;
using Ecommerce.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.DAL.Concrete
{
    class EcommerceDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres; Password=1234; Server=localhost; Database=NetCoreEcommerceDB");
            base.OnConfiguring(optionsBuilder);
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Brand> Brands { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new BrandConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
