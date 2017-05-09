using System.Collections.Generic;
using Shop.BLL.Services.Infra;
using Shop.Common.Models;

namespace Shop.BLL.Services
{
	public class ProductService : IProductService
	{
		//TODO implement methods

		public IEnumerable<Product> GetProducts()
		{
			throw new System.NotImplementedException();
		}

		public IEnumerable<Product> GetCategoryProducts(string categoryName, string productName)
		{
			throw new System.NotImplementedException();
		}

		public Product GetProduct(int id)
		{
			throw new System.NotImplementedException();
		}

		public void CreateProduct(Product product)
		{
			throw new System.NotImplementedException();
		}

		public void SaveProduct()
		{
			throw new System.NotImplementedException();
		}
	}
}