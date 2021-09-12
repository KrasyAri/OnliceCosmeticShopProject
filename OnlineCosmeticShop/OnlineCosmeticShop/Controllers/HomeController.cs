namespace OnlineCosmeticShop.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using OnlineCosmeticShop.Models;
    using OnlineCosmeticShop.Models.Home;
    using OnlineCosmeticShop.Services.Prodicts;
    using System.Diagnostics;
    using System.Linq;

    public class HomeController : Controller
    {
        private readonly IProductService products;

        public HomeController(IProductService products) => this.products = products;

        public IActionResult Index()
        {
            var newestProducts = this.products
                .NewestProducts()
                .ToList();


            return View(new IndexViewModel
            {
                Products = newestProducts
            });

        }

        public IActionResult Contacts() => View();

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
