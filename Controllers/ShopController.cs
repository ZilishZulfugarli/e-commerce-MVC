using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fruitkha_task.Data;
using fruitkha_task.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace fruitkha_task.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ShopController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var products = _dbContext.Product.ToList();
            var model = new ViewModel
            {
                Products = products
            };
            return View(model);
        }

        public IActionResult SingleProduct()
        {
            return View();
        }
    }
}

