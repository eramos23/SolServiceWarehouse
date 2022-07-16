using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Solution.Domain.Migrations
{
    public partial class categotias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_producto_categoria_CategoriaId",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_CategoriaId",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Producto");

            migrationBuilder.AddColumn<int>(
                name: "IdEstado",
                table: "producto_categoria",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEstado",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("3785474b-f656-4d49-99c6-c144708d6a62"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 16, 16, 42, 46, 186, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 16, 16, 42, 46, 183, DateTimeKind.Local).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("4649554b-ab5e-4647-866e-1cc4e4b50ffa"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 16, 16, 42, 46, 186, DateTimeKind.Local).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("9414a1d9-c237-4e95-9d76-3290ecb1c551"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 16, 16, 42, 46, 186, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520904"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 16, 16, 42, 46, 186, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "proveedor",
                keyColumn: "Id",
                keyValue: new Guid("4e7da830-71a2-4758-9b21-ec7d0dda7984"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 16, 16, 42, 46, 186, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.CreateIndex(
                name: "IX_producto_categoria_IdEstado",
                table: "producto_categoria",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_IdEstado",
                table: "Producto",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoProductoCategoria_ProductosId",
                table: "ProductoProductoCategoria",
                column: "ProductosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Catalogo_IdEstado",
                table: "Producto",
                column: "IdEstado",
                principalTable: "Catalogo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_producto_categoria_Catalogo_IdEstado",
                table: "producto_categoria",
                column: "IdEstado",
                principalTable: "Catalogo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Catalogo_IdEstado",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_producto_categoria_Catalogo_IdEstado",
                table: "producto_categoria");

            migrationBuilder.DropTable(
                name: "ProductoProductoCategoria");

            migrationBuilder.DropIndex(
                name: "IX_producto_categoria_IdEstado",
                table: "producto_categoria");

            migrationBuilder.DropIndex(
                name: "IX_Producto_IdEstado",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "IdEstado",
                table: "producto_categoria");

            migrationBuilder.DropColumn(
                name: "IdEstado",
                table: "Producto");

            migrationBuilder.AddColumn<Guid>(
                name: "CategoriaId",
                table: "Producto",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("3785474b-f656-4d49-99c6-c144708d6a62"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 15, 10, 44, 34, 259, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 15, 10, 44, 34, 254, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("4649554b-ab5e-4647-866e-1cc4e4b50ffa"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 15, 10, 44, 34, 260, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("9414a1d9-c237-4e95-9d76-3290ecb1c551"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 15, 10, 44, 34, 260, DateTimeKind.Local).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520904"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 15, 10, 44, 34, 260, DateTimeKind.Local).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "proveedor",
                keyColumn: "Id",
                keyValue: new Guid("4e7da830-71a2-4758-9b21-ec7d0dda7984"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 15, 10, 44, 34, 260, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.CreateIndex(
                name: "IX_Producto_CategoriaId",
                table: "Producto",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_producto_categoria_CategoriaId",
                table: "Producto",
                column: "CategoriaId",
                principalTable: "producto_categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
