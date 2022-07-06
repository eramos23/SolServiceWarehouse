using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Dto
{
    public class EmpresaSucursalDto
    {
        public Guid Id { get; set; }
        public Guid IdEmpresa { get; set; }
        public string Direccion { get; set; }
        public string Descripcion { get; set; }
        public EmpresaDto Empresa { get; set; }
    }
}
