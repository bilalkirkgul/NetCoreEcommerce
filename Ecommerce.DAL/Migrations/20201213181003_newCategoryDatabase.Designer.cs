﻿// <auto-generated />
using System;
using Ecommerce.DAL.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Ecommerce.DAL.Migrations
{
    [DbContext(typeof(EcommerceDbContext))]
    [Migration("20201213181003_newCategoryDatabase")]
    partial class newCategoryDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Ecommerce.Model.Entities.Brand", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityAlwaysColumn();

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.HasKey("ID");

                    b.ToTable("Brand");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            BrandName = "Iphone",
                            CreatedDate = new DateTime(2020, 12, 13, 21, 10, 3, 142, DateTimeKind.Local).AddTicks(6834),
                            Description = "İos",
                            IsActive = true
                        },
                        new
                        {
                            ID = 2,
                            BrandName = "Samsung",
                            CreatedDate = new DateTime(2020, 12, 13, 21, 10, 3, 142, DateTimeKind.Local).AddTicks(7774),
                            Description = "Android",
                            IsActive = true
                        });
                });

            modelBuilder.Entity("Ecommerce.Model.Entities.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityAlwaysColumn();

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.HasKey("ID");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryName = "Cep Telefonu",
                            CreatedDate = new DateTime(2020, 12, 13, 21, 10, 3, 116, DateTimeKind.Local).AddTicks(5091),
                            Description = "İletişim Aracı",
                            IsActive = true
                        },
                        new
                        {
                            ID = 2,
                            CategoryName = "Bilgisayar",
                            CreatedDate = new DateTime(2020, 12, 13, 21, 10, 3, 117, DateTimeKind.Local).AddTicks(4297),
                            Description = "Teknoloji",
                            IsActive = true
                        });
                });

            modelBuilder.Entity("Ecommerce.Model.Entities.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityAlwaysColumn();

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("OrderState")
                        .HasColumnType("integer");

                    b.Property<int>("PaymentTypes")
                        .HasColumnType("integer");

                    b.Property<string>("ShipAddress")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Ecommerce.Model.Entities.OrderDetail", b =>
                {
                    b.Property<int>("ProductID")
                        .HasColumnType("integer");

                    b.Property<int>("OrderID")
                        .HasColumnType("integer");

                    b.Property<double>("Discount")
                        .HasColumnType("double precision");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<short>("Quantity")
                        .HasColumnType("smallint");

                    b.HasKey("ProductID", "OrderID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("Ecommerce.Model.Entities.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityAlwaysColumn();

                    b.Property<int>("BrandID")
                        .HasColumnType("integer");

                    b.Property<int>("CategoryID")
                        .HasColumnType("integer");

                    b.Property<bool>("Continued")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("DisCounted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<string>("ProductImgUrl")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<short>("Stock")
                        .HasColumnType("smallint");

                    b.Property<int>("SupplierID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("BrandID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("SupplierID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Ecommerce.Model.Entities.Supplier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityAlwaysColumn();

                    b.Property<string>("Address")
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("PhoneNummer")
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)");

                    b.HasKey("ID");

                    b.ToTable("Supplier");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "Büyükdere caddesi Levent 199. Kat 22 - 23 Şişli",
                            City = "İstanbul",
                            CompanyName = "Apple Teknoloji ve Satış Limited Şirketi",
                            Country = "Türkiye",
                            CreatedDate = new DateTime(2020, 12, 13, 21, 10, 3, 134, DateTimeKind.Local).AddTicks(5155),
                            IsActive = true,
                            PhoneNummer = "02123982800"
                        },
                        new
                        {
                            ID = 2,
                            Address = "Flatofis İstanbul İş Merkezi Otakçılar Cad. No.78 K.3 No.B3 – K.4 No.59/1",
                            City = "İstanbul",
                            CompanyName = "Samsung Electronics Istanbul Pazarlama ve Ticaret Limited Şirketi",
                            Country = "Türkiye",
                            CreatedDate = new DateTime(2020, 12, 13, 21, 10, 3, 134, DateTimeKind.Local).AddTicks(7081),
                            IsActive = true,
                            PhoneNummer = "08502010222"
                        });
                });

            modelBuilder.Entity("Ecommerce.Model.Entities.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityAlwaysColumn();

                    b.Property<Guid>("ActivationCode")
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ActivationCode = new Guid("00000000-0000-0000-0000-000000000000"),
                            Address = "Maltepe",
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2020, 12, 13, 21, 10, 3, 140, DateTimeKind.Local).AddTicks(9486),
                            Email = "bilal.kirkgul@gmail.com",
                            FirstName = "Bilal",
                            IsActive = true,
                            LastName = "Kırkgül",
                            Password = "123",
                            Role = 2
                        });
                });

            modelBuilder.Entity("Ecommerce.Model.Entities.Order", b =>
                {
                    b.HasOne("Ecommerce.Model.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Ecommerce.Model.Entities.OrderDetail", b =>
                {
                    b.HasOne("Ecommerce.Model.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.Model.Entities.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Ecommerce.Model.Entities.Product", b =>
                {
                    b.HasOne("Ecommerce.Model.Entities.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.Model.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.Model.Entities.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Ecommerce.Model.Entities.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Ecommerce.Model.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Ecommerce.Model.Entities.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Ecommerce.Model.Entities.Product", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Ecommerce.Model.Entities.Supplier", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Ecommerce.Model.Entities.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
