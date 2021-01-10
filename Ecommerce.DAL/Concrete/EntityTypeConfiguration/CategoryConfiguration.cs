using Ecommerce.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.DAL.Concrete.EntityTypeConfiguration
{
    class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(a => a.ID);
            builder.Property(a => a.ID).UseIdentityAlwaysColumn();
            builder.Property(a => a.CategoryName).HasMaxLength(100).IsRequired();
            builder.Property(a => a.Description).HasMaxLength(250).IsRequired();
           

            builder.HasData(new Category
            {
                ID = 1,
                CategoryName = "Cep Telefonu",
                Description = "İletişim Aracı",


            },
            new Category {
            ID=2,
            CategoryName="Bilgisayar",
            Description="Teknoloji",
            
            });
        }
    }
}
