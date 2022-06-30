using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Domain.Model
{
    public partial class EntidadFinanciera
    {
        [Key]
        [Column("Id", TypeName = "char(2)")]
        public string Id { get; set; }
        [StringLength(50)]
        public string Descripcion { get; set; }
    }
}
