using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Solution.Domain.Model
{
    public class Producto : HistoryModel
    {
        public Producto()
        {

        }
        public Guid Id { get; set; }
        public Guid IdEmpresa { get; set; }
        public Guid IdEmpresaSucursal { get; set; }
        [StringLength(200)]
        public string CodigoBarra { get; set; }
        [StringLength(100)]
        public string Nombre { get; set; }
        public ProductoCategoria Categoria { get; set; }
        public List<ProductoUso> Usos { get; set; }
        public List<UnidadMedida> UnidadesMedida { get; set; }
        public List<ProductoMarca> Marcas { get; set; }
        public List<Laboratorio> Laboratorios { get; set; }
        [StringLength(200)]
        public string RegistroSanitario { get; set; }
        [StringLength(200)]
        public string UbicacionAlmacen { get; set; }
        public int StockMinimo { get; set; }
        public decimal PrecioVentaUnitario { get; set; }
        public decimal PrecioVenta2 { get; set; }
        public decimal PrecioVentaMayor { get; set; }
        [StringLength(200)]
        public string Observaciones { get; set; }
        public int StockIngreso { get; set; }
        public int StockEgreso { get; set; }
        public int stockSaldo { get; set; }
        public int CierreAnual { get; set; }

    }
}
