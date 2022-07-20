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
        IRepository<TipoDocumentoIdentidad> TipoDocumentoIdentidadRepository { get; }
        IRepository<Producto> ProductoRepository { get; }
        IRepository<ProductoCategoria> ProductoCategoriaRepository { get; }
        IRepository<ProductoUso> ProductoUsoRepository { get; }
        IRepository<ProductoMarca> ProductoMarcaRepository { get; }
        IRepository<Laboratorio> LaboratorioRepository { get; }
        IRepository<ProductoUnidadMedida> ProductoUnidadMedidaRepository { get; }
        WarehouseDbContext DbContext { get; }
    }
}
