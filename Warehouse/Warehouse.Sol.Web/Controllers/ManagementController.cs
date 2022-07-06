using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Warehouse.Sol.Web.Configuration;
using Warehouse.Sol.Web.Helper;
using Warehouse.Solution.Core.Core;
using Warehouse.Solution.Core.Services.Interfaces;
using Warehouse.Solution.Dto;

namespace Warehouse.Sol.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class ManagementController : BaseController
    {
        private readonly IEmpresaService _empresaService;
        private readonly IEmpresaSucursalService _empresaSucursalService;
        public ManagementController(IEmpresaService empresaService, IEmpresaSucursalService empresaSucursalService, IMapper mapper) : base(mapper)
        {
            _empresaService = empresaService;
            _empresaSucursalService = empresaSucursalService;
        }

        [ProducesResponseType(typeof(DataQuery<List<EmpresaDto>>), 200)]
        [HttpGet("companies")]
        public async Task<ActionResult> GetCompany()
        {
            var resultService = await this._empresaService.GetAllAsync();
            if (resultService != null)
            {
                var result1 = HelperStatus.ResponseHelper(this._mapper.Map<List<EmpresaDto>>(resultService), Status.Ok);
                return Ok(result1);
            }
            var result = HelperStatus.ResponseHelper<List<EmpresaDto>>(this._mapper.Map<List<EmpresaDto>>(resultService), Status.Error, "algo salió mal");
            return NotFound(result);
        }

        [ProducesResponseType(typeof(DataQuery<List<EmpresaSucursalDto>>), 200)]
        [HttpGet("compani-branchs")]
        public async Task<ActionResult> GetCompanyBranch(string id)
        {
            var resultService = await this._empresaSucursalService.GetAllByIdCompanyAsync(id);
            if (resultService != null)
            {
                var result1 = HelperStatus.ResponseHelper(this._mapper.Map<List<EmpresaSucursalDto>>(resultService), Status.Ok);
                return Ok(result1);
            }
            var result = HelperStatus.ResponseHelper<List<EmpresaSucursalDto>>(this._mapper.Map<List<EmpresaSucursalDto>>(resultService), Status.Error, "algo salió mal");
            return NotFound(result);
        }
    }
}
