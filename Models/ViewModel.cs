using System;
using fruitkha_task.Entities;

namespace fruitkha_task.Models
{
	public class ViewModel
    {
            public List<Product> Products { get; set; }
            public List<News> News { get; set; }
            public News SingleNews { get; set; }
	}
}

