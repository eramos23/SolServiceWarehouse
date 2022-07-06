using SKJ.Shared.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Solution.Domain.Model;

namespace Warehouse.Solution.Domain.DbContexts.Interface
{
    public interface IDataManager : IRepositoryManager
    {
        IRepository<Proveedor> ProveedorRepository { get; }
        IRepository<EntidadFinanciera> EntidadFinancieraRepository { get; }
        WarehouseDbContext DbContext { get; }
    }
}
