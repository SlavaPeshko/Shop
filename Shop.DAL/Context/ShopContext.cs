using System.Data.Entity;
using Shop.Common.Models;
using Shop.DAL.Migrations.Configuration;

namespace Shop.DAL.Context
{
	public class ShopContext : DbContext
	{
		public ShopContext() : base("ShopContext")
		{
			
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Cart> Carts { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new ProductConfiguration());
			modelBuilder.Configurations.Add(new CategoryConfiguration());
			modelBuilder.Configurations.Add(new CartConfiguration());
			modelBuilder.Configurations.Add(new UserConfiguration());
		}
	}
}