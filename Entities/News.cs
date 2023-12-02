using System;
namespace fruitkha_task.Entities
{
	public class News
	{
		public int Id { get; set; }
		public string? Title { get; set; }
		public string? Author { get; set; }
		public DateTime PostDate { get; set; }
		public string? Text { get; set; }
		public string? ImgPath { get; set; }
	}
}

