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
        public string IdTipoDocumento { get; set; }
        public string Docuemto { get; set; }        
        public string Direccion { get; set; }        
        public string Correo { get; set; }        
        public string Telefono { get; set; }
        public int TipoProveedor { get; set; }
        public string NombreTipoProveedor { get; set; }
        public EmpresaDto Empresa { get; set; }
        public EmpresaSucursalDto EmpresaSucursal { get; set; }
        public TipoDocumentoIdentidadDto TipoDocumentoIdentidad { get; set; }
        public CatalogoDto Estado { get; set; }

    }
}
