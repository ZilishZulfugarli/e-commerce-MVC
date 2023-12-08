using System;
using fruitkha_task.Entities;
using Microsoft.EntityFrameworkCore;
namespace fruitkha_task.Data

{
	public class AppDbContext : DbContext
	{
		public AppDbContext()
		{
		}
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}

		public DbSet<Product> Product { get; set; }
		public DbSet<News> News { get; set; }
		public DbSet<Contact> Contact { get; set; }
	}
}

