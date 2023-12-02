using System;
using Microsoft.AspNetCore.Mvc;
using fruitkha_task.Entities;
using fruitkha_task.Models;

namespace fruitkha_task.Views.Shared.Components.Newsl
{
	public class NewsViewComponent : ViewComponent
	{
        public IViewComponentResult Invoke(News news)
        {
            return View(news);
        }

    }
}

