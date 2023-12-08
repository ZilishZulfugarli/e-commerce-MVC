using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using fruitkha_task.Models;
using fruitkha_task.Data;
namespace fruitkha_task.Controllers {

    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {

            var products = _dbContext.Product.ToList();
            var news = _dbContext.News.ToList();
            var model = new ViewModel
            {
                Products = products,
                News = news
            };
            _dbContext.SaveChanges();
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
