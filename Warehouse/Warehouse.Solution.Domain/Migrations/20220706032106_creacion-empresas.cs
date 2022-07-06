using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Solution.Domain.Migrations
{
    public partial class creacionempresas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NombreTipoProveedor",
                table: "proveedor",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "empresa",
                columns: new[] { "Id", "FechaCreacion", "FechaModificacion", "IdUsuarioCrea", "IdUsuarioModifica", "Nombre", "Vigente" },
                values: new object[] { new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"), new DateTime(2022, 7, 5, 22, 21, 6, 485, DateTimeKind.Local).AddTicks(6572), null, null, null, "FARMACIA RAMOS S.A.", true });

            migrationBuilder.InsertData(
                table: "empresa",
                columns: new[] { "Id", "FechaCreacion", "FechaModificacion", "IdUsuarioCrea", "IdUsuarioModifica", "Nombre", "Vigente" },
                values: new object[] { new Guid("3785474b-f656-4d49-99c6-c144708d6a62"), new DateTime(2022, 7, 5, 22, 21, 6, 488, DateTimeKind.Local).AddTicks(4380), null, null, null, "MINIMARKETS RAMOS S.A.", true });

            migrationBuilder.InsertData(
                table: "empresa_sucursal",
                columns: new[] { "Id", "Descripcion", "Direccion", "FechaCreacion", "FechaModificacion", "IdEmpresa", "IdUsuarioCrea", "IdUsuarioModifica", "Vigente" },
                values: new object[] { new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520904"), "Farmacia Principal de Los Olivos", "Av. Los angeles 232", new DateTime(2022, 7, 5, 22, 21, 6, 488, DateTimeKind.Local).AddTicks(4949), null, new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"), null, null, true });

            migrationBuilder.InsertData(
                table: "empresa_sucursal",
                columns: new[] { "Id", "Descripcion", "Direccion", "FechaCreacion", "FechaModificacion", "IdEmpresa", "IdUsuarioCrea", "IdUsuarioModifica", "Vigente" },
                values: new object[] { new Guid("4649554b-ab5e-4647-866e-1cc4e4b50ffa"), "Minimarket los Olivos 1", "Av. Caceres de Hurre 122", new DateTime(2022, 7, 5, 22, 21, 6, 488, DateTimeKind.Local).AddTicks(5808), null, new Guid("3785474b-f656-4d49-99c6-c144708d6a62"), null, null, true });

            migrationBuilder.InsertData(
                table: "empresa_sucursal",
                columns: new[] { "Id", "Descripcion", "Direccion", "FechaCreacion", "FechaModificacion", "IdEmpresa", "IdUsuarioCrea", "IdUsuarioModifica", "Vigente" },
                values: new object[] { new Guid("9414a1d9-c237-4e95-9d76-3290ecb1c551"), "Minimarket los Olivos 2", "Av. Proceres 121", new DateTime(2022, 7, 5, 22, 21, 6, 488, DateTimeKind.Local).AddTicks(5820), null, new Guid("3785474b-f656-4d49-99c6-c144708d6a62"), null, null, true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("4649554b-ab5e-4647-866e-1cc4e4b50ffa"));

            migrationBuilder.DeleteData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("9414a1d9-c237-4e95-9d76-3290ecb1c551"));

            migrationBuilder.DeleteData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520904"));

            migrationBuilder.DeleteData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("3785474b-f656-4d49-99c6-c144708d6a62"));

            migrationBuilder.DeleteData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"));

            migrationBuilder.DropColumn(
                name: "NombreTipoProveedor",
                table: "proveedor");
        }
    }
}
