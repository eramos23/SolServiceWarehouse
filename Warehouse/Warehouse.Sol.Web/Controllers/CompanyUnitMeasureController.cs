using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Warehouse.Sol.Web.Configuration;
using Warehouse.Sol.Web.Helper;
using Warehouse.Sol.Web.Helper.Text;
using Warehouse.Solution.Core.Core;
using Warehouse.Solution.Core.Services.Interfaces;
using Warehouse.Solution.Dto;
using Warehouse.Solution.Dto.Filters;
using Warehouse.Solution.Dto.PersonalizedResponse;

namespace Warehouse.Sol.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class CompanyUnitMeasureController : BaseController
    {
        private readonly ICompanyUnitMeasureService _service;
        public CompanyUnitMeasureController(ICompanyUnitMeasureService service, IMapper mapper) : base(mapper)
        {
            _service = service;
        }
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DataQuery<List<UnidadMedidaEmpresaDto>>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(DataQuery<object>))]
        [HttpGet]
        public async Task<ActionResult> GetAll([FromQuery] Filter filterDto)
        {
            DataQuery<List<UnidadMedidaEmpresaDto>> result;

            var list = await _service.GetAllPersonalizedAsync(filterDto);
            if (list != null)
            {
                result = HelperStatus.ResponseHelper(list, HttpStatusCode.OK);
                return Ok(result);
            }
            result = HelperStatus.ResponseHelper(new List<UnidadMedidaEmpresaDto>(), HttpStatusCode.NotFound, Messages.Result_Empty);
            return NotFound(result);
        }

    }
}
