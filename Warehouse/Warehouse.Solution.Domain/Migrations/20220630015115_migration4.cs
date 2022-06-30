using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Solution.Domain.Migrations
{
    public partial class migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaUnidadMedida_empresa_EmpresaId",
                table: "EmpresaUnidadMedida");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaUnidadMedida_unidad_medida_UnidadMedidaId",
                table: "EmpresaUnidadMedida");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmpresaUnidadMedida",
                table: "EmpresaUnidadMedida");

            migrationBuilder.RenameTable(
                name: "EmpresaUnidadMedida",
                newName: "empresa_unidad_medida");

            migrationBuilder.RenameIndex(
                name: "IX_EmpresaUnidadMedida_UnidadMedidaId",
                table: "empresa_unidad_medida",
                newName: "IX_empresa_unidad_medida_UnidadMedidaId");

            migrationBuilder.RenameIndex(
                name: "IX_EmpresaUnidadMedida_EmpresaId",
                table: "empresa_unidad_medida",
                newName: "IX_empresa_unidad_medida_EmpresaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_empresa_unidad_medida",
                table: "empresa_unidad_medida",
                columns: new[] { "IdEmpresa", "IdUnidadMedida" });

            migrationBuilder.AddForeignKey(
                name: "FK_empresa_unidad_medida_empresa_EmpresaId",
                table: "empresa_unidad_medida",
                column: "EmpresaId",
                principalTable: "empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_empresa_unidad_medida_unidad_medida_UnidadMedidaId",
                table: "empresa_unidad_medida",
                column: "UnidadMedidaId",
                principalTable: "unidad_medida",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_empresa_unidad_medida_empresa_EmpresaId",
                table: "empresa_unidad_medida");

            migrationBuilder.DropForeignKey(
                name: "FK_empresa_unidad_medida_unidad_medida_UnidadMedidaId",
                table: "empresa_unidad_medida");

            migrationBuilder.DropPrimaryKey(
                name: "PK_empresa_unidad_medida",
                table: "empresa_unidad_medida");

            migrationBuilder.RenameTable(
                name: "empresa_unidad_medida",
                newName: "EmpresaUnidadMedida");

            migrationBuilder.RenameIndex(
                name: "IX_empresa_unidad_medida_UnidadMedidaId",
                table: "EmpresaUnidadMedida",
                newName: "IX_EmpresaUnidadMedida_UnidadMedidaId");

            migrationBuilder.RenameIndex(
                name: "IX_empresa_unidad_medida_EmpresaId",
                table: "EmpresaUnidadMedida",
                newName: "IX_EmpresaUnidadMedida_EmpresaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmpresaUnidadMedida",
                table: "EmpresaUnidadMedida",
                columns: new[] { "IdEmpresa", "IdUnidadMedida" });

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaUnidadMedida_empresa_EmpresaId",
                table: "EmpresaUnidadMedida",
                column: "EmpresaId",
                principalTable: "empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaUnidadMedida_unidad_medida_UnidadMedidaId",
                table: "EmpresaUnidadMedida",
                column: "UnidadMedidaId",
                principalTable: "unidad_medida",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
