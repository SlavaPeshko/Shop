using System.Collections.Generic;
using Shop.Common.Models;
using Shop.Common.ViewModels;

namespace Shop.BLL.Services.Infra
{
	public interface ICategoryService
	{
		IEnumerable<CategoryViewModel> GetCategories(string name);
		CategoryViewModel GetCategory(int id);
		CategoryViewModel GetCategory(string name);
		void CreateCategory(Category category);
	}
}