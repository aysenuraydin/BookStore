
using BookStore.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Entities;
public class Category : BaseEntity
{
    [MaxLength(100, ErrorMessage = "Kategori Adı en fazla 100 karakter olmalıdır."),
     MinLength(2, ErrorMessage = "Kategori Adı en az 2 karakter olmalıdır."),
     Display(Name = "Kategori Adı")]
    [Required(ErrorMessage = "Name alanı gereklidir.")]
    public string? Name { get; set; }

    [MaxLength(15, ErrorMessage = "Kategori Rengi en fazla 6 karakter olmalıdır."),
     MinLength(3, ErrorMessage = "Kategori Rengi en az 3 karakter olmalıdır."),
     Display(Name = "Kategori Rengi")]
    [Required(ErrorMessage = "Color alanı gereklidir.")]
    public string? Color { get; set; }

    [MaxLength(50, ErrorMessage = "Css en fazla 50 karakter olmalıdır."),
     MinLength(2, ErrorMessage = "Css en az 2 karakter olmalıdır."),
     Display(Name = "Css")]
    public string? IconCssClass { get; set; }

    [Display(Name = "Oluşturma Tarihi")]
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    #region Navigation Properties
    [Display(Name = "Kitaplar")]
    public List<Product> Products { get; set; } = new();
    #endregion
}