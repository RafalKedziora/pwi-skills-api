using AutoMapper;

namespace Application.Mappings
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {

            }).CreateMapper();
    }
}
