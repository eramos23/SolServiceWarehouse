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

namespace Warehouse.Solution.Core.Services
{
    public class ProductoMarcaService : IProductoMarcaService
    {
        private readonly IDataManager DataManager;
        public ProductoMarcaService(IDataManager dataManager)
        {
            DataManager = dataManager;
        }

        public async Task<ProductoMarca> GetByIdAsync(Guid id)
        {
            var brand = await DataManager.DbContext.ProductoMarca
                                    .FirstOrDefaultAsync(ci => ci.Id == id);
            return brand;
        }

        public async Task<List<ProductoMarca>> GetAllAsync(Filter filterDto)
        {
            IQueryable<ProductoMarca> query = DataManager.ProductoMarcaRepository.GetQueryable()
                                                    .Include(c => c.Estado);
            
            if (!string.IsNullOrEmpty(filterDto.IdEmpresa))
                query = query.Where(c => c.IdEmpresa == new Guid(filterDto.IdEmpresa));

            if (!string.IsNullOrEmpty(filterDto.IdEmpresaSucursal))
                query = query.Where(c => c.IdEmpresaSucursal == new Guid(filterDto.IdEmpresaSucursal));
            
            if (!string.IsNullOrEmpty(filterDto.Texto))
                query = query.Where(c => c.Nombre.Contains(filterDto.Texto)
                || c.Observacion.Contains(filterDto.Texto));

            return await query.ToListAsync();
        }

        public async Task<bool> CrateAsync(ProductoMarca model)
        {
            try
            {
                var result = await DataManager.ProductoMarcaRepository.Add(model);
                return result > 0;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public async Task<bool> UpdateAsync(Guid id, ProductoMarca model)
        {
            var entity = await GetByIdAsync(id);
            if (model != null)
            {
                var affectedRecords = await DataManager.ProductoMarcaRepository.UpdateEntity(model, entity);
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
    }
}
