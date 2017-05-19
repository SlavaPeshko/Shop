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

		public Category GetCategoryByName(string categoryName)
		{
			var category = this.DbContext.
		}
	}
}