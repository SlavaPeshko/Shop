using System;
using System.Collections.Generic;
using Shop.BLL.Services.Infra;
using Shop.Common.Models;
using Shop.DAL.Repository.Infra;
using Shop.Infra.Repository;

namespace Shop.BLL.Services
{
	public class ProductService : IProductService
	{
		private readonly IProductRepository _productRepository;
		private readonly ICategoryRepository _categoryRepository;

		public ProductService(IProductRepository productRepository, ICategoryRepository categoryRepository)
		{
			_productRepository = productRepository;
			_categoryRepository = categoryRepository;
		}

		public IEnumerable<Product> GetProducts()
		{
			var product = _productRepository.GetAll();
			return product;
		}

		public IEnumerable<Product> GetCategoryProducts(string categoryName, string productName)
		{
			//var product = _categoryRepository.G
			throw new NotImplementedException();
		}

		public Product GetProduct(int id)
		{
			var product = _productRepository.GetById(id);
			return product;
		}

		public void CreateProduct(Product product)
		{
			_productRepository.Add(product);
		}

		public void SaveProduct()
		{
			throw new System.NotImplementedException();
		}
	}
}