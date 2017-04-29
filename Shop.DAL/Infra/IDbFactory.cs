using System;
using Shop.DAL.Context;

namespace Shop.DAL.Infra
{
	public interface IDbFactory : IDisposable
	{
		ShopContext Init();
	}
}