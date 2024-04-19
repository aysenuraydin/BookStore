using BookStore.DTO;
using BookStore.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ticaret.Web.Mvc.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        private readonly HttpClient _httpClient;

        public CategoriesViewComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5230/api/"); // API adresi
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            using (var response = await _httpClient.GetAsync("category"))
            {
                List<Category> products = await response.Content.ReadFromJsonAsync<List<Category>>() ?? new();
                return View(products.Take(5));

            }
        }

    }
}

