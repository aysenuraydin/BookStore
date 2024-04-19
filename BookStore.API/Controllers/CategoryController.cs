using BookStore.Business.Abstract;
using BookStore.DTO;
using BookStore.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryService;

        public CategoryController(ICategoryRepository categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _categoryService
                                    .GetAllAsync();
            return Ok(products);
        }
    }
}






