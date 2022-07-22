using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Dto
{
    public class EmpresaUnidadMedidaDto
    {
        public Guid Id { get; set; }
        public Guid IdEmpresa { get; set; }
        public Guid IdUnidadMedida { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public bool EnUso { get; set; }
    }

    public class PostEmpresaUnidadMedidaDto
    {
        public Guid Id { get; set; }
        public Guid IdEmpresa { get; set; }
        public Guid IdUnidadMedida { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public bool EnUso { get; set; }
    }

    public class PutEmpresaUnidadMedidaDto
    {
        public Guid Id { get; set; }
        public Guid IdEmpresa { get; set; }
        public Guid IdUnidadMedida { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public bool EnUso { get; set; }
    }
}
