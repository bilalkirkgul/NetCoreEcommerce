using Ecommerce.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.DAL.Concrete.EntityTypeConfiguration
{
    class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.ToTable("Supplier");
            builder.HasKey(a => a.ID);
            builder.Property(a => a.ID).UseIdentityAlwaysColumn();
            builder.Property(a => a.CompanyName).HasMaxLength(100).IsRequired();
            builder.Property(a => a.PhoneNummer).HasMaxLength(18);
            builder.Property(a => a.Address).HasMaxLength(150);
           

            builder.HasData(new Supplier
            {
                ID = 1,
                CompanyName = "Apple Teknoloji ve Satış Limited Şirketi",
                Address = "Büyükdere caddesi Levent 199. Kat 22 - 23 Şişli",
                City = "İstanbul",
                Country = "Türkiye",
                PhoneNummer = "02123982800",
                

            },
            new Supplier {
            ID=2,
            CompanyName= "Samsung Electronics Istanbul Pazarlama ve Ticaret Limited Şirketi",
            Address= "Flatofis İstanbul İş Merkezi Otakçılar Cad. No.78 K.3 No.B3 – K.4 No.59/1",
            City="İstanbul",
            Country="Türkiye",
            PhoneNummer= "08502010222",
            });

        }
    }
}
