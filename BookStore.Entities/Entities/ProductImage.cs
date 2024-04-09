using BookStore.Entities.Abstract;
using System;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Entities;
public class ProductImage : BaseEntity
{
    [Display(Name = "Ürün URL")]
    [Required(ErrorMessage = "Ürün URL alanı gereklidir.")]
    [MinLength(10, ErrorMessage = "Ürün URL en az 10 karakterden oluşmalıdır.")]
    [MaxLength(250, ErrorMessage = "Ürün URL en fazla 250 karakter uzunluğunda olmalıdır.")]
    [DataType(DataType.Url, ErrorMessage = "Geçersiz URL formatı.")]
    public string? Url { get; set; } = Guid.NewGuid().ToString();

    [Display(Name = "Oluşturma Tarihi")]
    [Required(ErrorMessage = "Oluşturma tarihi alanı gereklidir.")]
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    [Display(Name = "Ürün")]
    [Required(ErrorMessage = "Ürün alanı gereklidir.")]
    public int ProductId { get; set; }

    #region Navigation Properties
    public Product ProductFk { get; set; } = null!;
    #endregion
}
