using SKJ.Shared.Data.Repositories;
using SKJ.Shared.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Solution.Domain.DbContexts.Interface;
using Warehouse.Solution.Domain.Model;

namespace Warehouse.Solution.Domain.DbContexts
{
    public class RepositoryManager : IDataManager
    {
        private readonly WarehouseDbContext Context;

        private readonly IRepository<Proveedor> _proveedorRepository;
        private readonly IRepository<EntidadFinanciera> _entidadFinancieraRepository;
        public WarehouseDbContext DbContext => this.Context;



        public IRepository<Proveedor> ProveedorRepository => this._proveedorRepository ?? new Respository<Proveedor>(this.Context);
        public IRepository<EntidadFinanciera> EntidadFinancieraRepository => this._entidadFinancieraRepository ?? new Respository<EntidadFinanciera>(this.Context);

        public void Dispose()
        {
            if (this.Context != null)
            {
                this.Context.Dispose();
            }
        }

        public async Task<int> SaveChanges()
        {
            return await this.Context.SaveChangesAsync();
        }
    }
}
