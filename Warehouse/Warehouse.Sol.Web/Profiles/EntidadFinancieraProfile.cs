using AutoMapper;
using Warehouse.Solution.Domain.Model;
using Warehouse.Solution.Dto;

namespace Warehouse.Sol.Web.Profiles
{
    public class EntidadFinancieraProfile : Profile
    {
        public EntidadFinancieraProfile()
        {
            CreateMap<EntidadFinancieraDto, EntidadFinanciera>();
            CreateMap<EntidadFinanciera, EntidadFinancieraDto>();
        }
    }
}
