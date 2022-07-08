using SKJ.Shared.Data.Repositories.Interfaces;
using Warehouse.Solution.Domain.Model;

namespace Warehouse.Solution.Domain.DbContexts.Interface
{
    public interface IDataManager : IRepositoryManager
    {
        IRepository<Proveedor> ProveedorRepository { get; }
        IRepository<EntidadFinanciera> EntidadFinancieraRepository { get; }
        IRepository<Empresa> EmpresaRepository { get; }
        IRepository<EmpresaSucursal> EmpresaSucursalRepository { get; }
        IRepository<Catalogo> CatalogoRepository { get; }
        WarehouseDbContext DbContext { get; }
    }
}
