﻿// <auto-generated />
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221229210522_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("SKU")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Product 1 Description",
                            IsActive = true,
                            Price = 100f,
                            Quantity = 5,
                            SKU = "Product1"
                        },
                        new
                        {
                            ID = 2,
                            Description = "Product 2 Description",
                            IsActive = true,
                            Price = 150f,
                            Quantity = 7,
                            SKU = "Product2"
                        },
                        new
                        {
                            ID = 3,
                            Description = "Product 3 Description",
                            IsActive = true,
                            Price = 190f,
                            Quantity = 15,
                            SKU = "Product3"
                        },
                        new
                        {
                            ID = 4,
                            Description = "Product 4 Description",
                            IsActive = true,
                            Price = 220f,
                            Quantity = 9,
                            SKU = "Product4"
                        },
                        new
                        {
                            ID = 5,
                            Description = "Product 5 Description",
                            IsActive = true,
                            Price = 520f,
                            Quantity = 13,
                            SKU = "Product5"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
