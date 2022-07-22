using AutoMapper;
using Warehouse.Solution.Domain.Model;
using Warehouse.Solution.Dto;

namespace Warehouse.Sol.Web.Profiles
{
    public class EmpresaUnidadMedidaProfile : Profile
    {
        public EmpresaUnidadMedidaProfile()
        {
            CreateMap<PostEmpresaUnidadMedidaDto, ProductoCategoria>();
            CreateMap<PutEmpresaUnidadMedidaDto, ProductoCategoria>();

            CreateMap<EmpresaUnidadMedida, EmpresaUnidadMedidaDto>();
            CreateMap<EmpresaUnidadMedidaDto, EmpresaUnidadMedida>();
        }
    }
}
