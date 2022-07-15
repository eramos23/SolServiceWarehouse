using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Dto
{
    public class ProveedorDto
    {
        public Guid Id { get; set; }
        public Guid IdEmpresa { get; set; }
        public Guid IdEmpresaSucursal { get; set; }
        public string Nombre { get; set; }
        //public string IdTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }        
        public string Telefono { get; set; }
        //public int TipoProveedor { get; set; }
        //public string NombreTipoProveedor { get; set; }
        public int IdEstado { get; set; }
        public EmpresaDto Empresa { get; set; }
        public EmpresaSucursalDto EmpresaSucursal { get; set; }
        public TipoDocumentoIdentidadDto TipoDocumentoIdentidad { get; set; }
        public CatalogoDto Estado { get; set; }
        public CatalogoDto TipoProveedor { get; set; }
    }

    public class PostProveedorDto
    {
        public Guid Id { get; set; }
        public Guid IdEmpresa { get; set; }
        public Guid IdEmpresaSucursal { get; set; }
        public string Nombre { get; set; }
        public string IdTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int IdTipoProveedor { get; set; }
        //public string NombreTipoProveedor { get; set; }
        public int IdEstado { get; set; }
    }
    public class PutProveedorDto
    {
        public Guid Id { get; set; }
        public Guid IdEmpresa { get; set; }
        public Guid IdEmpresaSucursal { get; set; }
        public string Nombre { get; set; }
        public string IdTipoDocumento { get; set; }
        public string IdTipoProveedor { get; set; }
        public string NumeroDocumento { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int IdEstado { get; set; }
    }
}
