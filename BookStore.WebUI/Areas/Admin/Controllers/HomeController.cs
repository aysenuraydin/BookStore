using BookStore.DTO;
using BookStore.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;


namespace BookStore.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;

        public HomeController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5230/api/"); // API adresi
        }
        public async Task<IActionResult> Index()
        {
            using (var response = await _httpClient.GetAsync("product"))
            {
                List<ProductListDTO> products = await response.Content.ReadFromJsonAsync<List<ProductListDTO>>() ?? new();
                return View(products);

            }
        }

        public IActionResult Create()
        {
            return View(new Product());
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            try
            {
                var json = JsonSerializer.Serialize(product);

                var response = await _httpClient.PostAsync("product", new StringContent(json, Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                    var newProduct = await response.Content.ReadFromJsonAsync<Product>();

                    return RedirectToAction("Edit", new { id = newProduct?.Id });
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();

                    ViewBag.Error = error;
                    return View("Error");
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View("Error");
            }
        }
        public async Task<IActionResult> Edit(int id)
        {
            using (var response = await _httpClient.GetAsync($"product/{id}"))
            {
                Product products = await response.Content.ReadFromJsonAsync<Product>() ?? new();
                return View(products);

            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Product product)
        {
            try
            {
                var json = JsonSerializer.Serialize(product);

                var response = await _httpClient.PutAsync($"product/{product.Id}", new StringContent(json, Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                    var updatedProduct = await response.Content.ReadFromJsonAsync<Product>();
                    return RedirectToAction("Index", new { id = updatedProduct?.Id });
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();

                    ViewBag.Error = error;
                    return View("Error");
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View("Error");
            }
        }
        //!view olmayacak ileridde burayı kaldır.
        public async Task<IActionResult> Delete(int id)
        {
            using (var response = await _httpClient.GetAsync($"product/{id}"))
            {
                Product products = await response.Content.ReadFromJsonAsync<Product>() ?? new();
                return View(products);

            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, string s)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"product/{id}");

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("Error");
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View("Error");
            }
        }

    }
}

