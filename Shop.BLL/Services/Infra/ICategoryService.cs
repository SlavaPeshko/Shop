using System.Collections.Generic;
using Shop.Common.Models;
using Shop.Common.ViewModels;

namespace Shop.BLL.Services.Infra
{
	public interface ICategoryService
	{
		IEnumerable<Category> GetCategories(string name);
		Category GetCategory(int id);
		Category GetCategory(string name);
		void CreateCategory(Category category);
		// void SaveCategory();
	}
}