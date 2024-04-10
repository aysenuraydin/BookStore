using BookStore.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data.SeedDatas;
public static class TestDataSeeder
{
  public static void SeedData(this ModelBuilder modelBuilder)
  {

    modelBuilder.Entity<Category>().HasData(
        new List<Category>() {
           new() { Id=1, Name="Yelek", Color="	#a4b2b0"},
           new() { Id=2, Name="Triko", Color="	#896863	"},
           new() { Id=3, Name="Sweatshirt", Color="#C27D42	"},
           new() { Id=4, Name="Şort", Color="	#BF8882	"},
           new() { Id=5, Name="Kazak", Color="	#A4B2B0	"},
           new() { Id=6, Name="Elbise", Color="#828DE5"},
           new() { Id=7, Name="Ceket", Color="#595B56	"},
           new() { Id=8, Name="Pantolon", Color="	#CDC6C3	"},
           new() { Id=9, Name="Etek", Color="#DEBDB0"},
           new() { Id=10, Name="Bluz", Color="	#BE969B	"}
        }
    );

    modelBuilder.Entity<Product>().HasData(
      new List<Product>() {
           new Product { Id=1, Name="Yelek 1", Price=619, Details="ürün açıklama", StockAmount=10, Enabled=true, IsConfirmed= true, CategoryId=1},
           new Product { Id=2, Name="Yelek 2", Price=619, Details="ürün açıklama", StockAmount=10, Enabled=false, IsConfirmed= true, CategoryId=1},
           new Product { Id=3, Name="Yelek 3", Price=510, Details="ürün açıklama", StockAmount=10, Enabled=true, IsConfirmed= true, CategoryId=1},

           new Product { Id=4, Name="Triko 1", Price=700, Details="ürün açıklama", StockAmount=10, Enabled=true, IsConfirmed= true, CategoryId=2},
           new Product { Id=5, Name="Triko 2", Price=700, Details="ürün açıklama", StockAmount=10, Enabled=false, IsConfirmed= true, CategoryId=2},
           new Product { Id=6, Name="Triko 3", Price=700, Details="ürün açıklama", StockAmount=10, Enabled=false, IsConfirmed= true, CategoryId=2},

           new Product { Id=7, Name="Sweatshirt 1", Price=320, Details="ürün açıklama", StockAmount=10, Enabled=true, IsConfirmed= true, CategoryId=3},
           new Product { Id=8, Name="Sweatshirt 2", Price=450, Details="ürün açıklama", StockAmount=10, Enabled=false, IsConfirmed= true, CategoryId=3},
           new Product { Id=9, Name="Sweatshirt 3", Price=600, Details="ürün açıklama", StockAmount=10, Enabled=true, IsConfirmed= true, CategoryId=3}
}
   );
    /**/
    modelBuilder.Entity<ProductComment>().HasData(
        new ProductComment { Id = 1, Text = "Great product!", StarCount = 5, ProductId = 1, IsConfirmed = true },
        new ProductComment { Id = 2, Text = "Great product!", StarCount = 5, ProductId = 2, IsConfirmed = true },
        new ProductComment { Id = 3, Text = "Great product!", StarCount = 3, ProductId = 3, IsConfirmed = true },
        new ProductComment { Id = 4, Text = "Great product!", StarCount = 5, ProductId = 4, IsConfirmed = true },
        new ProductComment { Id = 5, Text = "Great product!", StarCount = 5, ProductId = 5, IsConfirmed = true },
        new ProductComment { Id = 6, Text = "Great product!", StarCount = 1, ProductId = 6, IsConfirmed = true },
        new ProductComment { Id = 7, Text = "Great product!", StarCount = 5, ProductId = 7, IsConfirmed = true }
    );

    modelBuilder.Entity<ProductImage>().HasData(
        new ProductImage { Id = 1, Url = "yelek-01.jpg", ProductId = 1 },
        new ProductImage { Id = 2, Url = "yelek-02.jpg", ProductId = 2 },
        new ProductImage { Id = 3, Url = "yelek-03.jpg", ProductId = 3 },

        new ProductImage { Id = 4, Url = "triko-01.jpg", ProductId = 4 },
        new ProductImage { Id = 5, Url = "triko-02.jpg", ProductId = 5 },
        new ProductImage { Id = 6, Url = "triko-03.jpg", ProductId = 6 },

        new ProductImage { Id = 7, Url = "sweatshirt-01.jpg", ProductId = 7 },
        new ProductImage { Id = 8, Url = "sweatshirt-02.jpg", ProductId = 8 },
        new ProductImage { Id = 9, Url = "sweatshirt-03.jpg", ProductId = 9 }
    );


  }

}


