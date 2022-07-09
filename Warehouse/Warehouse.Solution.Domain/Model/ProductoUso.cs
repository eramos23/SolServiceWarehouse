using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Domain.Model
{
    public class ProductoUso
    {
        public ProductoUso()
        {

        }
        public Guid Id { get; set; }
        public Guid IdEmpresa { get; set; }
        public Guid IdEmpresaSucursal { get; set; }
        public string Nombre { get; set; }
        public string Obserbacion { get; set; }
        public List<Producto> Productos { get; set; }
    }
}
