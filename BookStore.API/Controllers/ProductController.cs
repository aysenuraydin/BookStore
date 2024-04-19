using BookStore.Business.Abstract;
using BookStore.DTO;
using BookStore.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productService;

        public ProductController(IProductRepository productService)
        {
            _productService = productService;
        }
        //!bu şemalara gerçekten gerek var mıydı? örnkeprojede direk product sınıfı kullanılmış? Düşün
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            //!role göre listelene ürünleri değiştir kullanıclar onaylamamış ürünleri göremesin admin görsün
            var products = await _productService
                                    .GetAllIncludeAsync(
                                         p => p.Categories,
                                        p => p.ProductComments,
                                        p => p.ProductImages
                                    );

            var product = products.AsQueryable();
            var prd = product
                        .Select(p => ProductListToDTO(p));
            return Ok(prd);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _productService
                                    .GetAllIncludeAsync(
                                        p => p.ProductComments,
                                        p => p.ProductImages
                                    );

            var product = products.AsQueryable();
            var prd = product
                        .Select(p => ProductListToDTO(p))
                        .FirstOrDefault(p => p.Id == id);


            if (prd == null)
            {
                return NotFound(); // 404
            }
            return Ok(prd); // 200

        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductCreateDTO entity)
        {
            Product p = ProductCreateToDTO(entity);
            await _productService.AddAsync(p);

            return CreatedAtAction(nameof(GetProduct), new { id = p.Id }, p);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, ProductUpdateDTO p)
        {
            if (id != p.Id)
            {
                return BadRequest();
            }

            var product = await _productService.GetAsync(i => i.Id == id);

            if (product == null)
            {
                return NotFound();
                //return StatusCode(500, "Güncelleme işlemi sırasında bir hata oluştu."); bu şekilde de hata gönderebiliriz
            }
            try
            {
                await _productService.UpdateAsync(ProductUpdateToDTO(p, product));
            }
            catch (Exception)
            {
                return NotFound();
            }

            //return NoContent(); bir şey döndürmesin istiyorsak
            // return CreatedAtAction(nameof(GetProduct), product);
            return Ok(product);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _productService.GetAsync(i => i.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            try
            {
                await _productService.DeleteAsync(product);
            }
            catch (Exception)
            {
                return NotFound();
            }
            return NoContent();
        }


        private static ProductListDTO ProductListToDTO(Product p)
        {
            ProductListDTO entity = new();
            if (p != null)
            {
                entity.Id = p.Id;
                entity.Name = p.Name;
                entity.Price = p.Price;
                entity.Details = p.Details;
                entity.StockAmount = p.StockAmount;
                entity.CreatedAt = p.CreatedAt;
                entity.Enabled = p.Enabled;
                entity.CategoryId = p.CategoryId;
                entity.ProductImageCount = p.ProductImages.Count;
                entity.ProductCommentCount = p.ProductComments.Count;
            }
            return entity;
        }
        private static Product ProductCreateToDTO(ProductCreateDTO p)
        {
            Product entity = new();
            if (p != null)
            {
                entity.Name = p.Name;
                entity.Price = p.Price;
                entity.Details = p.Details;
                entity.StockAmount = p.StockAmount;
                entity.Enabled = p.Enabled;
                entity.CategoryId = p.CategoryId;
            }
            return entity;
        }

        private static Product ProductUpdateToDTO(ProductUpdateDTO p, Product entity)
        {
            if (p != null)
            {
                entity.Id = p.Id;
                entity.Name = p.Name;
                entity.Price = p.Price;
                entity.Details = p.Details;
                entity.StockAmount = p.StockAmount;
                entity.Enabled = p.Enabled;
                entity.CategoryId = p.CategoryId;
            }
            return entity;
        }
    }
}






