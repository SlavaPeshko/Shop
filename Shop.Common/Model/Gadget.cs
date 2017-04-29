using Shop.Infra.Model;

namespace Shop.Common.Model
{
	public class Gadget : BaseEntity
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public byte[] Image { get; set; }

		public int CategoryId { get; set; }
		public Category Category { get; set; }
	}
}