using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Solution.Domain.Migrations
{
    public partial class proveedor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "proveedor",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("3785474b-f656-4d49-99c6-c144708d6a62"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 6, 11, 12, 33, 20, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 6, 11, 12, 33, 17, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("4649554b-ab5e-4647-866e-1cc4e4b50ffa"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 6, 11, 12, 33, 20, DateTimeKind.Local).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("9414a1d9-c237-4e95-9d76-3290ecb1c551"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 6, 11, 12, 33, 20, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520904"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 6, 11, 12, 33, 20, DateTimeKind.Local).AddTicks(7841));

            migrationBuilder.InsertData(
                table: "proveedor",
                columns: new[] { "Id", "Correo", "Direccion", "Docuemto", "FechaCreacion", "FechaModificacion", "IdEmpresa", "IdEmpresaSucursal", "IdTipoDocumento", "IdUsuarioCrea", "IdUsuarioModifica", "Nombre", "NombreTipoProveedor", "Telefono", "TipoProveedor", "Vigente" },
                values: new object[] { new Guid("4e7da830-71a2-4758-9b21-ec7d0dda7984"), "proveedordemedicamentos@gmail.com", "Jr. Mira flores, calle 2 pabellon 52", "20718623451", new DateTime(2022, 7, 6, 11, 12, 33, 20, DateTimeKind.Local).AddTicks(9529), null, new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"), new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520904"), "6", null, null, null, "FACTURACION-STOCK", "10-12222-22", 1, true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "proveedor",
                keyColumn: "Id",
                keyValue: new Guid("4e7da830-71a2-4758-9b21-ec7d0dda7984"));

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "proveedor");

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("3785474b-f656-4d49-99c6-c144708d6a62"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 5, 22, 21, 6, 488, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 5, 22, 21, 6, 485, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("4649554b-ab5e-4647-866e-1cc4e4b50ffa"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 5, 22, 21, 6, 488, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("9414a1d9-c237-4e95-9d76-3290ecb1c551"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 5, 22, 21, 6, 488, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520904"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 5, 22, 21, 6, 488, DateTimeKind.Local).AddTicks(4949));
        }
    }
}
