using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Warehouse.Sol.Web.Configuration
{
    public class BaseController : ControllerBase
    {
        public readonly IMapper _mapper;

        public BaseController(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}
