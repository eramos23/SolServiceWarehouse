using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Domain.Model
{
    public class HistoryModel
    {
        public Guid? IdUsuarioCrea { get; set; }

        public DateTime? FechaCreacion { get; set; } = DateTime.Now;
        public Guid? IdUsuarioModifica { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool Vigente { get; set; } = true;

    }
}
