using Shop.Common.Model;
using Shop.DAL.Context;
using Shop.DAL.Infra;

namespace Shop.DAL.Repository
{
	public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
	{
		public CategoryRepository(ShopContext shopContext) : base(shopContext)
		{
		}
	}
}