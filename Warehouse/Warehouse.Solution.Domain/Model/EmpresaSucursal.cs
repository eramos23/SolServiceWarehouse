using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Domain.Model
{
    public partial class EmpresaSucursal : HistoryModel
    {
        public EmpresaSucursal()
        {
            
        }
        [Key]
        public Guid Id { get; set; }
        public Guid IdEmpresa { get; set; }

        [StringLength(200)]
        public string Direccion { get; set; }

        [StringLength(300)]
        public string Descripcion { get; set; }

        [ForeignKey("IdEmpresa")]
        public Empresa Empresa { get; set; }
    }
}
