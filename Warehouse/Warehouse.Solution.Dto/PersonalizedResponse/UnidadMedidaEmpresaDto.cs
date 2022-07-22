using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Dto.PersonalizedResponse
{
    public class UnidadMedidaEmpresaDto
    {
        public Guid? Id { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public bool? EnUso { get; set; }

    }
}
