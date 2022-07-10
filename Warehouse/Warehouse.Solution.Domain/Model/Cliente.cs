using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Domain.Model
{
    public class Cliente : HistoryModel
    {
        public Cliente()
        {

        }
        [Key]
        public Guid Id { get; set; }
        public Guid IdEmpresa { get; set; }
        public Guid IdEmpresaSucursal { get; set; }
        public TipoDocumentoIdentidad TipoDocumento { get; set; }
        [StringLength(20)]
        public string NumeroDocumento { get; set; }
        [StringLength(100)]
        public string Nombres { get; set; }
        [StringLength(100)]
        public string Apellidos { get; set; }
        [StringLength(100)]
        public string Direccion { get; set; }
        [StringLength(10)]
        public string Ubigeo { get; set; }
        [StringLength(100)]
        public string Referencia { get; set; }
        [StringLength(20)]
        public string Celular { get; set; }
        [StringLength(50)]
        public string Correo { get; set; }
        [StringLength(200)]
        public string Observacion { get; set; }
    }
}
