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

        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<EmpresaSucursal> EmpresaSucursal { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<Catalogo> Catalogo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoDocumentoIdentidad>().ToTable("tipo_documento_identidad");
            modelBuilder.Entity<EntidadFinanciera>().ToTable("entidad_financiera");
            modelBuilder.Entity<TipoComprobantePago>().ToTable("tipo_comprobante_pago");
            modelBuilder.Entity<UnidadMedida>().ToTable("unidad_medida");
            modelBuilder.Entity<EmpresaUnidadMedida>().ToTable("empresa_unidad_medida");

            //Muchos a muchos
            modelBuilder.Entity<EmpresaUnidadMedida>().HasKey(x => new { x.IdEmpresa, x.IdUnidadMedida });

            modelBuilder.Entity<Empresa>().ToTable("empresa");
            modelBuilder.Entity<EmpresaSucursal>().ToTable("empresa_sucursal");
            modelBuilder.Entity<Proveedor>().ToTable("proveedor");

            modelBuilder.Entity<TipoDocumentoIdentidad>().HasData(new TipoDocumentoIdentidad[]
            {
                new TipoDocumentoIdentidad{ Id = "0", Descripcion = "OTROS TIPOS DE DOCUMENTOS"},
                new TipoDocumentoIdentidad{ Id = "1", Descripcion = "DOCUMENTO NACIONAL DE IDENTIDAD (DNI)"},
                new TipoDocumentoIdentidad{ Id = "4", Descripcion = "CARNET DE EXTRANJERIA"},
                new TipoDocumentoIdentidad{ Id = "6", Descripcion = "REGISTRO ÚNICO DE CONTRIBUYENTES"},
                new TipoDocumentoIdentidad{ Id = "7", Descripcion = "PASAPORTE"},
                new TipoDocumentoIdentidad{ Id = "A", Descripcion = "CÉDULA DIPLOMÁTICA DE IDENTIDAD"}
            });

            modelBuilder.Entity<EntidadFinanciera>().HasData(new EntidadFinanciera[]
            {
                new EntidadFinanciera { Id = "01",  Descripcion = "CENTRAL RESERVA DEL PERU"},
                new EntidadFinanciera { Id = "02",  Descripcion = "DE CREDITO DEL PERU"},
                new EntidadFinanciera { Id = "03",  Descripcion = "INTERNACIONAL DEL PERU"},
                new EntidadFinanciera { Id = "05",  Descripcion = "LATINO"},
                new EntidadFinanciera { Id = "07",  Descripcion = "CITIBANK DEL PERU S.A."},
                new EntidadFinanciera { Id = "08",  Descripcion = "STANDARD CHARTERED"},
                new EntidadFinanciera { Id = "09",  Descripcion = "SCOTIABANK PERU"},
                new EntidadFinanciera { Id = "11",  Descripcion = "CONTINENTAL"},
                new EntidadFinanciera { Id = "12",  Descripcion = "DE LIMA"},
                new EntidadFinanciera { Id = "16",  Descripcion = "MERCANTIL"},
                new EntidadFinanciera { Id = "18",  Descripcion = "NACION"},
                new EntidadFinanciera { Id = "22",  Descripcion = "SANTANDER CENTRAL HISPANO"},
                new EntidadFinanciera { Id = "23",  Descripcion = "DE COMERCIO"},
                new EntidadFinanciera { Id = "25",  Descripcion = "REPUBLICA"},
                new EntidadFinanciera { Id = "26",  Descripcion = "NBK BANK"},
                new EntidadFinanciera { Id = "29",  Descripcion = "BANCOSUR"},
                new EntidadFinanciera { Id = "35",  Descripcion = "FINANCIERO DEL PERU"},
                new EntidadFinanciera { Id = "37",  Descripcion = "DEL PROGRESO"},
                new EntidadFinanciera { Id = "38",  Descripcion = "INTERAMERICANO FINANZAS"},
                new EntidadFinanciera { Id = "39",  Descripcion = "BANEX"},
                new EntidadFinanciera { Id = "40",  Descripcion = "NUEVO MUNDO"},
                new EntidadFinanciera { Id = "41",  Descripcion = "SUDAMERICANO"},
                new EntidadFinanciera { Id = "42",  Descripcion = "DEL LIBERTADOR"},
                new EntidadFinanciera { Id = "43",  Descripcion = "DEL TRABAJO"},
                new EntidadFinanciera { Id = "44",  Descripcion = "SOLVENTA"},
                new EntidadFinanciera { Id = "45",  Descripcion = "SERBANCO SA."},
                new EntidadFinanciera { Id = "46",  Descripcion = "BANK OF BOSTON"},
                new EntidadFinanciera { Id = "47",  Descripcion = "ORION"},
                new EntidadFinanciera { Id = "48",  Descripcion = "DEL PAIS"},
                new EntidadFinanciera { Id = "49",  Descripcion = "MI BANCO"},
                new EntidadFinanciera { Id = "50",  Descripcion = "BNP PARIBAS"},
                new EntidadFinanciera { Id = "53",  Descripcion = "HSBC BANK PERU S.A."},
                new EntidadFinanciera { Id = "99",  Descripcion = "OTROS"}
            });

            modelBuilder.Entity<TipoComprobantePago>().HasData(new TipoComprobantePago[]
            {
                new TipoComprobantePago { Id="00",  Descripcion = "Otros"},
                new TipoComprobantePago { Id="01",  Descripcion = "Factura"},
                new TipoComprobantePago { Id="02",  Descripcion = "Recibo por Honorarios"},
                new TipoComprobantePago { Id="03",  Descripcion = "Boleta de Venta"},
                new TipoComprobantePago { Id="04",  Descripcion = "Liquidación de compra"},
                new TipoComprobantePago { Id="07",  Descripcion = "Nota de crédito"},
                new TipoComprobantePago { Id="08",  Descripcion = "Nota de débito"},
                new TipoComprobantePago { Id="09",  Descripcion = "Guía de remisión - Remitente"},
                new TipoComprobantePago { Id="10",  Descripcion = "Recibo por Arrendamiento"},
                new TipoComprobantePago { Id="12",  Descripcion = "Ticket o cinta emitido por máquina registradora"},
                new TipoComprobantePago { Id="31",  Descripcion = "Guía de Remisión - Transportista"}
            });

            modelBuilder.Entity<UnidadMedida>().HasData(new UnidadMedida[]
            {
                new UnidadMedida { Id = "01", Descripcion ="KILOGRAMOS" },
                new UnidadMedida { Id = "02", Descripcion ="LIBRAS" },
                new UnidadMedida { Id = "03", Descripcion ="TONELADAS LARGAS" },
                new UnidadMedida { Id = "04", Descripcion ="TONELADAS MÉTRICAS" },
                new UnidadMedida { Id = "05", Descripcion ="TONELADAS CORTAS" },
                new UnidadMedida { Id = "06", Descripcion ="GRAMOS" },
                new UnidadMedida { Id = "07", Descripcion ="UNIDADES" },
                new UnidadMedida { Id = "08", Descripcion ="LITROS" },
                new UnidadMedida { Id = "09", Descripcion ="GALONES" },
                new UnidadMedida { Id = "10", Descripcion ="BARRILES" },
                new UnidadMedida { Id = "11", Descripcion ="LATAS" },
                new UnidadMedida { Id = "12", Descripcion ="CAJAS" },
                new UnidadMedida { Id = "13", Descripcion ="MILLARES" },
                new UnidadMedida { Id = "14", Descripcion ="METROS CÚBICOS" },
                new UnidadMedida { Id = "15", Descripcion ="METROS" },
                new UnidadMedida { Id = "99", Descripcion ="OTROS (ESPECIFICAR)" }
            });

            modelBuilder.Entity<Empresa>().HasData(new Empresa[]
            {
                new Empresa{ Id = new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"), Nombre = "FARMACIA RAMOS S.A."},
                new Empresa{ Id = new Guid("3785474b-f656-4d49-99c6-c144708d6a62"), Nombre = "MINIMARKETS RAMOS S.A."}
            });

            modelBuilder.Entity<EmpresaSucursal>().HasData(new EmpresaSucursal[]
            {
                new EmpresaSucursal{ Id = new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520904"), IdEmpresa = new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"), Direccion = "Av. Los angeles 232", Descripcion = "Farmacia Principal de Los Olivos"},
                new EmpresaSucursal{ Id = new Guid("4649554b-ab5e-4647-866e-1cc4e4b50ffa"), IdEmpresa = new Guid("3785474b-f656-4d49-99c6-c144708d6a62"), Direccion = "Av. Caceres de Hurre 122", Descripcion = "Minimarket los Olivos 1"},
                new EmpresaSucursal{ Id = new Guid("9414a1d9-c237-4e95-9d76-3290ecb1c551"), IdEmpresa = new Guid("3785474b-f656-4d49-99c6-c144708d6a62"), Direccion = "Av. Proceres 121", Descripcion = "Minimarket los Olivos 2"}

            });

            modelBuilder.Entity<Catalogo>().HasData(new Catalogo[]
            {
                new Catalogo{ Id=1, Abreviatura = "ACT", Nombre="Activo", Descripcion = "Registro activo"},
                new Catalogo{ Id=2, Abreviatura = "IACT", Nombre="Inactivo", Descripcion = "Registro inactivo"},

            });


            modelBuilder.Entity<Proveedor>().HasData(new Proveedor[]
            {
                new Proveedor{
                    Id = new Guid("4e7da830-71a2-4758-9b21-ec7d0dda7984"),
                    IdEmpresa = new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"),
                    IdEmpresaSucursal = new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520904"),
                    Nombre = "Proveedor de mecicamentos S.A.",
                    IdTipoDocumento = "6",
                    Docuemto = "20718623451",
                    Direccion = "Jr. Mira flores, calle 2 pabellon 52",
                    Correo = "proveedordemedicamentos@gmail.com",
                    Telefono = "10-12222-22",
                    TipoProveedor = 1,
                    NombreTipoProveedor = "FACTURACION-STOCK",
                    IdEstado = 1
                }
            });
        }
    }
}
