using AutoMapper;
using Warehouse.Solution.Domain.Model;
using Warehouse.Solution.Dto;

namespace Warehouse.Sol.Web.Profiles
{
    public class EmpresaSucursalProfile : Profile
    {
        public EmpresaSucursalProfile()
        {
            CreateMap<EmpresaSucursalDto, EmpresaSucursal>();
            CreateMap<EmpresaSucursal, EmpresaSucursalDto>();
        }
    }
}
