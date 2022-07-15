using AutoMapper;
using Warehouse.Solution.Domain.Model;
using Warehouse.Solution.Dto;

namespace Warehouse.Sol.Web.Profiles
{
    public class ProveedorProfile : Profile
    {
        public ProveedorProfile()
        {
            CreateMap<PostProveedorDto, Proveedor>();
            //CreateMap<Proveedor, PostProveedorDto>();

            CreateMap<Proveedor, ProveedorDto>();
            CreateMap<ProveedorDto, Proveedor>();
            
            
            CreateMap<PutProveedorDto, Proveedor>();
        }
    }
}
