using fruitkha_task.Entities;
using fruitkha_task.Models;
using fruitkha_task.Entities;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Views.Shared.Components.Shops
{
    public class ProductsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Product product)
        {
            return View(product);
        }
    }
}

