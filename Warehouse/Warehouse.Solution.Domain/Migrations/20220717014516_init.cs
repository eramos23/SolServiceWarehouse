using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Solution.Domain.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Catalogo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Grupo = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Codigo = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogo", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "entidad_financiera",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(2)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entidad_financiera", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "forma_pago",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresa = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresaSucursal = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Observacion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_forma_pago", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "impuesto_moneda",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresa = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresaSucursal = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    SimboloMoneda = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreMoneda = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AbreviaturaImpuesto = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PorcentajeImpuesto = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    IdUsuarioCrea = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IdUsuarioModifica = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Vigente = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_impuesto_moneda", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "motivo_nota_credito",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresa = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresaSucursal = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Observacion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_motivo_nota_credito", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipo_comprobante_pago",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(2)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_comprobante_pago", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipo_documento_identidad",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(1)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_documento_identidad", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipo_nota_credito",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresa = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresaSucursal = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Observacion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_nota_credito", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipo_operacion",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(2)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdEmpresa = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresaSucursal = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Observacion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_operacion", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ubigeo",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CodigoDepartamento = table.Column<string>(type: "char(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CodigoProvincia = table.Column<string>(type: "char(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CodigoDistrito = table.Column<string>(type: "char(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdUsuarioCrea = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IdUsuarioModifica = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Vigente = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubigeo", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresa = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresaSucursal = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CodigoBarra = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegistroSanitario = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UbicacionAlmacen = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StockMinimo = table.Column<int>(type: "int", nullable: false),
                    PrecioVentaUnitario = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    PrecioVenta2 = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    PrecioVentaMayor = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Observaciones = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StockIngreso = table.Column<int>(type: "int", nullable: false),
                    StockEgreso = table.Column<int>(type: "int", nullable: false),
                    stockSaldo = table.Column<int>(type: "int", nullable: false),
                    CierreAnual = table.Column<int>(type: "int", nullable: false),
                    IdEstado = table.Column<int>(type: "int", nullable: false),
                    IdUsuarioCrea = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IdUsuarioModifica = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Vigente = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Producto_Catalogo_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "Catalogo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "producto_categoria",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresa = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresaSucursal = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Observacion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdEstado = table.Column<int>(type: "int", nullable: false),
                    IdUsuarioCrea = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IdUsuarioModifica = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Vigente = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producto_categoria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_producto_categoria_Catalogo_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "Catalogo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "producto_marca",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresa = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresaSucursal = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Observacion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdEstado = table.Column<int>(type: "int", nullable: false),
                    IdUsuarioCrea = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IdUsuarioModifica = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Vigente = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producto_marca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_producto_marca_Catalogo_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "Catalogo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "producto_unidad_medida",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Codigo = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdEstado = table.Column<int>(type: "int", nullable: false),
                    IdUsuarioCrea = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IdUsuarioModifica = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Vigente = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producto_unidad_medida", x => x.Id);
                    table.ForeignKey(
                        name: "FK_producto_unidad_medida_Catalogo_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "Catalogo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "producto_uso",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresa = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresaSucursal = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Observacion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdEstado = table.Column<int>(type: "int", nullable: false),
                    IdUsuarioCrea = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IdUsuarioModifica = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Vigente = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producto_uso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_producto_uso_Catalogo_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "Catalogo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresa = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresaSucursal = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TipoDocumentoId = table.Column<string>(type: "char(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroDocumento = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombres = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellidos = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ubigeo = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Referencia = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Celular = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Correo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Observacion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdUsuarioCrea = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IdUsuarioModifica = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Vigente = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_tipo_documento_identidad_TipoDocumentoId",
                        column: x => x.TipoDocumentoId,
                        principalTable: "tipo_documento_identidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "empresa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Nombre = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreComercial = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoDocumentoId = table.Column<string>(type: "char(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroDocumento = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Correo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ubigeo = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Referencia = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Actividad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RepresentanteLegal = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cargo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dni = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CuentaBancaria1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CuentaBancaria2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TextoComprobante = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    urlImagen = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdUsuarioCrea = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IdUsuarioModifica = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Vigente = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empresa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_empresa_tipo_documento_identidad_TipoDocumentoId",
                        column: x => x.TipoDocumentoId,
                        principalTable: "tipo_documento_identidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Laboratorio",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresa = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresaSucursal = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdEstado = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    IdUsuarioCrea = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IdUsuarioModifica = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Vigente = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laboratorio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Laboratorio_Catalogo_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "Catalogo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Laboratorio_Producto_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Producto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductoProductoCategoria",
                columns: table => new
                {
                    CategoriasId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProductosId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoProductoCategoria", x => new { x.CategoriasId, x.ProductosId });
                    table.ForeignKey(
                        name: "FK_ProductoProductoCategoria_producto_categoria_CategoriasId",
                        column: x => x.CategoriasId,
                        principalTable: "producto_categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductoProductoCategoria_Producto_ProductosId",
                        column: x => x.ProductosId,
                        principalTable: "Producto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductoProductoMarca",
                columns: table => new
                {
                    MarcasId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProductosId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoProductoMarca", x => new { x.MarcasId, x.ProductosId });
                    table.ForeignKey(
                        name: "FK_ProductoProductoMarca_producto_marca_MarcasId",
                        column: x => x.MarcasId,
                        principalTable: "producto_marca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductoProductoMarca_Producto_ProductosId",
                        column: x => x.ProductosId,
                        principalTable: "Producto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductoProductoUnidadMedida",
                columns: table => new
                {
                    ProductosId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UnidadesMedidaId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoProductoUnidadMedida", x => new { x.ProductosId, x.UnidadesMedidaId });
                    table.ForeignKey(
                        name: "FK_ProductoProductoUnidadMedida_Producto_ProductosId",
                        column: x => x.ProductosId,
                        principalTable: "Producto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductoProductoUnidadMedida_producto_unidad_medida_Unidades~",
                        column: x => x.UnidadesMedidaId,
                        principalTable: "producto_unidad_medida",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductoProductoUso",
                columns: table => new
                {
                    ProductosId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UsosId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoProductoUso", x => new { x.ProductosId, x.UsosId });
                    table.ForeignKey(
                        name: "FK_ProductoProductoUso_Producto_ProductosId",
                        column: x => x.ProductosId,
                        principalTable: "Producto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductoProductoUso_producto_uso_UsosId",
                        column: x => x.UsosId,
                        principalTable: "producto_uso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "empresa_sucursal",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresa = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Direccion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdUsuarioCrea = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IdUsuarioModifica = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Vigente = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empresa_sucursal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_empresa_sucursal_empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "empresa_unidad_medida",
                columns: table => new
                {
                    IdEmpresa = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdUnidadMedida = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    EmpresaId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    UnidadMedidaId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    IdUsuarioCrea = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IdUsuarioModifica = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Vigente = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empresa_unidad_medida", x => new { x.IdEmpresa, x.IdUnidadMedida });
                    table.ForeignKey(
                        name: "FK_empresa_unidad_medida_empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_empresa_unidad_medida_producto_unidad_medida_UnidadMedidaId",
                        column: x => x.UnidadMedidaId,
                        principalTable: "producto_unidad_medida",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "proveedor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresa = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresaSucursal = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoDocumento = table.Column<string>(type: "char(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroDocumento = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Correo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoProveedor = table.Column<int>(type: "int", nullable: false),
                    IdEstado = table.Column<int>(type: "int", nullable: false),
                    IdUsuarioCrea = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IdUsuarioModifica = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Vigente = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proveedor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_proveedor_Catalogo_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "Catalogo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_proveedor_Catalogo_IdTipoProveedor",
                        column: x => x.IdTipoProveedor,
                        principalTable: "Catalogo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_proveedor_empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_proveedor_empresa_sucursal_IdEmpresaSucursal",
                        column: x => x.IdEmpresaSucursal,
                        principalTable: "empresa_sucursal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_proveedor_tipo_documento_identidad_IdTipoDocumento",
                        column: x => x.IdTipoDocumento,
                        principalTable: "tipo_documento_identidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Catalogo",
                columns: new[] { "Id", "Codigo", "Descripcion", "Grupo", "Nombre" },
                values: new object[,]
                {
                    { 1, "ACT", "Registro activo", "Estados", "Activo" },
                    { 2, "IACT", "Registro inactivo", "Estados", "Inactivo" },
                    { 10, "FACS", "Factura Stoack", "TipoProveedor", "Factura-Stock" },
                    { 11, "GAST", "Gastos", "TipoProveedor", "Gastos" }
                });

            migrationBuilder.InsertData(
                table: "empresa",
                columns: new[] { "Id", "Actividad", "Cargo", "Correo", "CuentaBancaria1", "CuentaBancaria2", "Direccion", "Dni", "FechaCreacion", "FechaInicio", "FechaModificacion", "IdUsuarioCrea", "IdUsuarioModifica", "Nombre", "NombreComercial", "NumeroDocumento", "Referencia", "RepresentanteLegal", "Telefono", "TextoComprobante", "TipoDocumentoId", "Ubigeo", "Vigente", "urlImagen" },
                values: new object[,]
                {
                    { new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"), null, null, null, null, null, null, null, new DateTime(2022, 7, 16, 20, 45, 16, 26, DateTimeKind.Local).AddTicks(7287), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "FARMACIA RAMOS S.A.", null, null, null, null, null, null, null, null, true, null },
                    { new Guid("3785474b-f656-4d49-99c6-c144708d6a62"), null, null, null, null, null, null, null, new DateTime(2022, 7, 16, 20, 45, 16, 26, DateTimeKind.Local).AddTicks(7949), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "MINIMARKETS RAMOS S.A.", null, null, null, null, null, null, null, null, true, null }
                });

            migrationBuilder.InsertData(
                table: "entidad_financiera",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { "38", "INTERAMERICANO FINANZAS" },
                    { "39", "BANEX" },
                    { "40", "NUEVO MUNDO" },
                    { "42", "DEL LIBERTADOR" },
                    { "43", "DEL TRABAJO" },
                    { "44", "SOLVENTA" },
                    { "45", "SERBANCO SA." },
                    { "48", "DEL PAIS" },
                    { "47", "ORION" },
                    { "37", "DEL PROGRESO" },
                    { "49", "MI BANCO" },
                    { "50", "BNP PARIBAS" },
                    { "53", "HSBC BANK PERU S.A." },
                    { "99", "OTROS" },
                    { "46", "BANK OF BOSTON" },
                    { "35", "FINANCIERO DEL PERU" },
                    { "41", "SUDAMERICANO" },
                    { "26", "NBK BANK" },
                    { "29", "BANCOSUR" },
                    { "01", "CENTRAL RESERVA DEL PERU" },
                    { "02", "DE CREDITO DEL PERU" },
                    { "03", "INTERNACIONAL DEL PERU" },
                    { "05", "LATINO" },
                    { "07", "CITIBANK DEL PERU S.A." },
                    { "09", "SCOTIABANK PERU" },
                    { "08", "STANDARD CHARTERED" },
                    { "12", "DE LIMA" },
                    { "16", "MERCANTIL" },
                    { "18", "NACION" },
                    { "22", "SANTANDER CENTRAL HISPANO" },
                    { "23", "DE COMERCIO" },
                    { "25", "REPUBLICA" },
                    { "11", "CONTINENTAL" }
                });

            migrationBuilder.InsertData(
                table: "tipo_comprobante_pago",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { "09", "Guía de remisión - Remitente" },
                    { "31", "Guía de Remisión - Transportista" },
                    { "12", "Ticket o cinta emitido por máquina registradora" },
                    { "10", "Recibo por Arrendamiento" },
                    { "08", "Nota de débito" },
                    { "00", "Otros" },
                    { "04", "Liquidación de compra" },
                    { "03", "Boleta de Venta" },
                    { "02", "Recibo por Honorarios" },
                    { "01", "Factura" },
                    { "07", "Nota de crédito" }
                });

            migrationBuilder.InsertData(
                table: "tipo_documento_identidad",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { "7", "PASAPORTE" },
                    { "0", "OTROS TIPOS DE DOCUMENTOS" },
                    { "1", "DOCUMENTO NACIONAL DE IDENTIDAD (DNI)" },
                    { "4", "CARNET DE EXTRANJERIA" },
                    { "6", "REGISTRO ÚNICO DE CONTRIBUYENTES" },
                    { "A", "CÉDULA DIPLOMÁTICA DE IDENTIDAD" }
                });

            migrationBuilder.InsertData(
                table: "empresa_sucursal",
                columns: new[] { "Id", "Direccion", "FechaCreacion", "FechaModificacion", "IdEmpresa", "IdUsuarioCrea", "IdUsuarioModifica", "Nombre", "Vigente" },
                values: new object[,]
                {
                    { new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520904"), "Av. Los angeles 232", new DateTime(2022, 7, 16, 20, 45, 16, 26, DateTimeKind.Local).AddTicks(8239), null, new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"), null, null, "Farmacia Principal de Los Olivos", true },
                    { new Guid("4649554b-ab5e-4647-866e-1cc4e4b50ffa"), "Av. Caceres de Hurre 122", new DateTime(2022, 7, 16, 20, 45, 16, 26, DateTimeKind.Local).AddTicks(8824), null, new Guid("3785474b-f656-4d49-99c6-c144708d6a62"), null, null, "Minimarket los Olivos 1", true },
                    { new Guid("9414a1d9-c237-4e95-9d76-3290ecb1c551"), "Av. Proceres 121", new DateTime(2022, 7, 16, 20, 45, 16, 26, DateTimeKind.Local).AddTicks(8831), null, new Guid("3785474b-f656-4d49-99c6-c144708d6a62"), null, null, "Minimarket los Olivos 2", true }
                });

            migrationBuilder.InsertData(
                table: "producto_unidad_medida",
                columns: new[] { "Id", "Codigo", "Descripcion", "FechaCreacion", "FechaModificacion", "IdEstado", "IdUsuarioCrea", "IdUsuarioModifica", "Nombre", "Vigente" },
                values: new object[,]
                {
                    { new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520901"), "KGM", "KILOGRAMO", new DateTime(2022, 7, 16, 20, 45, 16, 23, DateTimeKind.Local).AddTicks(2287), null, 1, null, null, "Kilogramo", true },
                    { new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520902"), "LBR", "KILOGRAMO", new DateTime(2022, 7, 16, 20, 45, 16, 26, DateTimeKind.Local).AddTicks(6313), null, 1, null, null, "Libras", true }
                });

            migrationBuilder.InsertData(
                table: "proveedor",
                columns: new[] { "Id", "Correo", "Direccion", "FechaCreacion", "FechaModificacion", "IdEmpresa", "IdEmpresaSucursal", "IdEstado", "IdTipoDocumento", "IdTipoProveedor", "IdUsuarioCrea", "IdUsuarioModifica", "Nombre", "NumeroDocumento", "Telefono", "Vigente" },
                values: new object[] { new Guid("4e7da830-71a2-4758-9b21-ec7d0dda7984"), "proveedordemedicamentos@gmail.com", "Jr. Mira flores, calle 2 pabellon 52", new DateTime(2022, 7, 16, 20, 45, 16, 26, DateTimeKind.Local).AddTicks(9985), null, new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"), new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520904"), 1, "6", 10, null, null, "Proveedor de mecicamentos S.A.", "20718623451", "10-12222-22", true });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_TipoDocumentoId",
                table: "Cliente",
                column: "TipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_empresa_TipoDocumentoId",
                table: "empresa",
                column: "TipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_empresa_sucursal_IdEmpresa",
                table: "empresa_sucursal",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_empresa_unidad_medida_EmpresaId",
                table: "empresa_unidad_medida",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_empresa_unidad_medida_UnidadMedidaId",
                table: "empresa_unidad_medida",
                column: "UnidadMedidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Laboratorio_IdEstado",
                table: "Laboratorio",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Laboratorio_ProductoId",
                table: "Laboratorio",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_IdEstado",
                table: "Producto",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_producto_categoria_IdEstado",
                table: "producto_categoria",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_producto_marca_IdEstado",
                table: "producto_marca",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_producto_unidad_medida_IdEstado",
                table: "producto_unidad_medida",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_producto_uso_IdEstado",
                table: "producto_uso",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoProductoCategoria_ProductosId",
                table: "ProductoProductoCategoria",
                column: "ProductosId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoProductoMarca_ProductosId",
                table: "ProductoProductoMarca",
                column: "ProductosId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoProductoUnidadMedida_UnidadesMedidaId",
                table: "ProductoProductoUnidadMedida",
                column: "UnidadesMedidaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoProductoUso_UsosId",
                table: "ProductoProductoUso",
                column: "UsosId");

            migrationBuilder.CreateIndex(
                name: "IX_proveedor_IdEmpresa",
                table: "proveedor",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_proveedor_IdEmpresaSucursal",
                table: "proveedor",
                column: "IdEmpresaSucursal");

            migrationBuilder.CreateIndex(
                name: "IX_proveedor_IdEstado",
                table: "proveedor",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_proveedor_IdTipoDocumento",
                table: "proveedor",
                column: "IdTipoDocumento");

            migrationBuilder.CreateIndex(
                name: "IX_proveedor_IdTipoProveedor",
                table: "proveedor",
                column: "IdTipoProveedor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "empresa_unidad_medida");

            migrationBuilder.DropTable(
                name: "entidad_financiera");

            migrationBuilder.DropTable(
                name: "forma_pago");

            migrationBuilder.DropTable(
                name: "impuesto_moneda");

            migrationBuilder.DropTable(
                name: "Laboratorio");

            migrationBuilder.DropTable(
                name: "motivo_nota_credito");

            migrationBuilder.DropTable(
                name: "ProductoProductoCategoria");

            migrationBuilder.DropTable(
                name: "ProductoProductoMarca");

            migrationBuilder.DropTable(
                name: "ProductoProductoUnidadMedida");

            migrationBuilder.DropTable(
                name: "ProductoProductoUso");

            migrationBuilder.DropTable(
                name: "proveedor");

            migrationBuilder.DropTable(
                name: "tipo_comprobante_pago");

            migrationBuilder.DropTable(
                name: "tipo_nota_credito");

            migrationBuilder.DropTable(
                name: "tipo_operacion");

            migrationBuilder.DropTable(
                name: "Ubigeo");

            migrationBuilder.DropTable(
                name: "producto_categoria");

            migrationBuilder.DropTable(
                name: "producto_marca");

            migrationBuilder.DropTable(
                name: "producto_unidad_medida");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "producto_uso");

            migrationBuilder.DropTable(
                name: "empresa_sucursal");

            migrationBuilder.DropTable(
                name: "Catalogo");

            migrationBuilder.DropTable(
                name: "empresa");

            migrationBuilder.DropTable(
                name: "tipo_documento_identidad");
        }
    }
}
