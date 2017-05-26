using Shop.Common.Models;
using Shop.Infra.Repository;

namespace Shop.DAL.Repository.Infra
{
	public interface ICategoryRepository : IRepository<Category>
	{
		Category GetCategoryByName(string name);
	}
}