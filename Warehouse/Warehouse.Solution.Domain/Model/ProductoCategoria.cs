using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Domain.Model
{
    public class ProductoCategoria : HistoryModel
    {
        public ProductoCategoria()
        {

        }
        [Key]
        public Guid Id { get; set; }
        public Guid IdEmpresa { get; set; }
        public Guid IdEmpresaSucursal { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }
        [StringLength(200)]
        public string Observacion { get; set; }
        public int IdEstado { get; set; }

        [ForeignKey("IdEstado")]
        public Catalogo Estado { get; set; }
        public List<Producto> Productos { get; set; }
    }
}
