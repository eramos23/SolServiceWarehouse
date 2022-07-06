using AutoMapper;
using Warehouse.Solution.Domain.Model;
using Warehouse.Solution.Dto;

namespace Warehouse.Sol.Web.Profiles
{
    public class Proveedor : Profile
    {
        public Proveedor()
        {
            CreateMap<ProveedorDto, Proveedor>();
            CreateMap<Proveedor, ProveedorDto>();
        }
    }
}
