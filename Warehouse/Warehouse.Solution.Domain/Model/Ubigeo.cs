using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Domain.Model
{
    public class Ubigeo : HistoryModel
    {
        public Ubigeo()
        {

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [Column("CodigoDepartamento", TypeName = "char(2)")]
        public string CodigoDepartamento { get; set; }

        [Column("CodigoProvincia", TypeName = "char(2)")]
        public string CodigoProvincia { get; set; }

        [Column("CodigoDistrito", TypeName = "char(2)")]
        public string CodigoDistrito { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }
    }
}
