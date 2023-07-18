﻿// <auto-generated />
using System;
using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BusinessObject.Migrations
{
    [DbContext(typeof(MyDBContext))]
    partial class MyDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BussinessObject.Models.Book", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PressId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PressId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BussinessObject.Models.Press", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Presss");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = 0,
                            Name = "Beverages"
                        },
                        new
                        {
                            Id = 2,
                            Category = 0,
                            Name = "Condiments"
                        },
                        new
                        {
                            Id = 3,
                            Category = 0,
                            Name = "Confections"
                        },
                        new
                        {
                            Id = 4,
                            Category = 0,
                            Name = "Dairy Products"
                        },
                        new
                        {
                            Id = 5,
                            Category = 0,
                            Name = "Grains/Cereals"
                        },
                        new
                        {
                            Id = 6,
                            Category = 0,
                            Name = "Meat/Cereals"
                        },
                        new
                        {
                            Id = 7,
                            Category = 0,
                            Name = "Produce"
                        },
                        new
                        {
                            Id = 8,
                            Category = 0,
                            Name = "Seafood"
                        });
                });

            modelBuilder.Entity("BussinessObject.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin",
                            Password = "x3Xnt1ft5jDNCqERO9ECZhqziCnKUqZCKreChi8mhkY=",
                            Role = 0,
                            Username = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "User",
                            Password = "x3Xnt1ft5jDNCqERO9ECZhqziCnKUqZCKreChi8mhkY=",
                            Role = 1,
                            Username = "User"
                        });
                });

            modelBuilder.Entity("BussinessObject.Models.Book", b =>
                {
                    b.HasOne("BussinessObject.Models.Press", "Press")
                        .WithMany("Books")
                        .HasForeignKey("PressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("BussinessObject.Models.Address", "Location", b1 =>
                        {
                            b1.Property<int>("BookId")
                                .HasColumnType("int");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("BookId");

                            b1.ToTable("Books");

                            b1.WithOwner()
                                .HasForeignKey("BookId");
                        });

                    b.Navigation("Location");

                    b.Navigation("Press");
                });

            modelBuilder.Entity("BussinessObject.Models.Press", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
