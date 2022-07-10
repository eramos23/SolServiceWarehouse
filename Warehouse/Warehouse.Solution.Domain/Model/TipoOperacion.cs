using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Domain.Model
{
    public class TipoOperacion
    {
        public TipoOperacion()
        {
        }

        [Key]
        [Column("Id", TypeName = "char(2)")]
        public string Id { get; set; }

        public Guid IdEmpresa { get; set; }
        public Guid IdEmpresaSucursal { get; set; }
        
        [StringLength(100)]
        public string Nombre { get; set; }
        [StringLength(200)]
        public string Observacion { get; set; }
    }
}
