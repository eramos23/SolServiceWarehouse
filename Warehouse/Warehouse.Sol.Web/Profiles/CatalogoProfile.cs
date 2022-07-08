using AutoMapper;
using Warehouse.Solution.Domain.Model;
using Warehouse.Solution.Dto;

namespace Warehouse.Sol.Web.Profiles
{
    public class CatalogoProfile : Profile
    {
        public CatalogoProfile()
        {
            CreateMap<CatalogoDto, Catalogo>();
            CreateMap<Catalogo, CatalogoDto>();
        }
    }
}
