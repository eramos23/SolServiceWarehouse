using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Domain.Model
{
    public class Producto : HistoryModel
    {
        public Producto()
        {

        }
        public Guid Id { get; set; }
        public Guid IdEmpresa { get; set; }
        public Guid IdEmpresaSucursal { get; set; }
        public string CodigoBarra { get; set; }
        public string Nombre { get; set; }
        public ProductoCategoria Categoria { get; set; }
    }
}
