using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fruitkha_task.Data;
using fruitkha_task.Entities;
using fruitkha_task.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace fruitkha_task.Controllers
{
    public class NewsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new NewsIndexViewModel
            {
                News = NewsRepository.GetNews()
            };
            return View(model);
        }

        public IActionResult SingleNews(int id)
        {
            var news = NewsRepository.GetNews().FirstOrDefault(x => x.Id == id);

            var model2 = new SingleNewsViewModel
            {
                SingleNews = news
            };
            return View(model2);
        }
    }
}

