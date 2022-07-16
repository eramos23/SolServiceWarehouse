using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Dto
{
    public class ProductoDto
    {
        public Guid Id { get; set; }
        public Guid IdEmpresa { get; set; }
        public Guid IdEmpresaSucursal { get; set; }
        public string CodigoBarra { get; set; }
        public string Nombre { get; set; }
        public List<ProductoCategoriaDto> Categorias { get; set; }
        public List<ProductoUsoDto> Usos { get; set; }
        public List<UnidadMedidaDto> UnidadesMedida { get; set; }
        public List<ProductoMarcaDto> Marcas { get; set; }
        public List<LaboratorioDto> Laboratorios { get; set; }
        public string RegistroSanitario { get; set; }
        public string UbicacionAlmacen { get; set; }
        public int StockMinimo { get; set; }
        public decimal PrecioVentaUnitario { get; set; }
        public decimal PrecioVenta2 { get; set; }
        public decimal PrecioVentaMayor { get; set; }
        public string Observaciones { get; set; }
        public int StockIngreso { get; set; }
        public int StockEgreso { get; set; }
        public int stockSaldo { get; set; }
        public int CierreAnual { get; set; }
    }
}
