using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Solution.Domain.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "empresa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Nombre = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdUsuarioCrea = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IdUsuarioModifica = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empresa", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipo_documento_identidad",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(1)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_documento_identidad", x => x.Id);
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
                    Descripcion = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdUsuarioCrea = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IdUsuarioModifica = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
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
                name: "proveedor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresa = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdEmpresaSucursal = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdTipoDocumento = table.Column<string>(type: "char(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Docuemto = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Correo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoProveedor = table.Column<int>(type: "int", nullable: false),
                    IdUsuarioCrea = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IdUsuarioModifica = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proveedor", x => x.Id);
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

            migrationBuilder.CreateIndex(
                name: "IX_empresa_sucursal_IdEmpresa",
                table: "empresa_sucursal",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_proveedor_IdEmpresa",
                table: "proveedor",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_proveedor_IdEmpresaSucursal",
                table: "proveedor",
                column: "IdEmpresaSucursal");

            migrationBuilder.CreateIndex(
                name: "IX_proveedor_IdTipoDocumento",
                table: "proveedor",
                column: "IdTipoDocumento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "proveedor");

            migrationBuilder.DropTable(
                name: "empresa_sucursal");

            migrationBuilder.DropTable(
                name: "tipo_documento_identidad");

            migrationBuilder.DropTable(
                name: "empresa");
        }
    }
}
