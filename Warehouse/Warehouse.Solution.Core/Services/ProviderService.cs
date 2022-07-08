using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Solution.Core.Services.Interfaces;
using Warehouse.Solution.Domain.DbContexts;
using Warehouse.Solution.Domain.DbContexts.Interface;
using Warehouse.Solution.Domain.Model;
using Warehouse.Solution.Dto.Filters;

namespace Warehouse.Solution.Core.Services
{
    public class ProviderService : IProviderService
    {
        private readonly IDataManager DataManager;

        public ProviderService(IDataManager dataManager)
        {
            DataManager = dataManager;
        }

        public async Task<bool> CrateAsync(Proveedor model)
        {
            var result = await DataManager.ProveedorRepository.Add(model);
            return result > 0;
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

        public async Task<List<Proveedor>> GetAllAsync(ProviderFilterDto filterDto)
        {
            IQueryable<Proveedor> query = DataManager.ProveedorRepository.GetQueryable()
                                                    .Include(c => c.TipoDocumentoIdentidad)
                                                    .Include(c => c.Estado);

            if (!string.IsNullOrEmpty(filterDto.IdEmpresa))
                query = query.Where(c => c.IdEmpresa == new Guid(filterDto.IdEmpresa));

            if (!string.IsNullOrEmpty(filterDto.IdEmpresaSucursal))
                query = query.Where(c => c.IdEmpresaSucursal == new Guid(filterDto.IdEmpresaSucursal));

            if (!string.IsNullOrEmpty(filterDto.Texto))
                query = query.Where(c => c.Nombre.Contains(filterDto.Texto)
                || c.Docuemto.Contains(filterDto.Texto)
                || c.Direccion.Contains(filterDto.Texto)
                || c.Correo.Contains(filterDto.Texto)
                || c.Telefono.Contains(filterDto.Texto));

            return await query.ToListAsync();
        }

        public async Task<Proveedor> GetByIdAsync(Guid id)
        {
            var compInter = await DataManager.DbContext.Proveedor
                                    .Include(ci => ci.TipoDocumentoIdentidad)            
                                    .FirstOrDefaultAsync(ci => ci.Id == id);
            return compInter;
        }

        public async Task<bool> UpdateAsync(Guid id, Proveedor model)
        {
            var entity = await GetByIdAsync(id);
            if (model != null)
            {
                var affectedRecords = await DataManager.ProveedorRepository.UpdateEntity(model, entity);
                return affectedRecords > 0;
            }
            return false;
        }
    }
}
