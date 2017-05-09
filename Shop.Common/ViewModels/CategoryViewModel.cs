using System.Collections.Generic;

namespace Shop.Common.ViewModels
{
	public class CategoryViewModel
	{
		public int CategoryId { get; set; }
		public string Name { get; set; }

		public List<ProductViewModel> Products { get; set; }
	}
}