using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Domain.Model
{
    public partial class Empresa : HistoryModel
    {
        public Empresa()
        {
            EmpresaSucursales = new List<EmpresaSucursal>();
            EmpresaUnidadMedidas = new List<EmpresaUnidadMedida>();
        }
        [Key]
        public Guid Id { get; set; }

        [StringLength(200)]
        public string Nombre { get; set; }
        [StringLength(200)]
        public string NombreComercial { get; set; }
        public TipoDocumentoIdentidad TipoDocumento { get; set; }
        [StringLength(20)]
        public string NumeroDocumento { get; set; }
        [StringLength(20)]
        public string Telefono { get; set; }
        [StringLength(50)]
        public string Correo { get; set; }
        [StringLength(200)]
        public string Direccion { get; set; }
        [StringLength(10)]
        public string Ubigeo { get; set; }
        [StringLength(100)]
        public string Referencia { get; set; }
        public DateTime FechaInicio { get; set; }
        [StringLength(50)]
        public string Actividad { get; set; }
        [StringLength(100)]
        public string RepresentanteLegal { get; set; }
        [StringLength(100)]
        public string Cargo { get; set; }
        [StringLength(20)]
        public string Dni { get; set; }
        [StringLength(50)]
        public string CuentaBancaria1 { get; set; }
        [StringLength(50)]
        public string CuentaBancaria2 { get; set; }
        [StringLength(50)]
        public string TextoComprobante { get; set; }
        [StringLength(100)]
        public string urlImagen { get; set; }
        public ICollection<EmpresaSucursal> EmpresaSucursales { get; set; }
        public ICollection<EmpresaUnidadMedida> EmpresaUnidadMedidas { get; set; }
        public ICollection<Proveedor> Proveedores { get; set; }

    }
}
