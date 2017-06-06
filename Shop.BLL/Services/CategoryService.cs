using System;
using System.Collections.Generic;
using System.Linq;
using Shop.BLL.Services.Infra;
using Shop.Common.Models;
using Shop.Common.ViewModels;
using Shop.DAL.Repository.Infra;

namespace Shop.BLL.Services
{
	public class CategoryService : ICategoryService
	{
		private readonly ICategoryRepository _categoryRepository;

		public CategoryService(ICategoryRepository categoryRepository)
		{
			_categoryRepository = categoryRepository;
		}

		public IEnumerable<Category> GetCategories(string name)
		{
			if (String.IsNullOrEmpty(name))
			{
				return _categoryRepository.GetAll();
			}
			else
			{
				return _categoryRepository.GetAll().Where(n => n.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));
			}

		}

		public Category GetCategory(int id)
		{
			var category = _categoryRepository.GetById(id);
			return category;
		}

		public Category GetCategory(string name)
		{
			var category = _categoryRepository.GetCategoryByName(name);
			return category;
		}

		public void CreateCategory(Category category)
		{
			_categoryRepository.Add(category);
		}
	}
}