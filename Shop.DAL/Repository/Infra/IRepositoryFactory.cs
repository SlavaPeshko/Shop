namespace Shop.DAL.Repository.Infra
{
	public interface IRepositoryFactory
	{
		IProductRepository CreateProductRepository();
		ICategoryRepository CreateCategoryRepository();
	}
}