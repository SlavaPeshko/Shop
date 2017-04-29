using Shop.DAL.Context;
using Shop.DAL.Infra;

namespace Shop.DAL
{
	public class DbFactory : Disposable, IDbFactory
	{
		ShopContext dbContext;

		public ShopContext Init()
		{
			return dbContext ?? (dbContext = new ShopContext());
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}
	}
}