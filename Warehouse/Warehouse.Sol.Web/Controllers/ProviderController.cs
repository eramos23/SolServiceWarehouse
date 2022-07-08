using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Warehouse.Sol.Web.Configuration;
using Warehouse.Sol.Web.Helper;
using Warehouse.Solution.Core.Core;
using Warehouse.Solution.Core.Services.Interfaces;
using Warehouse.Solution.Domain.Model;
using Warehouse.Solution.Dto;
using Warehouse.Solution.Dto.Filters;

namespace Warehouse.Sol.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class ProviderController : BaseController
    {
        private readonly IProviderService _service;
        public ProviderController(IProviderService service, IMapper mapper) : base(mapper)
        {
            _service = service;
        }

        [HttpGet("get-list")]
        [ProducesResponseType(typeof(DataQuery<List<ProveedorDto>>), 200)]
        public async Task<ActionResult> GetAll([FromQuery] ProviderFilterDto filterDto)
        {
            var resultService = await _service.GetAllAsync(filterDto);
            if (resultService != null)
            {
                var result1 = HelperStatus.ResponseHelper(this._mapper.Map<List<ProveedorDto>>(resultService), Status.Ok);
                return Ok(result1);
            }
            var result = HelperStatus.ResponseHelper<List<ProveedorDto>>(this._mapper.Map<List<ProveedorDto>>(resultService), Status.Error, "Error al consultar Proveedores");
            return NotFound(result);
        }

        [HttpGet]
        public async Task<ActionResult> GetById(string id)
        {
            if (string.IsNullOrEmpty(id)) return BadRequest(HelperStatus.ResponseHelper(false, "HttpStatusCode.BadRequest", "Messages.Result_BadRequest"));

            var resultService = await _service.GetByIdAsync(new Guid(id));

            if (resultService != null)
            {
                var result = HelperStatus.ResponseHelper(_mapper.Map<ProveedorDto>(resultService), Status.Ok, string.Empty);
                return Ok(result);
            }

            return NotFound(HelperStatus.ResponseHelper<object>(null, string.Empty, string.Empty));
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromForm] ProveedorDto dto)
        {
            if (dto == null) return BadRequest(HelperStatus.ResponseHelper(false, "HttpStatusCode.BadRequest", "Messages.Result_BadRequest"));
            dto.IdEmpresa = new Guid("d968c670-304d-4a47-854d-142d6d585045");
            dto.IdEmpresaSucursal = new Guid("c06833e2-14d5-4d2e-b27f-7b4bed3cd88c");

            var provider = _mapper.Map<Proveedor>(dto);

            var resultService = await _service.CrateAsync(provider);
            if (resultService)
            {
                var providerCrearted = await _service.GetByIdAsync(provider.Id);
                
                var result = HelperStatus.ResponseHelper(_mapper.Map<ProveedorDto>(providerCrearted), "HttpStatusCode.Created", string.Empty);
                return StatusCode(StatusCodes.Status201Created, result);
            }

            return BadRequest(HelperStatus.ResponseHelper(false, "HttpStatusCode.BadRequest", "Messages.Result_NotCreated"));
        }

    }
}
