using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Dto
{
    public class EmpresaDto
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<EmpresaSucursalDto> EmpresaSucursales { get; set; }
    }
}
