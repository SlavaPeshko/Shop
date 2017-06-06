using Shop.DAL.Repository.Infra;

namespace Shop.BLL.Services
{
	/// <summary>
	/// The common service
	/// </summary>
	public abstract class BaseService
	{
		/// <summary>
		/// To access the repositories
		/// </summary>
		protected readonly IRepositoryFactory Factory;

		/// <summary>
		/// Initializes a new instance of the <see cref="BaseService"/> class
		/// </summary>
		/// <param name="factory">
		/// To access to the repositories
		/// </param>
		protected BaseService(IRepositoryFactory factory)
		{
			Factory = factory;
		}
	}
}