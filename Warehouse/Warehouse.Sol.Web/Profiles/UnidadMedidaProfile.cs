using AutoMapper;
using Warehouse.Solution.Domain.Model;
using Warehouse.Solution.Dto;

namespace Warehouse.Sol.Web.Profiles
{
    public class UnidadMedidaProfile : Profile
    {
        public UnidadMedidaProfile()
        {
            CreateMap<PostUnidadMedidaDto, UnidadMedida>();
            CreateMap<PutUnidadMedidaDto, UnidadMedida>();

            CreateMap<UnidadMedida, UnidadMedidaDto>();
            CreateMap<UnidadMedidaDto, UnidadMedida>();
        }
    }
}
