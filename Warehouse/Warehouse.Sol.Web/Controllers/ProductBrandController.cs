﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Warehouse.Sol.Web.Configuration;
using Warehouse.Sol.Web.Helper;
using Warehouse.Sol.Web.Helper.Text;
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
    public class ProductBrandController : BaseController
    {
        private readonly IProductBrandService _service;
        public ProductBrandController(IProductBrandService service, IMapper mapper) : base(mapper)
        {
            _service = service;
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DataQuery<List<ProductoMarcaDto>>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(DataQuery<object>))]
        [HttpGet]
        public async Task<ActionResult> GetAll([FromQuery] Filter filterDto)
        {
            DataQuery<List<ProductoMarcaDto>> result;

            var list = await _service.GetAllAsync(filterDto);
            if (list != null)
            {
                result = HelperStatus.ResponseHelper(this._mapper.Map<List<ProductoMarcaDto>>(list), HttpStatusCode.OK);
                return Ok(result);
            }
            result = HelperStatus.ResponseHelper(new List<ProductoMarcaDto>(), HttpStatusCode.NotFound, Messages.Result_Empty);
            return NotFound(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DataQuery<ProductoMarcaDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(DataQuery<object>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(DataQuery<bool>))]
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(string id)
        {
            if (string.IsNullOrEmpty(id)) return BadRequest(HelperStatus.ResponseHelper(false, HttpStatusCode.BadRequest, Messages.Result_BadRequest));

            DataQuery<ProductoMarcaDto> result;

            var resultService = await _service.GetByIdAsync(new Guid(id));

            if (resultService != null)
            {
                result = HelperStatus.ResponseHelper(_mapper.Map<ProductoMarcaDto>(resultService), HttpStatusCode.OK);
                return Ok(result);
            }

            return NotFound(HelperStatus.ResponseHelper<object>(null, HttpStatusCode.NotFound, Messages.Result_NotFound));
        }

        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(DataQuery<ProductoMarcaDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(DataQuery<bool>))]
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] PostProductoMarcaDto dto)
        {
            if (dto == null) return BadRequest(HelperStatus.ResponseHelper(false, HttpStatusCode.BadRequest, Messages.Result_BadRequest));
            DataQuery<ProductoMarcaDto> result;
            var data = _mapper.Map<ProductoMarca>(dto);

            var resultService = await _service.CrateAsync(data);
            if (resultService)
            {
                var dataCrearted = await _service.GetByIdAsync(data.Id);

                result = HelperStatus.ResponseHelper(_mapper.Map<ProductoMarcaDto>(dataCrearted), HttpStatusCode.Created, Messages.Result_Created);
                return StatusCode(StatusCodes.Status201Created, result);
            }

            return BadRequest(HelperStatus.ResponseHelper(false, HttpStatusCode.BadRequest, Messages.Result_NotCreated));

        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DataQuery<bool>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(DataQuery<object>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(DataQuery<bool>))]
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(string id, [FromBody] PutProductoMarcaDto dto)
        {
            if (new Guid(id) != dto.Id || dto == null) return BadRequest(HelperStatus.ResponseHelper(false, HttpStatusCode.NotFound, Messages.Result_BadRequest));

            var data = await _service.GetByIdAsync(new Guid(id));

            if (data == null) return NotFound(HelperStatus.ResponseHelper<object>(null, HttpStatusCode.NotFound, Messages.Result_NotFound));

            DataQuery<bool> result;
            var dataDto = _mapper.Map<ProductoMarca>(dto);
            var resultService = await _service.UpdateAsync(new Guid(id), dataDto);

            if (resultService)
            {
                result = HelperStatus.ResponseHelper(resultService, HttpStatusCode.OK, Messages.Result_Updated);
                return Ok(result);
            }

            result = HelperStatus.ResponseHelper(false, HttpStatusCode.BadRequest, Messages.Result_NotUpdated);
            return BadRequest(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DataQuery<bool>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(DataQuery<object>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(DataQuery<bool>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) return BadRequest(HelperStatus.ResponseHelper(false, HttpStatusCode.BadRequest, Messages.Result_BadRequest));
            var data = await _service.GetByIdAsync(new Guid(id));

            if (data == null) return NotFound(HelperStatus.ResponseHelper<object>(null, HttpStatusCode.NotFound, Messages.Result_NotFound));

            DataQuery<bool> result;

            var resultService = await _service.DeleteAsync(new Guid(id));
            if (resultService)
            {
                result = HelperStatus.ResponseHelper(resultService, HttpStatusCode.OK, Messages.Result_Deleted);
                return Ok(result);
            }

            result = HelperStatus.ResponseHelper(false, HttpStatusCode.BadRequest, Messages.Result_NotDeleted);
            return BadRequest(result);
        }
    }
}