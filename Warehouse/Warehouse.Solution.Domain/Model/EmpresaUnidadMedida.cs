using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Domain.Model
{
    public partial class EmpresaUnidadMedida : HistoryModel
    {
        public Guid IdEmpresa { get; set; }
        public Guid IdUnidadMedida { get; set; }

        public Empresa Empresa { get; set; }
        public ProductoUnidadMedida UnidadMedida { get; set; }

    }
}
