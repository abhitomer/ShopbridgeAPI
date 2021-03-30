using AutoMapper;
using ShopBridgeBusinessEntities;
using ShopBridgeDataModel;

namespace ShopBridgeBusinessServices.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Products, ProductEntity>();
            CreateMap<ProductEntity, Products>();
        }
    }
}
