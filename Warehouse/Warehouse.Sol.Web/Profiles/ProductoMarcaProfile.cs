using AutoMapper;
using Warehouse.Solution.Domain.Model;
using Warehouse.Solution.Dto;

namespace Warehouse.Sol.Web.Profiles
{
    public class ProductoMarcaProfile : Profile
    {
        public ProductoMarcaProfile()
        {
            CreateMap<PostProductoMarcaDto, ProductoMarca>();
            CreateMap<PutProductoMarcaDto, ProductoMarca>();

            CreateMap<ProductoMarca, ProductoMarcaDto>();
            CreateMap<ProductoMarcaDto, ProductoMarca>();
        }
    }
}
