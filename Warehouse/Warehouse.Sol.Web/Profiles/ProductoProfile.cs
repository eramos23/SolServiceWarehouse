using AutoMapper;
using Warehouse.Solution.Domain.Model;
using Warehouse.Solution.Dto;

namespace Warehouse.Sol.Web.Profiles
{
    public class ProductoProfile : Profile
    {
        public ProductoProfile()
        {
            CreateMap<PostProductoDto, Producto>();
            CreateMap<PutProductoDto, Producto>();

            CreateMap<Producto, ProductoDto>();
            CreateMap<ProductoDto, Producto>();
        }
    }
}
