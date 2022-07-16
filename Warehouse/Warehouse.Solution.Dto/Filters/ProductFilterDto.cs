using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Dto.Filters
{
    public class ProductFilterDto
    {
        public string? IdEmpresa { get; set; }
        public string? IdEmpresaSucursal { get; set; }
        public string? Texto { get; set; }
    }
}
