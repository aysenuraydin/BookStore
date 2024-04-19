using BookStore.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Entities;
public class Product : BaseEntity
{
    [Display(Name = "Kitap Adı")]
    [MaxLength(100, ErrorMessage = "Kitap adı en fazla 100 karakter uzunluğunda olmalıdır.")]
    [MinLength(2, ErrorMessage = "Kitap adı en az 2 karakter uzunluğunda olmalıdır.")]
    [Required(ErrorMessage = "Kitap adı alanı gereklidir.")]
    public string Name { get; set; } = null!;

    [Display(Name = "Kitap Ücreti")]
    [DataType(DataType.Currency)]
    [Required(ErrorMessage = "Kitap ücreti alanı gereklidir.")]
    [Range(1, 1000000, ErrorMessage = "Kitap ücreti giriniz")]
    public decimal Price { get; set; }

    [Display(Name = "Kitap Açıklaması")]
    [MaxLength(100, ErrorMessage = "Kitap açıklaması en fazla 100 karakter uzunluğunda olmalıdır.")]
    [MinLength(2, ErrorMessage = "Kitap açıklaması en az 2 karakter uzunluğunda olmalıdır.")]
    [Required(ErrorMessage = "Kitap açıklaması alanı gereklidir.")]
    public string Details { get; set; } = null!;

    [Display(Name = "Stok Adedi")]
    [Required(ErrorMessage = "Stok adedi alanı gereklidir.")]
    [Range(1, 255, ErrorMessage = "Kitap adedi 1 ile 255 arasında olmalıdır.")]
    public byte StockAmount { get; set; }

    [Display(Name = "Oluşturma Tarihi")]
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    [Display(Name = "Satışta Mı?")]
    public bool Enabled { get; set; } = false;
    [Display(Name = "Kategori")]
    [Required(ErrorMessage = "Kategori alanı gereklidir.")]
    public int CategoryId { get; set; }

    #region Navigation Properties
    [Display(Name = "Kitap Categorileri")]
    public List<Category> Categories { get; set; } = new();
    [Display(Name = "Kitap Yorumları")]
    public List<ProductComment> ProductComments { get; set; } = new();
    [Display(Name = "Kitap Resimleri")]
    public List<ProductImage> ProductImages { get; set; } = new();

    #endregion
}



