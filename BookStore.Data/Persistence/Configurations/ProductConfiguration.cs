using BookStore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Name).IsRequired();
            builder.Property(u => u.Price).IsRequired();
            builder.Property(u => u.Details).IsRequired();
            builder.Property(u => u.StockAmount).IsRequired();
            builder.Property(u => u.CreatedAt).IsRequired();
            builder.Property(u => u.IsConfirmed).IsRequired();
            builder.Property(u => u.Enabled).IsRequired();
            builder.Property(u => u.CategoryId).IsRequired();
        }
    }
}