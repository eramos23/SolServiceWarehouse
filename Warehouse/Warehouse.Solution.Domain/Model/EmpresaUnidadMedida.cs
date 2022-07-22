using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Domain.Model
{
    public partial class EmpresaUnidadMedida : HistoryModel
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdEmpresa { get; set; }
        public Guid IdUnidadMedida { get; set; }
        [StringLength(10)]
        public string Codigo { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }
        [StringLength(200)]
        public string Descripcion { get; set; }
        public bool EnUso { get; set; } // los que tienen ckec son los itpos de unidad de m. que usará la empresa y sus sucursales.
        public Empresa Empresa { get; set; }
        public UnidadMedida UnidadMedida { get; set; }

    }
}
