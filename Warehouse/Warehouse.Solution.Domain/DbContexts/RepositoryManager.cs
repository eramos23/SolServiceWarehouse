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
        private readonly IRepository<Empresa> _empresaRepository;
        private readonly IRepository<EmpresaSucursal> _empresaSucursalRepository;
        private readonly IRepository<Catalogo> _catalogoRepository;
        private readonly IRepository<TipoDocumentoIdentidad> _tipoDocumentoIdentidadRepository;
        private readonly IRepository<Producto> _productoRepository;
        private readonly IRepository<ProductoCategoria> _productoCategoriaRepository;
        private readonly IRepository<ProductoUso> _productoUsoRepository;
        private readonly IRepository<UnidadMedida> _unidadMedidaRepository;
        private readonly IRepository<ProductoMarca> _productoMarcaRepository;
        private readonly IRepository<Laboratorio> _laboratorioRepository;

        public RepositoryManager(WarehouseDbContext context)
        {
            this.Context = context;
        }

        public IRepository<Proveedor> ProveedorRepository => this._proveedorRepository ?? new Respository<Proveedor>(this.Context);
        public IRepository<EntidadFinanciera> EntidadFinancieraRepository => this._entidadFinancieraRepository ?? new Respository<EntidadFinanciera>(this.Context);

        public IRepository<Empresa> EmpresaRepository => this._empresaRepository ?? new Respository<Empresa>(this.Context);

        public IRepository<EmpresaSucursal> EmpresaSucursalRepository => this._empresaSucursalRepository ?? new Respository<EmpresaSucursal>(this.Context);

        public IRepository<Catalogo> CatalogoRepository => this._catalogoRepository ?? new Respository<Catalogo>(this.Context);
        public WarehouseDbContext DbContext => this.Context;

        public IRepository<TipoDocumentoIdentidad> TipoDocumentoIdentidadRepository => this._tipoDocumentoIdentidadRepository ?? new Respository<TipoDocumentoIdentidad>(this.Context);

        public IRepository<Producto> ProductoRepository => this._productoRepository ?? new Respository<Producto>(this.Context);

        public IRepository<ProductoCategoria> ProductoCategoriaRepository => this._productoCategoriaRepository ?? new Respository<ProductoCategoria>(this.Context);

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
