using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Solution.Domain.Model;

namespace Warehouse.Solution.Domain.DbContexts
{
    public partial class WarehouseDbContext : DbContext
    {
        public WarehouseDbContext(DbContextOptions<WarehouseDbContext> options) 
            : base(options)
        {

        }
        public DbSet<TipoDocumentoIdentidad> TipoDocumentoIdentidad { get; set; }
        public DbSet<EntidadFinanciera> EntidadFinanciera { get; set; }
        public DbSet<UnidadMedida> UnidadMedida { get; set; }
        public DbSet<FormaPago> FormaPago { get; set; }
        public DbSet<ImpuestoMoneda> ImpuestoMoneda { get; set; }
        public DbSet<Laboratorio> Laboratorio { get; set; }
        public DbSet<TipoNotaCredito> TipoNotaCredito { get; set; }
        public DbSet<MotivoNotaCredito> MotivoNotaCredito { get; set; }
        public DbSet<TipoOperacion> TipoOperacion { get; set; }
        public DbSet<Ubigeo> Ubigeo { get; set; }

        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<EmpresaSucursal> EmpresaSucursal { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<Catalogo> Catalogo { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<EmpresaUnidadMedida> EmpresaUnidadMedida { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<ProductoCategoria> ProductoCategoria { get; set; }
        public DbSet<ProductoMarca> ProductoMarca { get; set; }
        public DbSet<ProductoUso> ProductoUso { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoDocumentoIdentidad>().ToTable("tipo_documento_identidad");
            modelBuilder.Entity<EntidadFinanciera>().ToTable("entidad_financiera");
            modelBuilder.Entity<TipoComprobantePago>().ToTable("tipo_comprobante_pago");
            modelBuilder.Entity<UnidadMedida>().ToTable("unidad_medida");
            modelBuilder.Entity<EmpresaUnidadMedida>().ToTable("empresa_unidad_medida");
            modelBuilder.Entity<FormaPago>().ToTable("forma_pago");
            modelBuilder.Entity<ImpuestoMoneda>().ToTable("impuesto_moneda");
            modelBuilder.Entity<MotivoNotaCredito>().ToTable("motivo_nota_credito");
            modelBuilder.Entity<ProductoCategoria>().ToTable("producto_categoria");
            modelBuilder.Entity<ProductoMarca>().ToTable("producto_marca");
            modelBuilder.Entity<ProductoUso>().ToTable("producto_uso");
            modelBuilder.Entity<TipoComprobantePago>().ToTable("tipo_comprobante_pago");
            modelBuilder.Entity<TipoNotaCredito>().ToTable("tipo_nota_credito");
            modelBuilder.Entity<TipoOperacion>().ToTable("tipo_operacion");

            //Muchos a muchos
            modelBuilder.Entity<EmpresaUnidadMedida>().HasKey(x => new { x.IdEmpresa, x.IdUnidadMedida });

            modelBuilder.Entity<Empresa>().ToTable("empresa");
            modelBuilder.Entity<EmpresaSucursal>().ToTable("empresa_sucursal");
            modelBuilder.Entity<Proveedor>().ToTable("proveedor");

            modelBuilder.Entity<TipoDocumentoIdentidad>().HasData(new TipoDocumentoIdentidad[]
            {
                new TipoDocumentoIdentidad{ Id = "0", Nombre = "OTROS TIPOS DE DOCUMENTOS"},
                new TipoDocumentoIdentidad{ Id = "1", Nombre = "DOCUMENTO NACIONAL DE IDENTIDAD (DNI)"},
                new TipoDocumentoIdentidad{ Id = "4", Nombre = "CARNET DE EXTRANJERIA"},
                new TipoDocumentoIdentidad{ Id = "6", Nombre = "REGISTRO ÚNICO DE CONTRIBUYENTES"},
                new TipoDocumentoIdentidad{ Id = "7", Nombre = "PASAPORTE"},
                new TipoDocumentoIdentidad{ Id = "A", Nombre = "CÉDULA DIPLOMÁTICA DE IDENTIDAD"}
            });

            modelBuilder.Entity<EntidadFinanciera>().HasData(new EntidadFinanciera[]
            {
                new EntidadFinanciera { Id = "01", Nombre = "CENTRAL RESERVA DEL PERU"},
                new EntidadFinanciera { Id = "02", Nombre = "DE CREDITO DEL PERU"},
                new EntidadFinanciera { Id = "03", Nombre = "INTERNACIONAL DEL PERU"},
                new EntidadFinanciera { Id = "05", Nombre = "LATINO"},
                new EntidadFinanciera { Id = "07", Nombre = "CITIBANK DEL PERU S.A."},
                new EntidadFinanciera { Id = "08", Nombre = "STANDARD CHARTERED"},
                new EntidadFinanciera { Id = "09", Nombre = "SCOTIABANK PERU"},
                new EntidadFinanciera { Id = "11", Nombre = "CONTINENTAL"},
                new EntidadFinanciera { Id = "12", Nombre = "DE LIMA"},
                new EntidadFinanciera { Id = "16", Nombre = "MERCANTIL"},
                new EntidadFinanciera { Id = "18", Nombre = "NACION"},
                new EntidadFinanciera { Id = "22", Nombre = "SANTANDER CENTRAL HISPANO"},
                new EntidadFinanciera { Id = "23", Nombre = "DE COMERCIO"},
                new EntidadFinanciera { Id = "25", Nombre = "REPUBLICA"},
                new EntidadFinanciera { Id = "26", Nombre = "NBK BANK"},
                new EntidadFinanciera { Id = "29", Nombre = "BANCOSUR"},
                new EntidadFinanciera { Id = "35", Nombre = "FINANCIERO DEL PERU"},
                new EntidadFinanciera { Id = "37", Nombre = "DEL PROGRESO"},
                new EntidadFinanciera { Id = "38", Nombre = "INTERAMERICANO FINANZAS"},
                new EntidadFinanciera { Id = "39", Nombre = "BANEX"},
                new EntidadFinanciera { Id = "40", Nombre = "NUEVO MUNDO"},
                new EntidadFinanciera { Id = "41", Nombre = "SUDAMERICANO"},
                new EntidadFinanciera { Id = "42", Nombre = "DEL LIBERTADOR"},
                new EntidadFinanciera { Id = "43", Nombre = "DEL TRABAJO"},
                new EntidadFinanciera { Id = "44", Nombre = "SOLVENTA"},
                new EntidadFinanciera { Id = "45", Nombre = "SERBANCO SA."},
                new EntidadFinanciera { Id = "46", Nombre = "BANK OF BOSTON"},
                new EntidadFinanciera { Id = "47", Nombre = "ORION"},
                new EntidadFinanciera { Id = "48", Nombre = "DEL PAIS"},
                new EntidadFinanciera { Id = "49", Nombre = "MI BANCO"},
                new EntidadFinanciera { Id = "50", Nombre = "BNP PARIBAS"},
                new EntidadFinanciera { Id = "53", Nombre = "HSBC BANK PERU S.A."},
                new EntidadFinanciera { Id = "99", Nombre = "OTROS"}
            });

            modelBuilder.Entity<TipoComprobantePago>().HasData(new TipoComprobantePago[]
            {
                new TipoComprobantePago { Id="00", Nombre = "Otros"},
                new TipoComprobantePago { Id="01", Nombre = "Factura"},
                new TipoComprobantePago { Id="02", Nombre = "Recibo por Honorarios"},
                new TipoComprobantePago { Id="03", Nombre = "Boleta de Venta"},
                new TipoComprobantePago { Id="04", Nombre = "Liquidación de compra"},
                new TipoComprobantePago { Id="07", Nombre = "Nota de crédito"},
                new TipoComprobantePago { Id="08", Nombre = "Nota de débito"},
                new TipoComprobantePago { Id="09", Nombre = "Guía de remisión - Remitente"},
                new TipoComprobantePago { Id="10", Nombre = "Recibo por Arrendamiento"},
                new TipoComprobantePago { Id="12", Nombre = "Ticket o cinta emitido por máquina registradora"},
                new TipoComprobantePago { Id="31", Nombre = "Guía de Remisión - Transportista"}
            });

            modelBuilder.Entity<UnidadMedida>().HasData(new UnidadMedida[]
            {
                new UnidadMedida { Id = "01", Nombre ="KILOGRAMOS" },
                new UnidadMedida { Id = "02", Nombre ="LIBRAS" },
                new UnidadMedida { Id = "03", Nombre ="TONELADAS LARGAS" },
                new UnidadMedida { Id = "04", Nombre ="TONELADAS MÉTRICAS" },
                new UnidadMedida { Id = "05", Nombre ="TONELADAS CORTAS" },
                new UnidadMedida { Id = "06", Nombre ="GRAMOS" },
                new UnidadMedida { Id = "07", Nombre ="UNIDADES" },
                new UnidadMedida { Id = "08", Nombre ="LITROS" },
                new UnidadMedida { Id = "09", Nombre ="GALONES" },
                new UnidadMedida { Id = "10", Nombre ="BARRILES" },
                new UnidadMedida { Id = "11", Nombre ="LATAS" },
                new UnidadMedida { Id = "12", Nombre ="CAJAS" },
                new UnidadMedida { Id = "13", Nombre ="MILLARES" },
                new UnidadMedida { Id = "14", Nombre ="METROS CÚBICOS" },
                new UnidadMedida { Id = "15", Nombre ="METROS" },
                new UnidadMedida { Id = "99", Nombre ="OTROS (ESPECIFICAR)" }
            });
            //modelBuilder.Entity<TipoOperacion>().HasData(new TipoOperacion[]
            //{
            //    new TipoOperacion { Id="01", Nombre="VENTA"},
            //    new TipoOperacion { Id="02", Nombre="COMPRA"},
            //    new TipoOperacion { Id="03", Nombre="CONSIGNACIÓN RECIBIDA"},
            //    new TipoOperacion { Id="04", Nombre="CONSIGNACIÓN ENTREGADA"},
            //    new TipoOperacion { Id="05", Nombre="DEVOLUCIÓN RECIBIDA"},
            //    new TipoOperacion { Id="06", Nombre="DEVOLUCIÓN ENTREGADA"},
            //    new TipoOperacion { Id="07", Nombre="PROMOCIÓN"},
            //    new TipoOperacion { Id="08", Nombre="PREMIO"},
            //    new TipoOperacion { Id="09", Nombre="DONACIÓN"},
            //    new TipoOperacion { Id="10", Nombre="SALIDA A PRODUCCIÓN"},
            //    new TipoOperacion { Id="11", Nombre="TRANSFERENCIA ENTRE ALMACENES"},
            //    new TipoOperacion { Id="12", Nombre="RETIRO"},
            //    new TipoOperacion { Id="13", Nombre="MERMAS"},
            //    new TipoOperacion { Id="14", Nombre="DESMEDROS"},
            //    new TipoOperacion { Id="15", Nombre="DESTRUCCIÓN"},
            //    new TipoOperacion { Id="16", Nombre="SALDO INICIAL"},
            //    new TipoOperacion { Id="99", Nombre="OTROS (ESPECIFICAR)"}
            //});

            modelBuilder.Entity<Empresa>().HasData(new Empresa[]
            {
                new Empresa{ Id = new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"), Nombre = "FARMACIA RAMOS S.A."},
                new Empresa{ Id = new Guid("3785474b-f656-4d49-99c6-c144708d6a62"), Nombre = "MINIMARKETS RAMOS S.A."}
            });

            modelBuilder.Entity<EmpresaSucursal>().HasData(new EmpresaSucursal[]
            {
                new EmpresaSucursal{ Id = new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520904"), IdEmpresa = new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"), Direccion = "Av. Los angeles 232", Nombre = "Farmacia Principal de Los Olivos"},
                new EmpresaSucursal{ Id = new Guid("4649554b-ab5e-4647-866e-1cc4e4b50ffa"), IdEmpresa = new Guid("3785474b-f656-4d49-99c6-c144708d6a62"), Direccion = "Av. Caceres de Hurre 122", Nombre = "Minimarket los Olivos 1"},
                new EmpresaSucursal{ Id = new Guid("9414a1d9-c237-4e95-9d76-3290ecb1c551"), IdEmpresa = new Guid("3785474b-f656-4d49-99c6-c144708d6a62"), Direccion = "Av. Proceres 121", Nombre = "Minimarket los Olivos 2"}

            });

            modelBuilder.Entity<Catalogo>().HasData(new Catalogo[]
            {
                new Catalogo{ Id=1, Abreviatura = "ACT", Nombre="Activo", Descripcion = "Registro activo"},
                new Catalogo{ Id=2, Abreviatura = "IACT", Nombre="Inactivo", Descripcion = "Registro inactivo"},
                new Catalogo{ Id=10, Abreviatura = "FACS", Nombre="Factura-Stock", Descripcion = "Factura Stoack"},
                new Catalogo{ Id=11, Abreviatura = "GAST", Nombre="Gastos", Descripcion = "Gastos"},

            });

            modelBuilder.Entity<Proveedor>().HasData(new Proveedor[]
            {
                new Proveedor{
                    Id = new Guid("4e7da830-71a2-4758-9b21-ec7d0dda7984"),
                    IdEmpresa = new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"),
                    IdEmpresaSucursal = new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520904"),
                    Nombre = "Proveedor de mecicamentos S.A.",
                    IdTipoDocumento = "6",
                    NumeroDocumento = "20718623451",
                    Direccion = "Jr. Mira flores, calle 2 pabellon 52",
                    Correo = "proveedordemedicamentos@gmail.com",
                    Telefono = "10-12222-22",
                    IdTipoProveedor = 10,
                    //NombreTipoProveedor = "FACTURACION-STOCK",
                    IdEstado = 1
                }
            });

            modelBuilder.Entity<Proveedor>().HasQueryFilter(g => g.Vigente);
        }
    }
}
