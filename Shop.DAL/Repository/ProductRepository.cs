using Shop.Common.Models;
using Shop.DAL.Context;
using Shop.DAL.Repository.Infra;

namespace Shop.DAL.Repository
{
	public class ProductRepository : BaseRepository<Product>, IProductRepository
	{
		public ProductRepository(ShopContext shopContext) : base(shopContext)
		{
		}
	}
}