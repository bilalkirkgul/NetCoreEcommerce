using Ecommerce.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.DAL.Concrete.EntityTypeConfiguration
{
    class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(a => a.ID);
            builder.Property(a => a.ID).UseIdentityAlwaysColumn();
            builder.Property(a => a.ProductName).HasMaxLength(100).IsRequired();
            builder.Property(a => a.Description).HasMaxLength(100).IsRequired();
            builder.Property(a => a.ProductImgUrl).HasMaxLength(256);
            builder.Property(a => a.Price).HasPrecision(10, 2);

           

        }
    }
}
