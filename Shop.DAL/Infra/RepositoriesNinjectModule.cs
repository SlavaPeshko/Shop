using Ninject.Modules;
using Ninject.Extensions.Factory;
using Shop.DAL.Repository;
using Shop.DAL.Repository.Infra;

namespace Shop.DAL.Infra
{
	public class RepositoriesNinjectModule : NinjectModule
	{
		public override void Load()
		{
			Bind<IProductRepository>()
				.To<ProductRepository>()
				.NamedLikeFactoryMethod((IRepositoryFactory factory) => factory.CreateProductRepository());
			Bind<ICategoryRepository>()
				.To<CategoryRepository>()
				.NamedLikeFactoryMethod((IRepositoryFactory factory) => factory.CreateCategoryRepository());


			Bind<IRepositoryFactory>().ToFactory();
		}
	}
}