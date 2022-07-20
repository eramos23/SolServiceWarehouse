using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Domain.Model
{
    public class ProductoUnidadMedida : HistoryModel
    {
        public ProductoUnidadMedida()
        {
            EmpresaUnidadMedidas = new List<EmpresaUnidadMedida>();
        }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        [StringLength(10)]
        public string Codigo { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        public int IdEstado { get; set; }

        [ForeignKey("IdEstado")]
        public Catalogo Estado { get; set; }
        public List<EmpresaUnidadMedida> EmpresaUnidadMedidas { get; set; }
        public List<Producto> Productos { get; set; }
    }
}
