using System;
using System.Linq;
using Shop.Common.Models;
using Shop.DAL.Context;
using Shop.DAL.Repository.Infra;

namespace Shop.DAL.Repository
{
	public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
	{
		public CategoryRepository(ShopContext shopContext) : base(shopContext)
		{
		}

		public Category GetCategoryByName(string name)
		{
			var category =
				this.DbContext.Categories.FirstOrDefault(n => n.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
		
			return category;
		}
	}
}