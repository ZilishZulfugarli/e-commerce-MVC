using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using fruitkha_task.Models;
using fruitkha_task.Data;
namespace fruitkha_task.Controllers {

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomeIndexViewModel
            {
                Products = ProductRepository.GetProducts()
            };
            return View(model);
        }

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
