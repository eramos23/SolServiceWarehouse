using AutoMapper;
using Warehouse.Solution.Domain.Model;
using Warehouse.Solution.Dto;

namespace Warehouse.Sol.Web.Profiles
{
    public class LaboratorioProfile : Profile
    {
        public LaboratorioProfile()
        {
            CreateMap<PostLaboratorioDto, Laboratorio>();
            CreateMap<PutLaboratorioDto, Laboratorio>();

            CreateMap<Laboratorio, LaboratorioDto>();
            CreateMap<LaboratorioDto, Laboratorio>();
        }
    }
}
