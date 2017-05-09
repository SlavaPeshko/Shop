namespace Shop.Common.ViewModels
{
	public class ProductViewModel
	{
		public int ProductId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public byte[] Photo { get; set; }

		public int CategoryId { get; set; }
	}
}