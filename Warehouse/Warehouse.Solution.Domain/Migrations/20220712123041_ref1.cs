using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Solution.Domain.Migrations
{
    public partial class ref1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NombreTipoProveedor",
                table: "proveedor");

            migrationBuilder.RenameColumn(
                name: "TipoProveedor",
                table: "proveedor",
                newName: "IdTipoProveedor");

            migrationBuilder.InsertData(
                table: "Catalogo",
                columns: new[] { "Id", "Abreviatura", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { 10, "FACS", "Factura Stoack", "Factura-Stock" },
                    { 11, "GAST", "Gastos", "Gastos" }
                });

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("3785474b-f656-4d49-99c6-c144708d6a62"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 12, 7, 30, 41, 418, DateTimeKind.Local).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 12, 7, 30, 41, 414, DateTimeKind.Local).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("4649554b-ab5e-4647-866e-1cc4e4b50ffa"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 12, 7, 30, 41, 418, DateTimeKind.Local).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("9414a1d9-c237-4e95-9d76-3290ecb1c551"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 12, 7, 30, 41, 418, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520904"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 12, 7, 30, 41, 418, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "proveedor",
                keyColumn: "Id",
                keyValue: new Guid("4e7da830-71a2-4758-9b21-ec7d0dda7984"),
                columns: new[] { "FechaCreacion", "IdTipoProveedor" },
                values: new object[] { new DateTime(2022, 7, 12, 7, 30, 41, 418, DateTimeKind.Local).AddTicks(7275), 10 });

            migrationBuilder.CreateIndex(
                name: "IX_proveedor_IdTipoProveedor",
                table: "proveedor",
                column: "IdTipoProveedor");

            migrationBuilder.AddForeignKey(
                name: "FK_proveedor_Catalogo_IdTipoProveedor",
                table: "proveedor",
                column: "IdTipoProveedor",
                principalTable: "Catalogo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_proveedor_Catalogo_IdTipoProveedor",
                table: "proveedor");

            migrationBuilder.DropIndex(
                name: "IX_proveedor_IdTipoProveedor",
                table: "proveedor");

            migrationBuilder.DeleteData(
                table: "Catalogo",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Catalogo",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.RenameColumn(
                name: "IdTipoProveedor",
                table: "proveedor",
                newName: "TipoProveedor");

            migrationBuilder.AddColumn<string>(
                name: "NombreTipoProveedor",
                table: "proveedor",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("3785474b-f656-4d49-99c6-c144708d6a62"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 12, 6, 21, 36, 296, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 12, 6, 21, 36, 292, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("4649554b-ab5e-4647-866e-1cc4e4b50ffa"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 12, 6, 21, 36, 296, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("9414a1d9-c237-4e95-9d76-3290ecb1c551"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 12, 6, 21, 36, 296, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520904"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 12, 6, 21, 36, 296, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "proveedor",
                keyColumn: "Id",
                keyValue: new Guid("4e7da830-71a2-4758-9b21-ec7d0dda7984"),
                columns: new[] { "FechaCreacion", "NombreTipoProveedor", "TipoProveedor" },
                values: new object[] { new DateTime(2022, 7, 12, 6, 21, 36, 296, DateTimeKind.Local).AddTicks(3985), "FACTURACION-STOCK", 1 });
        }
    }
}
