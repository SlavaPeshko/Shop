using System.Data.Entity.ModelConfiguration;
using Shop.Common.Models;

namespace Shop.DAL.Migrations.Configuration
{
	public class CategoryConfiguration : EntityTypeConfiguration<Category>
	{
		public CategoryConfiguration()
		{
			ToTable("Categories");
			Property(n => n.Name).IsRequired().HasMaxLength(50);
		}
	}
}