using System;
using fruitkha_task.Entities;

namespace fruitkha_task.Data
{
	public class NewsRepository
	{
		private static List<News> news = new()
		{
			new(){Id=1, ImgPath="~/img/latest-news/news-bg-1.jpg",Title="You will vainly look for fruit on it in autumn.", Author="Admin", PostDate = DateTime.Now, Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatibus laborum autem, dolores inventore, beatae nam."},
            new(){Id=2, ImgPath="~/img/latest-news/news-bg-2.jpg",Title="A man's worth has its season, like tomato.", Author="Admin", PostDate = DateTime.Now, Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatibus laborum autem, dolores inventore, beatae nam."},
            new(){Id=3, ImgPath="~/img/latest-news/news-bg-3.jpg",Title="Good thoughts bear good fresh juicy fruit.", Author="Admin", PostDate = DateTime.Now, Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatibus laborum autem, dolores inventore, beatae nam."},
            new(){Id=4, ImgPath="~/img/latest-news/news-bg-4.jpg",Title="Fall in love with the fresh orange.", Author="Admin", PostDate = DateTime.Now, Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatibus laborum autem, dolores inventore, beatae nam."},
            new(){Id=5, ImgPath="~/img/latest-news/news-bg-5.jpg",Title="Why the berries always look delecious.", Author="Admin", PostDate = DateTime.Now, Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatibus laborum autem, dolores inventore, beatae nam."},
            new(){Id=6, ImgPath="~/img/latest-news/news-bg-6.jpg",Title="Love for fruits are genuine of John Doe.", Author="Admin", PostDate = DateTime.Now, Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatibus laborum autem, dolores inventore, beatae nam."},

        };

        public static List<News> GetNews()
        {
            return news;
        }
	}
}

