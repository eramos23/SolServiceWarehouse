using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Domain.Model
{
    public class Enumeracion : HistoryModel
    {
        public Enumeracion()
        {

        }

        [Key]
        public Guid Id { get; set; }
        public Guid IdEmpresa { get; set; }
        public Guid IdEmpresaSucursal { get; set; }
        [StringLength(50)]
        public string TipoComprobante { get; set; }
        [StringLength(5)]
        //Serie(F001)
        public string Identificador { get; set; }
        public int Correlativo { get; set; }
        [StringLength(200)]
        public string Observacion { get; set; }
    }
}
