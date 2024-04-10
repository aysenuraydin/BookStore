using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http;
using BookStore.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;


namespace BookStore.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            ProductListDTO products = new();

            using (var httpClient = new HttpClient())//bunu bir çok yerde kullanacağpımız içi bu usingleri yukarıya koy  gbt örneğindeki gibi
            {
                //
                using (var response = await httpClient.GetAsync("http://localhost:5230/api/product/3"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        //string apiResponse = await response.Content.ReadAsStringAsync();
                        //var product2s = JsonConvert.DeserializeObject<ProductListDTO>(apiResponse);
                        var p = await response.Content.ReadFromJsonAsync<ProductListDTO>();
                        return View(p);
                    }
                }

                return View(products);

            }
        }
    }
}