using AutoMapper;
using Warehouse.Solution.Domain.Model;
using Warehouse.Solution.Dto;

namespace Warehouse.Sol.Web.Profiles
{
    public class ProductoCategoriaProfile : Profile
    {
        public ProductoCategoriaProfile()
        {
            CreateMap<PostProductoCategoriaDto, ProductoCategoria>();
            CreateMap<PutProductoCategoriaDto, ProductoCategoria>();

            CreateMap<ProductoCategoria, ProductoCategoriaDto>();
            CreateMap<ProductoCategoriaDto, ProductoCategoria>();
        }
    }
}
