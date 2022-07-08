﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Warehouse.Solution.Domain.DbContexts;

namespace Warehouse.Solution.Domain.Migrations
{
    [DbContext(typeof(WarehouseDbContext))]
    partial class WarehouseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Warehouse.Solution.Domain.Model.Catalogo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Abreviatura")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Catalogo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Abreviatura = "ACT",
                            Descripcion = "Registro activo",
                            Nombre = "Activo"
                        },
                        new
                        {
                            Id = 2,
                            Abreviatura = "IACT",
                            Descripcion = "Registro inactivo",
                            Nombre = "Inactivo"
                        });
                });

            modelBuilder.Entity("Warehouse.Solution.Domain.Model.Empresa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("IdUsuarioCrea")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("IdUsuarioModifica")
                        .HasColumnType("char(36)");

                    b.Property<string>("Nombre")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<bool>("Vigente")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("empresa");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"),
                            FechaCreacion = new DateTime(2022, 7, 7, 15, 15, 32, 525, DateTimeKind.Local).AddTicks(3144),
                            Nombre = "FARMACIA RAMOS S.A.",
                            Vigente = true
                        },
                        new
                        {
                            Id = new Guid("3785474b-f656-4d49-99c6-c144708d6a62"),
                            FechaCreacion = new DateTime(2022, 7, 7, 15, 15, 32, 527, DateTimeKind.Local).AddTicks(2283),
                            Nombre = "MINIMARKETS RAMOS S.A.",
                            Vigente = true
                        });
                });

            modelBuilder.Entity("Warehouse.Solution.Domain.Model.EmpresaSucursal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Direccion")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("IdEmpresa")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("IdUsuarioCrea")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("IdUsuarioModifica")
                        .HasColumnType("char(36)");

                    b.Property<bool>("Vigente")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("IdEmpresa");

                    b.ToTable("empresa_sucursal");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520904"),
                            Descripcion = "Farmacia Principal de Los Olivos",
                            Direccion = "Av. Los angeles 232",
                            FechaCreacion = new DateTime(2022, 7, 7, 15, 15, 32, 527, DateTimeKind.Local).AddTicks(3163),
                            IdEmpresa = new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"),
                            Vigente = true
                        },
                        new
                        {
                            Id = new Guid("4649554b-ab5e-4647-866e-1cc4e4b50ffa"),
                            Descripcion = "Minimarket los Olivos 1",
                            Direccion = "Av. Caceres de Hurre 122",
                            FechaCreacion = new DateTime(2022, 7, 7, 15, 15, 32, 527, DateTimeKind.Local).AddTicks(9524),
                            IdEmpresa = new Guid("3785474b-f656-4d49-99c6-c144708d6a62"),
                            Vigente = true
                        },
                        new
                        {
                            Id = new Guid("9414a1d9-c237-4e95-9d76-3290ecb1c551"),
                            Descripcion = "Minimarket los Olivos 2",
                            Direccion = "Av. Proceres 121",
                            FechaCreacion = new DateTime(2022, 7, 7, 15, 15, 32, 527, DateTimeKind.Local).AddTicks(9563),
                            IdEmpresa = new Guid("3785474b-f656-4d49-99c6-c144708d6a62"),
                            Vigente = true
                        });
                });

            modelBuilder.Entity("Warehouse.Solution.Domain.Model.EmpresaUnidadMedida", b =>
                {
                    b.Property<Guid>("IdEmpresa")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("IdUnidadMedida")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("EmpresaId")
                        .HasColumnType("char(36)");

                    b.Property<string>("UnidadMedidaId")
                        .HasColumnType("char(2)");

                    b.HasKey("IdEmpresa", "IdUnidadMedida");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("UnidadMedidaId");

                    b.ToTable("empresa_unidad_medida");
                });

            modelBuilder.Entity("Warehouse.Solution.Domain.Model.EntidadFinanciera", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("char(2)")
                        .HasColumnName("Id");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("entidad_financiera");

                    b.HasData(
                        new
                        {
                            Id = "01",
                            Descripcion = "CENTRAL RESERVA DEL PERU"
                        },
                        new
                        {
                            Id = "02",
                            Descripcion = "DE CREDITO DEL PERU"
                        },
                        new
                        {
                            Id = "03",
                            Descripcion = "INTERNACIONAL DEL PERU"
                        },
                        new
                        {
                            Id = "05",
                            Descripcion = "LATINO"
                        },
                        new
                        {
                            Id = "07",
                            Descripcion = "CITIBANK DEL PERU S.A."
                        },
                        new
                        {
                            Id = "08",
                            Descripcion = "STANDARD CHARTERED"
                        },
                        new
                        {
                            Id = "09",
                            Descripcion = "SCOTIABANK PERU"
                        },
                        new
                        {
                            Id = "11",
                            Descripcion = "CONTINENTAL"
                        },
                        new
                        {
                            Id = "12",
                            Descripcion = "DE LIMA"
                        },
                        new
                        {
                            Id = "16",
                            Descripcion = "MERCANTIL"
                        },
                        new
                        {
                            Id = "18",
                            Descripcion = "NACION"
                        },
                        new
                        {
                            Id = "22",
                            Descripcion = "SANTANDER CENTRAL HISPANO"
                        },
                        new
                        {
                            Id = "23",
                            Descripcion = "DE COMERCIO"
                        },
                        new
                        {
                            Id = "25",
                            Descripcion = "REPUBLICA"
                        },
                        new
                        {
                            Id = "26",
                            Descripcion = "NBK BANK"
                        },
                        new
                        {
                            Id = "29",
                            Descripcion = "BANCOSUR"
                        },
                        new
                        {
                            Id = "35",
                            Descripcion = "FINANCIERO DEL PERU"
                        },
                        new
                        {
                            Id = "37",
                            Descripcion = "DEL PROGRESO"
                        },
                        new
                        {
                            Id = "38",
                            Descripcion = "INTERAMERICANO FINANZAS"
                        },
                        new
                        {
                            Id = "39",
                            Descripcion = "BANEX"
                        },
                        new
                        {
                            Id = "40",
                            Descripcion = "NUEVO MUNDO"
                        },
                        new
                        {
                            Id = "41",
                            Descripcion = "SUDAMERICANO"
                        },
                        new
                        {
                            Id = "42",
                            Descripcion = "DEL LIBERTADOR"
                        },
                        new
                        {
                            Id = "43",
                            Descripcion = "DEL TRABAJO"
                        },
                        new
                        {
                            Id = "44",
                            Descripcion = "SOLVENTA"
                        },
                        new
                        {
                            Id = "45",
                            Descripcion = "SERBANCO SA."
                        },
                        new
                        {
                            Id = "46",
                            Descripcion = "BANK OF BOSTON"
                        },
                        new
                        {
                            Id = "47",
                            Descripcion = "ORION"
                        },
                        new
                        {
                            Id = "48",
                            Descripcion = "DEL PAIS"
                        },
                        new
                        {
                            Id = "49",
                            Descripcion = "MI BANCO"
                        },
                        new
                        {
                            Id = "50",
                            Descripcion = "BNP PARIBAS"
                        },
                        new
                        {
                            Id = "53",
                            Descripcion = "HSBC BANK PERU S.A."
                        },
                        new
                        {
                            Id = "99",
                            Descripcion = "OTROS"
                        });
                });

            modelBuilder.Entity("Warehouse.Solution.Domain.Model.Proveedor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Correo")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Direccion")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Docuemto")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("IdEmpresa")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("IdEmpresaSucursal")
                        .HasColumnType("char(36)");

                    b.Property<int>("IdEstado")
                        .HasColumnType("int");

                    b.Property<string>("IdTipoDocumento")
                        .HasColumnType("char(1)")
                        .HasColumnName("IdTipoDocumento");

                    b.Property<Guid?>("IdUsuarioCrea")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("IdUsuarioModifica")
                        .HasColumnType("char(36)");

                    b.Property<string>("Nombre")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("NombreTipoProveedor")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefono")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("TipoProveedor")
                        .HasColumnType("int");

                    b.Property<bool>("Vigente")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("IdEmpresa");

                    b.HasIndex("IdEmpresaSucursal");

                    b.HasIndex("IdEstado");

                    b.HasIndex("IdTipoDocumento");

                    b.ToTable("proveedor");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4e7da830-71a2-4758-9b21-ec7d0dda7984"),
                            Correo = "proveedordemedicamentos@gmail.com",
                            Direccion = "Jr. Mira flores, calle 2 pabellon 52",
                            Docuemto = "20718623451",
                            FechaCreacion = new DateTime(2022, 7, 7, 15, 15, 32, 528, DateTimeKind.Local).AddTicks(2168),
                            IdEmpresa = new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"),
                            IdEmpresaSucursal = new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520904"),
                            IdEstado = 1,
                            IdTipoDocumento = "6",
                            Nombre = "Proveedor de mecicamentos S.A.",
                            NombreTipoProveedor = "FACTURACION-STOCK",
                            Telefono = "10-12222-22",
                            TipoProveedor = 1,
                            Vigente = true
                        });
                });

            modelBuilder.Entity("Warehouse.Solution.Domain.Model.TipoComprobantePago", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("char(2)")
                        .HasColumnName("Id");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("tipo_comprobante_pago");

                    b.HasData(
                        new
                        {
                            Id = "00",
                            Descripcion = "Otros"
                        },
                        new
                        {
                            Id = "01",
                            Descripcion = "Factura"
                        },
                        new
                        {
                            Id = "02",
                            Descripcion = "Recibo por Honorarios"
                        },
                        new
                        {
                            Id = "03",
                            Descripcion = "Boleta de Venta"
                        },
                        new
                        {
                            Id = "04",
                            Descripcion = "Liquidación de compra"
                        },
                        new
                        {
                            Id = "07",
                            Descripcion = "Nota de crédito"
                        },
                        new
                        {
                            Id = "08",
                            Descripcion = "Nota de débito"
                        },
                        new
                        {
                            Id = "09",
                            Descripcion = "Guía de remisión - Remitente"
                        },
                        new
                        {
                            Id = "10",
                            Descripcion = "Recibo por Arrendamiento"
                        },
                        new
                        {
                            Id = "12",
                            Descripcion = "Ticket o cinta emitido por máquina registradora"
                        },
                        new
                        {
                            Id = "31",
                            Descripcion = "Guía de Remisión - Transportista"
                        });
                });

            modelBuilder.Entity("Warehouse.Solution.Domain.Model.TipoDocumentoIdentidad", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("char(1)")
                        .HasColumnName("Id");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("tipo_documento_identidad");

                    b.HasData(
                        new
                        {
                            Id = "0",
                            Descripcion = "OTROS TIPOS DE DOCUMENTOS"
                        },
                        new
                        {
                            Id = "1",
                            Descripcion = "DOCUMENTO NACIONAL DE IDENTIDAD (DNI)"
                        },
                        new
                        {
                            Id = "4",
                            Descripcion = "CARNET DE EXTRANJERIA"
                        },
                        new
                        {
                            Id = "6",
                            Descripcion = "REGISTRO ÚNICO DE CONTRIBUYENTES"
                        },
                        new
                        {
                            Id = "7",
                            Descripcion = "PASAPORTE"
                        },
                        new
                        {
                            Id = "A",
                            Descripcion = "CÉDULA DIPLOMÁTICA DE IDENTIDAD"
                        });
                });

            modelBuilder.Entity("Warehouse.Solution.Domain.Model.UnidadMedida", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("char(2)")
                        .HasColumnName("Id");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("unidad_medida");

                    b.HasData(
                        new
                        {
                            Id = "01",
                            Descripcion = "KILOGRAMOS"
                        },
                        new
                        {
                            Id = "02",
                            Descripcion = "LIBRAS"
                        },
                        new
                        {
                            Id = "03",
                            Descripcion = "TONELADAS LARGAS"
                        },
                        new
                        {
                            Id = "04",
                            Descripcion = "TONELADAS MÉTRICAS"
                        },
                        new
                        {
                            Id = "05",
                            Descripcion = "TONELADAS CORTAS"
                        },
                        new
                        {
                            Id = "06",
                            Descripcion = "GRAMOS"
                        },
                        new
                        {
                            Id = "07",
                            Descripcion = "UNIDADES"
                        },
                        new
                        {
                            Id = "08",
                            Descripcion = "LITROS"
                        },
                        new
                        {
                            Id = "09",
                            Descripcion = "GALONES"
                        },
                        new
                        {
                            Id = "10",
                            Descripcion = "BARRILES"
                        },
                        new
                        {
                            Id = "11",
                            Descripcion = "LATAS"
                        },
                        new
                        {
                            Id = "12",
                            Descripcion = "CAJAS"
                        },
                        new
                        {
                            Id = "13",
                            Descripcion = "MILLARES"
                        },
                        new
                        {
                            Id = "14",
                            Descripcion = "METROS CÚBICOS"
                        },
                        new
                        {
                            Id = "15",
                            Descripcion = "METROS"
                        },
                        new
                        {
                            Id = "99",
                            Descripcion = "OTROS (ESPECIFICAR)"
                        });
                });

            modelBuilder.Entity("Warehouse.Solution.Domain.Model.EmpresaSucursal", b =>
                {
                    b.HasOne("Warehouse.Solution.Domain.Model.Empresa", "Empresa")
                        .WithMany("EmpresaSucursales")
                        .HasForeignKey("IdEmpresa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("Warehouse.Solution.Domain.Model.EmpresaUnidadMedida", b =>
                {
                    b.HasOne("Warehouse.Solution.Domain.Model.Empresa", "Empresa")
                        .WithMany("EmpresaUnidadMedidas")
                        .HasForeignKey("EmpresaId");

                    b.HasOne("Warehouse.Solution.Domain.Model.UnidadMedida", "UnidadMedida")
                        .WithMany("EmpresaUnidadMedidas")
                        .HasForeignKey("UnidadMedidaId");

                    b.Navigation("Empresa");

                    b.Navigation("UnidadMedida");
                });

            modelBuilder.Entity("Warehouse.Solution.Domain.Model.Proveedor", b =>
                {
                    b.HasOne("Warehouse.Solution.Domain.Model.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("IdEmpresa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Warehouse.Solution.Domain.Model.EmpresaSucursal", "EmpresaSucursal")
                        .WithMany()
                        .HasForeignKey("IdEmpresaSucursal")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Warehouse.Solution.Domain.Model.Catalogo", "Estado")
                        .WithMany()
                        .HasForeignKey("IdEstado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Warehouse.Solution.Domain.Model.TipoDocumentoIdentidad", "TipoDocumentoIdentidad")
                        .WithMany()
                        .HasForeignKey("IdTipoDocumento");

                    b.Navigation("Empresa");

                    b.Navigation("EmpresaSucursal");

                    b.Navigation("Estado");

                    b.Navigation("TipoDocumentoIdentidad");
                });

            modelBuilder.Entity("Warehouse.Solution.Domain.Model.Empresa", b =>
                {
                    b.Navigation("EmpresaSucursales");

                    b.Navigation("EmpresaUnidadMedidas");
                });

            modelBuilder.Entity("Warehouse.Solution.Domain.Model.UnidadMedida", b =>
                {
                    b.Navigation("EmpresaUnidadMedidas");
                });
#pragma warning restore 612, 618
        }
    }
}
