using System;
using fruitkha_task.Models;
using fruitkha_task.Entities;

namespace fruitkha_task.Data
{
	public class ProductRepository
	{
		private static List<Product> products = new()
		{
			new(){Id=1,Name="Strawberry",ImgPath="~/img/products/product-img-1.jpg", Price=85},
            new(){Id=2,Name="Berry",ImgPath="~/img/products/product-img-2.jpg", Price=70},
            new(){Id=3,Name="Lemon",ImgPath="~/img/products/product-img-3.jpg", Price=35},
            new(){Id=4,Name="Avacado",ImgPath="~/img/products/product-img-4.jpg", Price=50},
            new(){Id=5,Name="Green Apple",ImgPath="~/img/products/product-img-5.jpg", Price=45},
            new(){Id=6,Name="Strawberry",ImgPath="~/img/products/product-img-6.jpg", Price=80}
        };

		public static List<Product> GetProducts() { return products; }
	}
}

