using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Solution.Domain.Migrations
{
    public partial class unidad1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "empresa_unidad_medida",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("3785474b-f656-4d49-99c6-c144708d6a62"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 21, 22, 23, 48, 336, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 21, 22, 23, 48, 336, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("4649554b-ab5e-4647-866e-1cc4e4b50ffa"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 21, 22, 23, 48, 337, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("9414a1d9-c237-4e95-9d76-3290ecb1c551"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 21, 22, 23, 48, 337, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520904"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 21, 22, 23, 48, 337, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "producto_unidad_medida",
                keyColumn: "Id",
                keyValue: new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520901"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 21, 22, 23, 48, 331, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "producto_unidad_medida",
                keyColumn: "Id",
                keyValue: new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520902"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 21, 22, 23, 48, 336, DateTimeKind.Local).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "proveedor",
                keyColumn: "Id",
                keyValue: new Guid("4e7da830-71a2-4758-9b21-ec7d0dda7984"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 21, 22, 23, 48, 337, DateTimeKind.Local).AddTicks(3009));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "empresa_unidad_medida");

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
        }
    }
}
