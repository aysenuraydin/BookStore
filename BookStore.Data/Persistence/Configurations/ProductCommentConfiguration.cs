using BookStore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Data.Configurations
{
    public class ProductCommentConfiguration : IEntityTypeConfiguration<ProductComment>
    {
        public void Configure(EntityTypeBuilder<ProductComment> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.StarCount).IsRequired();
            builder.Property(u => u.IsConfirmed).IsRequired();
            builder.Property(u => u.CreatedAt).IsRequired();
            builder.Property(u => u.ProductId).IsRequired();
        }
    }
}