using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Solution.Domain.Migrations
{
    public partial class categotias1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "producto_uso",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModificacion",
                table: "producto_uso",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdUsuarioCrea",
                table: "producto_uso",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "IdUsuarioModifica",
                table: "producto_uso",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<bool>(
                name: "Vigente",
                table: "producto_uso",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "producto_marca",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModificacion",
                table: "producto_marca",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdUsuarioCrea",
                table: "producto_marca",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "IdUsuarioModifica",
                table: "producto_marca",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<bool>(
                name: "Vigente",
                table: "producto_marca",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("3785474b-f656-4d49-99c6-c144708d6a62"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 16, 17, 13, 16, 157, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 16, 17, 13, 16, 153, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("4649554b-ab5e-4647-866e-1cc4e4b50ffa"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 16, 17, 13, 16, 157, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("9414a1d9-c237-4e95-9d76-3290ecb1c551"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 16, 17, 13, 16, 157, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520904"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 16, 17, 13, 16, 157, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "proveedor",
                keyColumn: "Id",
                keyValue: new Guid("4e7da830-71a2-4758-9b21-ec7d0dda7984"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 16, 17, 13, 16, 157, DateTimeKind.Local).AddTicks(4071));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "producto_uso");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "producto_uso");

            migrationBuilder.DropColumn(
                name: "IdUsuarioCrea",
                table: "producto_uso");

            migrationBuilder.DropColumn(
                name: "IdUsuarioModifica",
                table: "producto_uso");

            migrationBuilder.DropColumn(
                name: "Vigente",
                table: "producto_uso");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "producto_marca");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "producto_marca");

            migrationBuilder.DropColumn(
                name: "IdUsuarioCrea",
                table: "producto_marca");

            migrationBuilder.DropColumn(
                name: "IdUsuarioModifica",
                table: "producto_marca");

            migrationBuilder.DropColumn(
                name: "Vigente",
                table: "producto_marca");

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
        }
    }
}
