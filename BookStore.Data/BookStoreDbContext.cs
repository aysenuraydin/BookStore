

using System.Runtime.CompilerServices;
using BookStore.Entities;
using BookStore.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using System.Reflection;
using BookStore.Data.SeedDatas;


namespace BookStore.Data;
public class BookStoreDbContext : DbContext
{
    public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options)
    {
        // Eğer veritabanı oluşturulurken test verilerini eklemek istiyorsanız:
        // Database.EnsureCreated();
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductComment> ProductComments { get; set; }
    public DbSet<ProductImage> ProductImages { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        base.OnConfiguring(builder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.SeedData();
        base.OnModelCreating(modelBuilder);
    }
}