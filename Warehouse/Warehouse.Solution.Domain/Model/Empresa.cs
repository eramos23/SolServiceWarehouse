using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Domain.Model
{
    public partial class Empresa : HistoryModel
    {
        public Empresa()
        {
            EmpresaSucursales = new List<EmpresaSucursal>();
            EmpresaUnidadMedidas = new List<EmpresaUnidadMedida>();
        }
        [Key]
        public Guid Id { get; set; }

        [StringLength(200)]
        public string Nombre { get; set; }

        public ICollection<EmpresaSucursal> EmpresaSucursales { get; set; }
        public ICollection<EmpresaUnidadMedida> EmpresaUnidadMedidas { get; set; }
    }
}
