﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Warehouse.Sol.Web.Configuration;
using Warehouse.Sol.Web.Helper;
using Warehouse.Solution.Core.Core;
using Warehouse.Solution.Core.Interfaces;
using Warehouse.Solution.Dto;

namespace Warehouse.Sol.Web.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class EntidadFinancieraController : BaseController
    {
        private readonly IEntidadFinancieraService _service;
        public EntidadFinancieraController(IEntidadFinancieraService service, IMapper mapper): base(mapper)
        {
            _service = service;
        }

        [ProducesResponseType(typeof(DataQuery<List<EntidadFinancieraDto>>), 200)]
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            //DataQuery<IEnumerable<EntidadFinancieraDto>> result;
            var resultService = await this._service.GetAllAsync();
            if (resultService != null)
            {
                var result1 = HelperStatus.ResponseHelper(this._mapper.Map<List<EntidadFinancieraDto>>(resultService), Status.Ok);
                return Ok(result1);
            }
            var result = HelperStatus.ResponseHelper<List<EntidadFinancieraDto>>(this._mapper.Map<List<EntidadFinancieraDto>>(resultService), Status.Error, "algo salió mal");
            return NotFound(result);
        }
    }
}
