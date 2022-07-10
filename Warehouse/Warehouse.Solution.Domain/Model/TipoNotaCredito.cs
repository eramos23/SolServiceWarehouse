using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Domain.Model
{
    public class TipoNotaCredito
    {
        public TipoNotaCredito()
        {

        }
        [Key]
        public Guid Id { get; set; }

        public Guid IdEmpresa { get; set; }
        public Guid IdEmpresaSucursal { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }
        [StringLength(200)]
        public string Observacion { get; set; }
    }
}
