using AutoMapper;
using Warehouse.Solution.Domain.Model;
using Warehouse.Solution.Dto;

namespace Warehouse.Sol.Web.Profiles
{
    public class ProductoUnidadMedidaProfile : Profile
    {
        public ProductoUnidadMedidaProfile()
        {
            CreateMap<PostProductoUnidadMedidaDto, ProductoUnidadMedida>();
            CreateMap<PutProductoUnidadMedidaDto, ProductoUnidadMedida>();

            CreateMap<ProductoUnidadMedida, ProductoUnidadMedidaDto>();
            CreateMap<ProductoUnidadMedidaDto, ProductoUnidadMedida>();
        }
    }
}
