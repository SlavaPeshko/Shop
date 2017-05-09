using System.Collections.Generic;
using Shop.Common.Models;

namespace Shop.BLL.Services.Infra
{
	public interface IProductService
	{
		IEnumerable<Product> GetProducts();
		IEnumerable<Product> GetCategoryProducts(string categoryName, string productName);
		Product GetProduct(int id);
		void CreateProduct(Product product);
		void SaveProduct();
	}
}