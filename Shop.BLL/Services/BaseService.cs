using Shop.DAL.Repository.Infra;

namespace Shop.BLL.Services
{
	/// <summary>
	/// The common service
	/// </summary>
	public abstract class BaseService
	{
		protected readonly IRepositoryFactory Factory;

		protected BaseService(IRepositoryFactory factory)
		{
			Factory = factory;
		}
	}
}