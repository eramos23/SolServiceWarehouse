using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Solution.Core.Services.Interfaces;
using Warehouse.Solution.Domain.DbContexts.Interface;
using Warehouse.Solution.Domain.Model;
using Warehouse.Solution.Dto.Filters;
using Warehouse.Solution.Dto.PersonalizedResponse;

namespace Warehouse.Solution.Core.Services
{
    public class CompanyUnitMeasureService : ICompanyUnitMeasureService
    {
        private readonly IDataManager DataManager;
        public CompanyUnitMeasureService(IDataManager dataManager)
        {
            DataManager = dataManager;
        }

        public async Task<EmpresaUnidadMedida> GetByIdAsync(Guid id)
        {
            var entity = await DataManager.DbContext.EmpresaUnidadMedida
                                    .FirstOrDefaultAsync(ci => ci.Id == id);
            return entity;
        }

        public async Task<List<UnidadMedidaEmpresaDto>> GetAllPersonalizedAsync(Filter filterDto)
        {
            try
            {
                var query1 = (from unidad in DataManager.DbContext.UnidadMedida
                              join empresa in DataManager.DbContext.EmpresaUnidadMedida
                                 on unidad.Id equals empresa.IdUnidadMedida into rjoin
                              from unidaJoin in rjoin.DefaultIfEmpty()
                                  //where empresa.IdEmpresa.Equals(filterDto.IdEmpresa)
                              select new UnidadMedidaEmpresaDto()
                              {
                                  Id = unidaJoin.Id,
                                  Codigo = unidaJoin.Codigo != null ? unidaJoin.Codigo : unidad.Codigo,
                                  Nombre = unidaJoin.Nombre != null ? unidaJoin.Nombre : unidad.Nombre,
                                  Descripcion = unidaJoin.Descripcion != null ? unidaJoin.Descripcion : unidad.Descripcion,
                                  EnUso = unidaJoin.EnUso
                              });

                return await query1.AsNoTracking().ToListAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<bool> CrateAsync(EmpresaUnidadMedida model)
        {
            try
            {
                var result = await DataManager.EmpresaUnidadMedidaRepository.Add(model);
                return result > 0;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public async Task<bool> UpdateAsync(Guid id, EmpresaUnidadMedida model)
        {
            var entity = await GetByIdAsync(id);
            if (model != null)
            {
                var affectedRecords = await DataManager.EmpresaUnidadMedidaRepository.UpdateEntity(model, entity);
                return affectedRecords > 0;
            }
            return false;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var entity = await this.GetByIdAsync(id);

            if (entity != null)
            {
                entity.Vigente = false;
                var result = await DataManager.SaveChanges();
                return result > 0;
            }

            return false;
        }

        public Task<List<EmpresaUnidadMedida>> GetAllAsync(Filter filterDto)
        {
            throw new NotImplementedException();
        }
    }
}
