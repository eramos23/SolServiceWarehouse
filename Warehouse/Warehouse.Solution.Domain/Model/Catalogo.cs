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
        [StringLength(10)]
        public string Abreviatura { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }
        [StringLength(200)]
        public string Descripcion { get; set; }
    }
}
