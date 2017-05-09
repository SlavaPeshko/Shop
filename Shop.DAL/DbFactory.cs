using Shop.DAL.Context;
using Shop.DAL.Infra;

namespace Shop.DAL
{
	public class DbFactory : Disposable, IDbFactory
	{
		ShopContext _dbContext;

		public ShopContext Init()
		{
			return _dbContext ?? (_dbContext = new ShopContext());
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}
	}
}