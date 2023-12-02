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
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new HomeIndexViewModel
            {
                Products = ProductRepository.GetProducts()
            };
            return View(model);
        }

        public IActionResult SingleProduct()
        {
            return View();
        }
    }
}

