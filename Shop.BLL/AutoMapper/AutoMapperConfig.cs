using AutoMapper;

namespace Shop.BLL.AutoMapper
{
	public class AutoMapperConfig
	{
		public static MapperConfiguration RegisterMappings()
		{
			return new MapperConfiguration(cfg =>
			{
				cfg.AddProfile(new DomainToViewModelMappingProfile());
				cfg.AddProfile(new ViewModelToDomainMappingProfile());
			});
		}
	}
}
