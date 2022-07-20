using AutoMapper;
using Warehouse.Solution.Domain.Model;
using Warehouse.Solution.Dto;

namespace Warehouse.Sol.Web.Profiles
{
    public class ProductoUsoProfile : Profile
    {
        public ProductoUsoProfile()
        {
            CreateMap<PostProductoUsoDto, ProductoUso>();
            CreateMap<PutProductoUsoDto, ProductoUso>();

            CreateMap<ProductoUso, ProductoUsoDto>();
            CreateMap<ProductoUsoDto, ProductoUso>();
        }
    }
}
