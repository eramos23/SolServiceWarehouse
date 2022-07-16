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
    public class ProductService: IProductService
    {
        private readonly IDataManager DataManager;
        public ProductService(IDataManager dataManager)
        {
            DataManager = dataManager;
        }

        public async Task<List<Producto>> GetAllAsync(ProductFilterDto filterDto)
        {
            IQueryable<Producto> query = DataManager.ProductoRepository.GetQueryable()
                                                    .Include(c => c.Categorias)
                                                    .Include(u => u.Usos)
                                                    .Include(u => u.UnidadesMedida)
                                                    .Include(m => m.Marcas)
                                                    .Include(l => l.Laboratorios)
                                                    .Include(c => c.Estado);

            if (!string.IsNullOrEmpty(filterDto.IdEmpresa))
                query = query.Where(c => c.IdEmpresa == new Guid(filterDto.IdEmpresa));

            if (!string.IsNullOrEmpty(filterDto.IdEmpresaSucursal))
                query = query.Where(c => c.IdEmpresaSucursal == new Guid(filterDto.IdEmpresaSucursal));

            if (!string.IsNullOrEmpty(filterDto.Texto))
                query = query.Where(c => c.Nombre.Contains(filterDto.Texto)
                || c.RegistroSanitario.Contains(filterDto.Texto)
                || c.UbicacionAlmacen.Contains(filterDto.Texto));

            return await query.ToListAsync();
        }


        public async Task<Producto> GetByIdAsync(Guid id)
        {
            var product = await DataManager.DbContext.Producto
                                    .Include(c => c.Categorias)
                                    .Include(u => u.Usos)
                                    .Include(u => u.UnidadesMedida)
                                    .Include(m => m.Marcas)
                                    .Include(l => l.Laboratorios)
                                    .FirstOrDefaultAsync(ci => ci.Id == id);
            return product;
        }

        public async Task<bool> CrateAsync(Producto model)
        {
            try
            {
                var result = await DataManager.ProductoRepository.Add(model);
                return result > 0;
            }
            catch (Exception ex)
            {

                return false;
            }

        }

        public async Task<bool> UpdateAsync(Guid id, Producto model)
        {
            var entity = await GetByIdAsync(id);
            if (model != null)
            {
                var affectedRecords = await DataManager.ProductoRepository.UpdateEntity(model, entity);
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
