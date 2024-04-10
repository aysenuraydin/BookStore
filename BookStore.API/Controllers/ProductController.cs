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
                entity.IsConfirmed = p.IsConfirmed;
                entity.Enabled = p.Enabled;
                entity.CategoryId = p.CategoryId;
                entity.ProductImageCount = p.ProductImages.Count;
                entity.ProductCommentCount = p.ProductComments.Count;
            }
            return entity;
        }


    }
}






