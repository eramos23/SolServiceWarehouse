using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Domain.Model
{
    public class ImpuestoMoneda : HistoryModel
    {
        public ImpuestoMoneda()
        {

        }

        [Key]
        public Guid Id { get; set; }
        public Guid IdEmpresa { get; set; }
        public Guid IdEmpresaSucursal { get; set; }
        [StringLength(5)]
        public string SimboloMoneda { get; set; }
        [StringLength(10)]
        public string NombreMoneda { get; set; }
        [StringLength(10)]
        public string AbreviaturaImpuesto { get; set; }
        public decimal PorcentajeImpuesto { get; set; }


    }
}
