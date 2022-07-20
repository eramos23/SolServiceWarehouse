using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Dto
{
    public class LaboratorioDto
    {
        public Guid Id { get; set; }
        public Guid IdEmpresa { get; set; }
        public Guid IdEmpresaSucursal { get; set; }
        public string Nombre { get; set; }
        public int IdEstado { get; set; }
        public CatalogoDto Estado { get; set; }
    }

    public class PostLaboratorioDto
    {
        public Guid Id { get; set; }
        public Guid IdEmpresa { get; set; }
        public Guid IdEmpresaSucursal { get; set; }
        public string Nombre { get; set; }
        public int IdEstado { get; set; }
    }

    public class PutLaboratorioDto
    {
        public Guid Id { get; set; }
        public Guid IdEmpresa { get; set; }
        public Guid IdEmpresaSucursal { get; set; }
        public string Nombre { get; set; }
        public int IdEstado { get; set; }
    }
}
