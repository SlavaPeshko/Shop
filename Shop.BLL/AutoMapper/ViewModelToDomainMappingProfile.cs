using AutoMapper;
using Shop.Common.Models;
using Shop.Common.ViewModels;

namespace Shop.BLL.AutoMapper
{
	public class ViewModelToDomainMappingProfile : Profile
	{
		public ViewModelToDomainMappingProfile()
		{
			//CreateMap<ProductFromViewModel, Product>()
			//	.ConstructUsing(n=> new )
		}
	}
}