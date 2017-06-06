using AutoMapper;
using Shop.Common.Models;
using Shop.Common.ViewModels;

namespace Shop.BLL.AutoMapper
{
	public class DomainToViewModelMappingProfile : Profile
	{
		public DomainToViewModelMappingProfile()
		{
			CreateMap<Category, CategoryViewModel>();
			CreateMap<Product, ProductViewModel>();
		}
	}
}