﻿// <auto-generated />
using System;
using BookStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStore.API.Migrations
{
    [DbContext(typeof(BookStoreDbContext))]
    partial class BookStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("BookStore.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("IconCssClass")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "	#a4b2b0",
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(7920),
                            Name = "Yelek"
                        },
                        new
                        {
                            Id = 2,
                            Color = "	#896863	",
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(7970),
                            Name = "Triko"
                        },
                        new
                        {
                            Id = 3,
                            Color = "#C27D42	",
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(7970),
                            Name = "Sweatshirt"
                        },
                        new
                        {
                            Id = 4,
                            Color = "	#BF8882	",
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(7970),
                            Name = "Şort"
                        },
                        new
                        {
                            Id = 5,
                            Color = "	#A4B2B0	",
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(7970),
                            Name = "Kazak"
                        },
                        new
                        {
                            Id = 6,
                            Color = "#828DE5",
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(7980),
                            Name = "Elbise"
                        },
                        new
                        {
                            Id = 7,
                            Color = "#595B56	",
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(7980),
                            Name = "Ceket"
                        },
                        new
                        {
                            Id = 8,
                            Color = "	#CDC6C3	",
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(7980),
                            Name = "Pantolon"
                        },
                        new
                        {
                            Id = 9,
                            Color = "#DEBDB0",
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(7980),
                            Name = "Etek"
                        },
                        new
                        {
                            Id = 10,
                            Color = "	#BE969B	",
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(7980),
                            Name = "Bluz"
                        });
                });

            modelBuilder.Entity("BookStore.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<bool>("Enabled")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<byte>("StockAmount")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8030),
                            Details = "ürün açıklama",
                            Enabled = true,
                            IsConfirmed = true,
                            Name = "Yelek 1",
                            Price = 619m,
                            StockAmount = (byte)10
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8040),
                            Details = "ürün açıklama",
                            Enabled = false,
                            IsConfirmed = true,
                            Name = "Yelek 2",
                            Price = 619m,
                            StockAmount = (byte)10
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8040),
                            Details = "ürün açıklama",
                            Enabled = true,
                            IsConfirmed = true,
                            Name = "Yelek 3",
                            Price = 510m,
                            StockAmount = (byte)10
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8050),
                            Details = "ürün açıklama",
                            Enabled = true,
                            IsConfirmed = true,
                            Name = "Triko 1",
                            Price = 700m,
                            StockAmount = (byte)10
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8050),
                            Details = "ürün açıklama",
                            Enabled = false,
                            IsConfirmed = true,
                            Name = "Triko 2",
                            Price = 700m,
                            StockAmount = (byte)10
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8050),
                            Details = "ürün açıklama",
                            Enabled = false,
                            IsConfirmed = true,
                            Name = "Triko 3",
                            Price = 700m,
                            StockAmount = (byte)10
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8050),
                            Details = "ürün açıklama",
                            Enabled = true,
                            IsConfirmed = true,
                            Name = "Sweatshirt 1",
                            Price = 320m,
                            StockAmount = (byte)10
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8060),
                            Details = "ürün açıklama",
                            Enabled = false,
                            IsConfirmed = true,
                            Name = "Sweatshirt 2",
                            Price = 450m,
                            StockAmount = (byte)10
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8060),
                            Details = "ürün açıklama",
                            Enabled = true,
                            IsConfirmed = true,
                            Name = "Sweatshirt 3",
                            Price = 600m,
                            StockAmount = (byte)10
                        });
                });

            modelBuilder.Entity("BookStore.Entities.ProductComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("StarCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductComments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8080),
                            IsConfirmed = true,
                            ProductId = 1,
                            StarCount = (byte)5,
                            Text = "Great product!"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8080),
                            IsConfirmed = true,
                            ProductId = 2,
                            StarCount = (byte)5,
                            Text = "Great product!"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8080),
                            IsConfirmed = true,
                            ProductId = 3,
                            StarCount = (byte)3,
                            Text = "Great product!"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8080),
                            IsConfirmed = true,
                            ProductId = 4,
                            StarCount = (byte)5,
                            Text = "Great product!"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8080),
                            IsConfirmed = true,
                            ProductId = 5,
                            StarCount = (byte)5,
                            Text = "Great product!"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8090),
                            IsConfirmed = true,
                            ProductId = 6,
                            StarCount = (byte)1,
                            Text = "Great product!"
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8090),
                            IsConfirmed = true,
                            ProductId = 7,
                            StarCount = (byte)5,
                            Text = "Great product!"
                        });
                });

            modelBuilder.Entity("BookStore.Entities.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8200),
                            ProductId = 1,
                            Url = "yelek-01.jpg"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8210),
                            ProductId = 2,
                            Url = "yelek-02.jpg"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8210),
                            ProductId = 3,
                            Url = "yelek-03.jpg"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8220),
                            ProductId = 4,
                            Url = "triko-01.jpg"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8220),
                            ProductId = 5,
                            Url = "triko-02.jpg"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8220),
                            ProductId = 6,
                            Url = "triko-03.jpg"
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8230),
                            ProductId = 7,
                            Url = "sweatshirt-01.jpg"
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8230),
                            ProductId = 8,
                            Url = "sweatshirt-02.jpg"
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2024, 4, 10, 0, 49, 49, 821, DateTimeKind.Local).AddTicks(8230),
                            ProductId = 9,
                            Url = "sweatshirt-03.jpg"
                        });
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.Property<int>("CategorysId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategorysId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("CategoryProduct");
                });

            modelBuilder.Entity("BookStore.Entities.ProductComment", b =>
                {
                    b.HasOne("BookStore.Entities.Product", "ProductFk")
                        .WithMany("ProductComments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductFk");
                });

            modelBuilder.Entity("BookStore.Entities.ProductImage", b =>
                {
                    b.HasOne("BookStore.Entities.Product", "ProductFk")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductFk");
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.HasOne("BookStore.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategorysId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStore.Entities.Product", b =>
                {
                    b.Navigation("ProductComments");

                    b.Navigation("ProductImages");
                });
#pragma warning restore 612, 618
        }
    }
}