using AutoMapper;
using Warehouse.Solution.Domain.Model;
using Warehouse.Solution.Dto;

namespace Warehouse.Sol.Web.Profiles
{
    public class TipoDocumentoIdentidadProfile : Profile
    {
        public TipoDocumentoIdentidadProfile()
        {
            CreateMap<TipoDocumentoIdentidadDto, TipoDocumentoIdentidad>();
            CreateMap<TipoDocumentoIdentidad, TipoDocumentoIdentidadDto>();
        }
    }
}
