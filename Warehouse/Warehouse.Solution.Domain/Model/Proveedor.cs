using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Domain.Model
{
    public partial class Proveedor : HistoryModel
    {
        public Proveedor()
        {

        }
        [Key]
        public Guid Id { get; set; }
        public Guid IdEmpresa { get; set; }
        public Guid IdEmpresaSucursal { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        [Column("IdTipoDocumento", TypeName = "char(1)")]
        public string IdTipoDocumento { get; set; }

        [StringLength(20)]
        public string NumeroDocumento { get; set; }

        [StringLength(200)]
        public string Direccion { get; set; }

        [StringLength(50)]
        public string Correo { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }

        public int TipoProveedor { get; set; }
        public string NombreTipoProveedor { get; set; } //*
        public int IdEstado { get; set; }

        [ForeignKey("IdEstado")]
        public Catalogo Estado { get; set; }

        [ForeignKey("IdEmpresa")]
        public Empresa Empresa { get; set; }

        [ForeignKey("IdEmpresaSucursal")]
        public EmpresaSucursal EmpresaSucursal { get; set; }

        [ForeignKey("IdTipoDocumento")]
        public TipoDocumentoIdentidad TipoDocumentoIdentidad { get; set; }

    }
}
