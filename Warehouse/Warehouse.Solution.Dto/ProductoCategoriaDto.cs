using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Dto
{
    public class ProductoCategoriaDto
    {
        public Guid Id { get; set; }
        public Guid IdEmpresa { get; set; }
        public Guid IdEmpresaSucursal { get; set; }
        public string Nombre { get; set; }
        public string Observacion { get; set; }
        public int IdEstado { get; set; }
        public CatalogoDto Estado { get; set; }
    }

    public class PostProductoCategoriaDto
    {
        public Guid Id { get; set; }
        public Guid IdEmpresa { get; set; }
        public Guid IdEmpresaSucursal { get; set; }
        public string Nombre { get; set; }
        public string Observacion { get; set; }
        public int IdEstado { get; set; }
    }

    public class PutProductoCategoriaDto
    {
        public Guid Id { get; set; }
        public Guid IdEmpresa { get; set; }
        public Guid IdEmpresaSucursal { get; set; }
        public string Nombre { get; set; }
        public string Observacion { get; set; }
        public int IdEstado { get; set; }
    }
}
