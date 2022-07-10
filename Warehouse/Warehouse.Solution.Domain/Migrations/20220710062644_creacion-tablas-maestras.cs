using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Solution.Domain.Migrations
{
    public partial class creaciontablasmaestras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "unidad_medida");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "entidad_financiera");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "tipo_documento_identidad",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "tipo_comprobante_pago",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Docuemto",
                table: "proveedor",
                newName: "NumeroDocumento");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "empresa_sucursal",
                newName: "Nombre");

            migrationBuilder.AddColumn<string>(
                name: "Abreviatura",
                table: "unidad_medida",
                type: "varchar(10)",
                maxLength: 10,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "unidad_medida",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductoId",
                table: "unidad_medida",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "proveedor",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "entidad_financiera",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Actividad",
                table: "empresa",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Cargo",
                table: "empresa",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Correo",
                table: "empresa",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CuentaBancaria1",
                table: "empresa",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CuentaBancaria2",
                table: "empresa",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "empresa",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Dni",
                table: "empresa",
                type: "varchar(20)",
                maxLength: 20,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaInicio",
                table: "empresa",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "NombreComercial",
                table: "empresa",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "NumeroDocumento",
                table: "empresa",
                type: "varchar(20)",
                maxLength: 20,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Referencia",
                table: "empresa",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "RepresentanteLegal",
                table: "empresa",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "empresa",
                type: "varchar(20)",
                maxLength: 20,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "TextoComprobante",
                table: "empresa",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "TipoDocumentoId",
                table: "empresa",
                type: "char(1)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Ubigeo",
                table: "empresa",
                type: "varchar(10)",
                maxLength: 10,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "urlImagen",
                table: "empresa",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Catalogo",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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
                name: "FormaPago",
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
                    table.PrimaryKey("PK_FormaPago", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ImpuestoMoneda",
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
                    table.PrimaryKey("PK_ImpuestoMoneda", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MotivoNotaCredito",
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
                    table.PrimaryKey("PK_MotivoNotaCredito", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductoCategoria",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresa = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresaSucursal = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
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
                    table.PrimaryKey("PK_ProductoCategoria", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductoMarca",
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
                    table.PrimaryKey("PK_ProductoMarca", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductoUso",
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
                    table.PrimaryKey("PK_ProductoUso", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoNotaCredito",
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
                    table.PrimaryKey("PK_TipoNotaCredito", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoOperacion",
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
                    table.PrimaryKey("PK_TipoOperacion", x => x.Id);
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
                    CategoriaId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
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
                        name: "FK_Producto_ProductoCategoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "ProductoCategoria",
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
                    ProductoId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laboratorio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Laboratorio_Producto_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Producto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        name: "FK_ProductoProductoMarca_Producto_ProductosId",
                        column: x => x.ProductosId,
                        principalTable: "Producto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductoProductoMarca_ProductoMarca_MarcasId",
                        column: x => x.MarcasId,
                        principalTable: "ProductoMarca",
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
                        name: "FK_ProductoProductoUso_ProductoUso_UsosId",
                        column: x => x.UsosId,
                        principalTable: "ProductoUso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("3785474b-f656-4d49-99c6-c144708d6a62"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 10, 1, 26, 44, 410, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 10, 1, 26, 44, 405, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("4649554b-ab5e-4647-866e-1cc4e4b50ffa"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 10, 1, 26, 44, 411, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("9414a1d9-c237-4e95-9d76-3290ecb1c551"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 10, 1, 26, 44, 411, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520904"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 10, 1, 26, 44, 410, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "01",
                column: "Nombre",
                value: "CENTRAL RESERVA DEL PERU");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "02",
                column: "Nombre",
                value: "DE CREDITO DEL PERU");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "03",
                column: "Nombre",
                value: "INTERNACIONAL DEL PERU");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "05",
                column: "Nombre",
                value: "LATINO");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "07",
                column: "Nombre",
                value: "CITIBANK DEL PERU S.A.");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "08",
                column: "Nombre",
                value: "STANDARD CHARTERED");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "09",
                column: "Nombre",
                value: "SCOTIABANK PERU");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "11",
                column: "Nombre",
                value: "CONTINENTAL");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "12",
                column: "Nombre",
                value: "DE LIMA");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "16",
                column: "Nombre",
                value: "MERCANTIL");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "18",
                column: "Nombre",
                value: "NACION");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "22",
                column: "Nombre",
                value: "SANTANDER CENTRAL HISPANO");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "23",
                column: "Nombre",
                value: "DE COMERCIO");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "25",
                column: "Nombre",
                value: "REPUBLICA");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "26",
                column: "Nombre",
                value: "NBK BANK");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "29",
                column: "Nombre",
                value: "BANCOSUR");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "35",
                column: "Nombre",
                value: "FINANCIERO DEL PERU");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "37",
                column: "Nombre",
                value: "DEL PROGRESO");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "38",
                column: "Nombre",
                value: "INTERAMERICANO FINANZAS");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "39",
                column: "Nombre",
                value: "BANEX");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "40",
                column: "Nombre",
                value: "NUEVO MUNDO");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "41",
                column: "Nombre",
                value: "SUDAMERICANO");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "42",
                column: "Nombre",
                value: "DEL LIBERTADOR");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "43",
                column: "Nombre",
                value: "DEL TRABAJO");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "44",
                column: "Nombre",
                value: "SOLVENTA");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "45",
                column: "Nombre",
                value: "SERBANCO SA.");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "46",
                column: "Nombre",
                value: "BANK OF BOSTON");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "47",
                column: "Nombre",
                value: "ORION");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "48",
                column: "Nombre",
                value: "DEL PAIS");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "49",
                column: "Nombre",
                value: "MI BANCO");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "50",
                column: "Nombre",
                value: "BNP PARIBAS");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "53",
                column: "Nombre",
                value: "HSBC BANK PERU S.A.");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "99",
                column: "Nombre",
                value: "OTROS");

            migrationBuilder.UpdateData(
                table: "proveedor",
                keyColumn: "Id",
                keyValue: new Guid("4e7da830-71a2-4758-9b21-ec7d0dda7984"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 10, 1, 26, 44, 411, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "01",
                column: "Nombre",
                value: "KILOGRAMOS");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "02",
                column: "Nombre",
                value: "LIBRAS");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "03",
                column: "Nombre",
                value: "TONELADAS LARGAS");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "04",
                column: "Nombre",
                value: "TONELADAS MÉTRICAS");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "05",
                column: "Nombre",
                value: "TONELADAS CORTAS");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "06",
                column: "Nombre",
                value: "GRAMOS");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "07",
                column: "Nombre",
                value: "UNIDADES");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "08",
                column: "Nombre",
                value: "LITROS");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "09",
                column: "Nombre",
                value: "GALONES");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "10",
                column: "Nombre",
                value: "BARRILES");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "11",
                column: "Nombre",
                value: "LATAS");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "12",
                column: "Nombre",
                value: "CAJAS");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "13",
                column: "Nombre",
                value: "MILLARES");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "14",
                column: "Nombre",
                value: "METROS CÚBICOS");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "15",
                column: "Nombre",
                value: "METROS");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "99",
                column: "Nombre",
                value: "OTROS (ESPECIFICAR)");

            migrationBuilder.CreateIndex(
                name: "IX_unidad_medida_ProductoId",
                table: "unidad_medida",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_empresa_TipoDocumentoId",
                table: "empresa",
                column: "TipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_TipoDocumentoId",
                table: "Cliente",
                column: "TipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Laboratorio_ProductoId",
                table: "Laboratorio",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_CategoriaId",
                table: "Producto",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoProductoMarca_ProductosId",
                table: "ProductoProductoMarca",
                column: "ProductosId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoProductoUso_UsosId",
                table: "ProductoProductoUso",
                column: "UsosId");

            migrationBuilder.AddForeignKey(
                name: "FK_empresa_tipo_documento_identidad_TipoDocumentoId",
                table: "empresa",
                column: "TipoDocumentoId",
                principalTable: "tipo_documento_identidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_unidad_medida_Producto_ProductoId",
                table: "unidad_medida",
                column: "ProductoId",
                principalTable: "Producto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_empresa_tipo_documento_identidad_TipoDocumentoId",
                table: "empresa");

            migrationBuilder.DropForeignKey(
                name: "FK_unidad_medida_Producto_ProductoId",
                table: "unidad_medida");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "FormaPago");

            migrationBuilder.DropTable(
                name: "ImpuestoMoneda");

            migrationBuilder.DropTable(
                name: "Laboratorio");

            migrationBuilder.DropTable(
                name: "MotivoNotaCredito");

            migrationBuilder.DropTable(
                name: "ProductoProductoMarca");

            migrationBuilder.DropTable(
                name: "ProductoProductoUso");

            migrationBuilder.DropTable(
                name: "TipoNotaCredito");

            migrationBuilder.DropTable(
                name: "TipoOperacion");

            migrationBuilder.DropTable(
                name: "Ubigeo");

            migrationBuilder.DropTable(
                name: "ProductoMarca");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "ProductoUso");

            migrationBuilder.DropTable(
                name: "ProductoCategoria");

            migrationBuilder.DropIndex(
                name: "IX_unidad_medida_ProductoId",
                table: "unidad_medida");

            migrationBuilder.DropIndex(
                name: "IX_empresa_TipoDocumentoId",
                table: "empresa");

            migrationBuilder.DropColumn(
                name: "Abreviatura",
                table: "unidad_medida");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "unidad_medida");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "unidad_medida");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "entidad_financiera");

            migrationBuilder.DropColumn(
                name: "Actividad",
                table: "empresa");

            migrationBuilder.DropColumn(
                name: "Cargo",
                table: "empresa");

            migrationBuilder.DropColumn(
                name: "Correo",
                table: "empresa");

            migrationBuilder.DropColumn(
                name: "CuentaBancaria1",
                table: "empresa");

            migrationBuilder.DropColumn(
                name: "CuentaBancaria2",
                table: "empresa");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "empresa");

            migrationBuilder.DropColumn(
                name: "Dni",
                table: "empresa");

            migrationBuilder.DropColumn(
                name: "FechaInicio",
                table: "empresa");

            migrationBuilder.DropColumn(
                name: "NombreComercial",
                table: "empresa");

            migrationBuilder.DropColumn(
                name: "NumeroDocumento",
                table: "empresa");

            migrationBuilder.DropColumn(
                name: "Referencia",
                table: "empresa");

            migrationBuilder.DropColumn(
                name: "RepresentanteLegal",
                table: "empresa");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "empresa");

            migrationBuilder.DropColumn(
                name: "TextoComprobante",
                table: "empresa");

            migrationBuilder.DropColumn(
                name: "TipoDocumentoId",
                table: "empresa");

            migrationBuilder.DropColumn(
                name: "Ubigeo",
                table: "empresa");

            migrationBuilder.DropColumn(
                name: "urlImagen",
                table: "empresa");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "tipo_documento_identidad",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "tipo_comprobante_pago",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "NumeroDocumento",
                table: "proveedor",
                newName: "Docuemto");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "empresa_sucursal",
                newName: "Descripcion");

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "unidad_medida",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "proveedor",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "entidad_financiera",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Catalogo",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("3785474b-f656-4d49-99c6-c144708d6a62"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 7, 15, 15, 32, 527, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 7, 15, 15, 32, 525, DateTimeKind.Local).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("4649554b-ab5e-4647-866e-1cc4e4b50ffa"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 7, 15, 15, 32, 527, DateTimeKind.Local).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("9414a1d9-c237-4e95-9d76-3290ecb1c551"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 7, 15, 15, 32, 527, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520904"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 7, 15, 15, 32, 527, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "01",
                column: "Descripcion",
                value: "CENTRAL RESERVA DEL PERU");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "02",
                column: "Descripcion",
                value: "DE CREDITO DEL PERU");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "03",
                column: "Descripcion",
                value: "INTERNACIONAL DEL PERU");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "05",
                column: "Descripcion",
                value: "LATINO");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "07",
                column: "Descripcion",
                value: "CITIBANK DEL PERU S.A.");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "08",
                column: "Descripcion",
                value: "STANDARD CHARTERED");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "09",
                column: "Descripcion",
                value: "SCOTIABANK PERU");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "11",
                column: "Descripcion",
                value: "CONTINENTAL");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "12",
                column: "Descripcion",
                value: "DE LIMA");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "16",
                column: "Descripcion",
                value: "MERCANTIL");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "18",
                column: "Descripcion",
                value: "NACION");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "22",
                column: "Descripcion",
                value: "SANTANDER CENTRAL HISPANO");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "23",
                column: "Descripcion",
                value: "DE COMERCIO");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "25",
                column: "Descripcion",
                value: "REPUBLICA");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "26",
                column: "Descripcion",
                value: "NBK BANK");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "29",
                column: "Descripcion",
                value: "BANCOSUR");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "35",
                column: "Descripcion",
                value: "FINANCIERO DEL PERU");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "37",
                column: "Descripcion",
                value: "DEL PROGRESO");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "38",
                column: "Descripcion",
                value: "INTERAMERICANO FINANZAS");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "39",
                column: "Descripcion",
                value: "BANEX");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "40",
                column: "Descripcion",
                value: "NUEVO MUNDO");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "41",
                column: "Descripcion",
                value: "SUDAMERICANO");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "42",
                column: "Descripcion",
                value: "DEL LIBERTADOR");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "43",
                column: "Descripcion",
                value: "DEL TRABAJO");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "44",
                column: "Descripcion",
                value: "SOLVENTA");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "45",
                column: "Descripcion",
                value: "SERBANCO SA.");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "46",
                column: "Descripcion",
                value: "BANK OF BOSTON");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "47",
                column: "Descripcion",
                value: "ORION");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "48",
                column: "Descripcion",
                value: "DEL PAIS");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "49",
                column: "Descripcion",
                value: "MI BANCO");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "50",
                column: "Descripcion",
                value: "BNP PARIBAS");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "53",
                column: "Descripcion",
                value: "HSBC BANK PERU S.A.");

            migrationBuilder.UpdateData(
                table: "entidad_financiera",
                keyColumn: "Id",
                keyValue: "99",
                column: "Descripcion",
                value: "OTROS");

            migrationBuilder.UpdateData(
                table: "proveedor",
                keyColumn: "Id",
                keyValue: new Guid("4e7da830-71a2-4758-9b21-ec7d0dda7984"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 7, 15, 15, 32, 528, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "01",
                column: "Descripcion",
                value: "KILOGRAMOS");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "02",
                column: "Descripcion",
                value: "LIBRAS");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "03",
                column: "Descripcion",
                value: "TONELADAS LARGAS");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "04",
                column: "Descripcion",
                value: "TONELADAS MÉTRICAS");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "05",
                column: "Descripcion",
                value: "TONELADAS CORTAS");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "06",
                column: "Descripcion",
                value: "GRAMOS");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "07",
                column: "Descripcion",
                value: "UNIDADES");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "08",
                column: "Descripcion",
                value: "LITROS");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "09",
                column: "Descripcion",
                value: "GALONES");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "10",
                column: "Descripcion",
                value: "BARRILES");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "11",
                column: "Descripcion",
                value: "LATAS");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "12",
                column: "Descripcion",
                value: "CAJAS");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "13",
                column: "Descripcion",
                value: "MILLARES");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "14",
                column: "Descripcion",
                value: "METROS CÚBICOS");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "15",
                column: "Descripcion",
                value: "METROS");

            migrationBuilder.UpdateData(
                table: "unidad_medida",
                keyColumn: "Id",
                keyValue: "99",
                column: "Descripcion",
                value: "OTROS (ESPECIFICAR)");
        }
    }
}
