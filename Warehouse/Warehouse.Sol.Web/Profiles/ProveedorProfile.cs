using AutoMapper;
using Warehouse.Solution.Domain.Model;
using Warehouse.Solution.Dto;

namespace Warehouse.Sol.Web.Profiles
{
    public class ProveedorProfile : Profile
    {
        public ProveedorProfile()
        {
            CreateMap<ProveedorDto, Proveedor>();
            CreateMap<Proveedor, ProveedorDto>();
        }
    }
}
