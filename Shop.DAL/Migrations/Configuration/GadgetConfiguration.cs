using System.Data.Entity.ModelConfiguration;
using Shop.Common.Models;

namespace Shop.DAL.Migrations.Configuration
{
	public class ProductConfiguration : EntityTypeConfiguration<Product>
	{
		public ProductConfiguration()
		{
			ToTable("Gadgets");
			Property(n => n.Name).IsRequired().HasMaxLength(50);
			Property(n => n.Price).IsRequired().HasPrecision(8, 2);
			Property(n => n.CategoryId).IsRequired();
		}
	}
}