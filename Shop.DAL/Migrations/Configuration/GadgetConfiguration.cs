using System.Data.Entity.ModelConfiguration;
using Shop.Common.Model;

namespace Shop.DAL.Migrations.Configuration
{
	public class GadgetConfiguration : EntityTypeConfiguration<Gadget>
	{
		public GadgetConfiguration()
		{
			ToTable("Gadgets");
			Property(n => n.Name).IsRequired().HasMaxLength(50);
			Property(n => n.Price).IsRequired().HasPrecision(8, 2);
			Property(n => n.CategoryId).IsRequired();
		}
	}
}