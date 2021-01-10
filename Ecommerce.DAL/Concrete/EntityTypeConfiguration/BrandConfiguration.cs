using Ecommerce.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.DAL.Concrete.EntityTypeConfiguration
{
    class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brand");
            builder.HasKey(a => a.ID);
            builder.Property(a => a.ID).UseIdentityAlwaysColumn();
            builder.Property(a => a.BrandName).HasMaxLength(100).IsRequired();
            builder.Property(a => a.Description).HasMaxLength(100).IsRequired();
   
            builder.HasData(new Brand
            {
            ID=1,
            BrandName="Iphone",
            Description="İos"

            },
            new Brand {
            ID=2,
            BrandName= "Samsung",
            Description="Android"
            
            });
        }
    }
}
