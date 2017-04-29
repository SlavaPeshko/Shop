using System.Data.Entity;
using Shop.Common.Model;
using Shop.DAL.Migrations.Configuration;

namespace Shop.DAL.Context
{
	public class ShopContext : DbContext
	{
		public ShopContext() : base("ShopContext")
		{
			
		}

		public DbSet<Gadget> Gadgets { get; set; }
		public DbSet<Category> Categories { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new GadgetConfiguration());
			modelBuilder.Configurations.Add(new CategoryConfiguration());
		}
	}
}