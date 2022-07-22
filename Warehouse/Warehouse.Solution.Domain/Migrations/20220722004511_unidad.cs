using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Solution.Domain.Migrations
{
    public partial class unidad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductoProductoUnidadMedida");

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "empresa_unidad_medida",
                type: "varchar(10)",
                maxLength: 10,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "EnUso",
                table: "empresa_unidad_medida",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "empresa_unidad_medida",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "empresa_unidad_medida",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductoUnidadMedida",
                columns: table => new
                {
                    ProductosId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UnidadesMedidaId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoUnidadMedida", x => new { x.ProductosId, x.UnidadesMedidaId });
                    table.ForeignKey(
                        name: "FK_ProductoUnidadMedida_Producto_ProductosId",
                        column: x => x.ProductosId,
                        principalTable: "Producto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductoUnidadMedida_producto_unidad_medida_UnidadesMedidaId",
                        column: x => x.UnidadesMedidaId,
                        principalTable: "producto_unidad_medida",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("3785474b-f656-4d49-99c6-c144708d6a62"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 21, 19, 45, 10, 645, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 21, 19, 45, 10, 645, DateTimeKind.Local).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("4649554b-ab5e-4647-866e-1cc4e4b50ffa"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 21, 19, 45, 10, 645, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("9414a1d9-c237-4e95-9d76-3290ecb1c551"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 21, 19, 45, 10, 645, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520904"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 21, 19, 45, 10, 645, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "producto_unidad_medida",
                keyColumn: "Id",
                keyValue: new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520901"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 21, 19, 45, 10, 641, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "producto_unidad_medida",
                keyColumn: "Id",
                keyValue: new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520902"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 21, 19, 45, 10, 645, DateTimeKind.Local).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "proveedor",
                keyColumn: "Id",
                keyValue: new Guid("4e7da830-71a2-4758-9b21-ec7d0dda7984"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 21, 19, 45, 10, 645, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.CreateIndex(
                name: "IX_ProductoUnidadMedida_UnidadesMedidaId",
                table: "ProductoUnidadMedida",
                column: "UnidadesMedidaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductoUnidadMedida");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "empresa_unidad_medida");

            migrationBuilder.DropColumn(
                name: "EnUso",
                table: "empresa_unidad_medida");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "empresa_unidad_medida");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "empresa_unidad_medida");

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

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("3785474b-f656-4d49-99c6-c144708d6a62"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 16, 20, 45, 16, 26, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 16, 20, 45, 16, 26, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("4649554b-ab5e-4647-866e-1cc4e4b50ffa"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 16, 20, 45, 16, 26, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("9414a1d9-c237-4e95-9d76-3290ecb1c551"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 16, 20, 45, 16, 26, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520904"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 16, 20, 45, 16, 26, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "producto_unidad_medida",
                keyColumn: "Id",
                keyValue: new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520901"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 16, 20, 45, 16, 23, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "producto_unidad_medida",
                keyColumn: "Id",
                keyValue: new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520902"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 16, 20, 45, 16, 26, DateTimeKind.Local).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "proveedor",
                keyColumn: "Id",
                keyValue: new Guid("4e7da830-71a2-4758-9b21-ec7d0dda7984"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 16, 20, 45, 16, 26, DateTimeKind.Local).AddTicks(9985));

            migrationBuilder.CreateIndex(
                name: "IX_ProductoProductoUnidadMedida_UnidadesMedidaId",
                table: "ProductoProductoUnidadMedida",
                column: "UnidadesMedidaId");
        }
    }
}
