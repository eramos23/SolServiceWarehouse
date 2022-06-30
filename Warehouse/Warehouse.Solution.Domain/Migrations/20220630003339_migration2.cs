using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Solution.Domain.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Eliminado",
                table: "proveedor",
                newName: "Vigente");

            migrationBuilder.RenameColumn(
                name: "Eliminado",
                table: "empresa_sucursal",
                newName: "Vigente");

            migrationBuilder.RenameColumn(
                name: "Eliminado",
                table: "empresa",
                newName: "Vigente");

            migrationBuilder.InsertData(
                table: "tipo_documento_identidad",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "0", "OTROS TIPOS DE DOCUMENTOS" },
                    { "1", "DOCUMENTO NACIONAL DE IDENTIDAD (DNI)" },
                    { "4", "CARNET DE EXTRANJERIA" },
                    { "6", "REGISTRO ÚNICO DE CONTRIBUYENTES" },
                    { "7", "PASAPORTE" },
                    { "A", "CÉDULA DIPLOMÁTICA DE IDENTIDAD" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tipo_documento_identidad",
                keyColumn: "Id",
                keyValue: "0");

            migrationBuilder.DeleteData(
                table: "tipo_documento_identidad",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "tipo_documento_identidad",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "tipo_documento_identidad",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "tipo_documento_identidad",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "tipo_documento_identidad",
                keyColumn: "Id",
                keyValue: "A");

            migrationBuilder.RenameColumn(
                name: "Vigente",
                table: "proveedor",
                newName: "Eliminado");

            migrationBuilder.RenameColumn(
                name: "Vigente",
                table: "empresa_sucursal",
                newName: "Eliminado");

            migrationBuilder.RenameColumn(
                name: "Vigente",
                table: "empresa",
                newName: "Eliminado");
        }
    }
}
