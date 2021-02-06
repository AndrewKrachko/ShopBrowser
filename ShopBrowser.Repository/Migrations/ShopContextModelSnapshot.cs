﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopBrowser.Repository;

namespace ShopBrowser.Repository.Migrations
{
    [DbContext(typeof(ShopContext))]
    partial class ShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("ShopBrowser.Repository.ShopEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CloseTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OpenTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ShopEntities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CloseTime = new DateTime(2021, 2, 6, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "eMobile Shop",
                            Name = "eMobile",
                            OpenTime = new DateTime(2021, 2, 6, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CloseTime = new DateTime(2021, 2, 6, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Кандаловъ Shop",
                            Name = "Кандаловъ",
                            OpenTime = new DateTime(2021, 2, 6, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CloseTime = new DateTime(2021, 2, 6, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "MEX Shop",
                            Name = "MEX",
                            OpenTime = new DateTime(2021, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CloseTime = new DateTime(2021, 2, 6, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "патриот Shop",
                            Name = "патриот",
                            OpenTime = new DateTime(2021, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CloseTime = new DateTime(2021, 2, 6, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Hot-Line Shop",
                            Name = "Hot-Line",
                            OpenTime = new DateTime(2021, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
