using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Domain.Model
{
    public class Catalogo
    {
        public Catalogo()
        {

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(20)]
        public string Grupo { get; set; }
        [StringLength(5)]
        public string Codigo { get; set; } //puede ser codigo sunat(ejm: para las unidades de medida)
        [StringLength(100)]
        public string Nombre { get; set; }
        [StringLength(200)]
        public string Descripcion { get; set; }
    }
}
