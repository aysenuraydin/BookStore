using BookStore.Entities.Abstract;
using System;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Entities;
public class ProductComment : BaseEntity
{
    [Display(Name = "Ürün Yorumu")]
    [Required(ErrorMessage = "Ürün yorumu alanı gereklidir.")]
    [MinLength(2, ErrorMessage = "Ürün yorumu en az 2 karakterden oluşmalıdır.")]
    [MaxLength(500, ErrorMessage = "Ürün yorumu en fazla 500 karakter uzunluğunda olmalıdır.")]
    public string? Text { get; set; }

    [Display(Name = "Ürün Puanı")]
    [Required(ErrorMessage = "Ürün puanı alanı gereklidir.")]
    [Range(1, 5, ErrorMessage = "Ürün puanı 1 ile 5 arasında olmalıdır.")]
    public byte StarCount { get; set; }

    [Display(Name = "Onaylı Mı?")]
    [Required(ErrorMessage = "Onaylı mı alanı gereklidir.")]
    public bool IsConfirmed { get; set; } = false;

    [Display(Name = "Oluşturma Tarihi")]
    [Required(ErrorMessage = "Oluşturma tarihi alanı gereklidir.")]
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "Ürün alanı gereklidir.")]
    public int ProductId { get; set; }

    #region Navigation Properties
    public Product? ProductFk { get; set; } = null!;
    #endregion
}

