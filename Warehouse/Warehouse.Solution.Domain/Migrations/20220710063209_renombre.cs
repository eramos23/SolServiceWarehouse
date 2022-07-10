using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Solution.Domain.Migrations
{
    public partial class renombre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_ProductoCategoria_CategoriaId",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoProductoMarca_ProductoMarca_MarcasId",
                table: "ProductoProductoMarca");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoProductoUso_ProductoUso_UsosId",
                table: "ProductoProductoUso");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoOperacion",
                table: "TipoOperacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoNotaCredito",
                table: "TipoNotaCredito");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductoUso",
                table: "ProductoUso");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductoMarca",
                table: "ProductoMarca");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductoCategoria",
                table: "ProductoCategoria");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MotivoNotaCredito",
                table: "MotivoNotaCredito");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImpuestoMoneda",
                table: "ImpuestoMoneda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FormaPago",
                table: "FormaPago");

            migrationBuilder.RenameTable(
                name: "TipoOperacion",
                newName: "tipo_operacion");

            migrationBuilder.RenameTable(
                name: "TipoNotaCredito",
                newName: "tipo_nota_credito");

            migrationBuilder.RenameTable(
                name: "ProductoUso",
                newName: "producto_uso");

            migrationBuilder.RenameTable(
                name: "ProductoMarca",
                newName: "producto_marca");

            migrationBuilder.RenameTable(
                name: "ProductoCategoria",
                newName: "producto_categoria");

            migrationBuilder.RenameTable(
                name: "MotivoNotaCredito",
                newName: "motivo_nota_credito");

            migrationBuilder.RenameTable(
                name: "ImpuestoMoneda",
                newName: "impuesto_moneda");

            migrationBuilder.RenameTable(
                name: "FormaPago",
                newName: "forma_pago");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tipo_operacion",
                table: "tipo_operacion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tipo_nota_credito",
                table: "tipo_nota_credito",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_producto_uso",
                table: "producto_uso",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_producto_marca",
                table: "producto_marca",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_producto_categoria",
                table: "producto_categoria",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_motivo_nota_credito",
                table: "motivo_nota_credito",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_impuesto_moneda",
                table: "impuesto_moneda",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_forma_pago",
                table: "forma_pago",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("3785474b-f656-4d49-99c6-c144708d6a62"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 10, 1, 32, 8, 583, DateTimeKind.Local).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 10, 1, 32, 8, 578, DateTimeKind.Local).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("4649554b-ab5e-4647-866e-1cc4e4b50ffa"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 10, 1, 32, 8, 584, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("9414a1d9-c237-4e95-9d76-3290ecb1c551"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 10, 1, 32, 8, 584, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520904"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 10, 1, 32, 8, 584, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "proveedor",
                keyColumn: "Id",
                keyValue: new Guid("4e7da830-71a2-4758-9b21-ec7d0dda7984"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 10, 1, 32, 8, 584, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_producto_categoria_CategoriaId",
                table: "Producto",
                column: "CategoriaId",
                principalTable: "producto_categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoProductoMarca_producto_marca_MarcasId",
                table: "ProductoProductoMarca",
                column: "MarcasId",
                principalTable: "producto_marca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoProductoUso_producto_uso_UsosId",
                table: "ProductoProductoUso",
                column: "UsosId",
                principalTable: "producto_uso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_producto_categoria_CategoriaId",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoProductoMarca_producto_marca_MarcasId",
                table: "ProductoProductoMarca");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoProductoUso_producto_uso_UsosId",
                table: "ProductoProductoUso");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tipo_operacion",
                table: "tipo_operacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tipo_nota_credito",
                table: "tipo_nota_credito");

            migrationBuilder.DropPrimaryKey(
                name: "PK_producto_uso",
                table: "producto_uso");

            migrationBuilder.DropPrimaryKey(
                name: "PK_producto_marca",
                table: "producto_marca");

            migrationBuilder.DropPrimaryKey(
                name: "PK_producto_categoria",
                table: "producto_categoria");

            migrationBuilder.DropPrimaryKey(
                name: "PK_motivo_nota_credito",
                table: "motivo_nota_credito");

            migrationBuilder.DropPrimaryKey(
                name: "PK_impuesto_moneda",
                table: "impuesto_moneda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_forma_pago",
                table: "forma_pago");

            migrationBuilder.RenameTable(
                name: "tipo_operacion",
                newName: "TipoOperacion");

            migrationBuilder.RenameTable(
                name: "tipo_nota_credito",
                newName: "TipoNotaCredito");

            migrationBuilder.RenameTable(
                name: "producto_uso",
                newName: "ProductoUso");

            migrationBuilder.RenameTable(
                name: "producto_marca",
                newName: "ProductoMarca");

            migrationBuilder.RenameTable(
                name: "producto_categoria",
                newName: "ProductoCategoria");

            migrationBuilder.RenameTable(
                name: "motivo_nota_credito",
                newName: "MotivoNotaCredito");

            migrationBuilder.RenameTable(
                name: "impuesto_moneda",
                newName: "ImpuestoMoneda");

            migrationBuilder.RenameTable(
                name: "forma_pago",
                newName: "FormaPago");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoOperacion",
                table: "TipoOperacion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoNotaCredito",
                table: "TipoNotaCredito",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductoUso",
                table: "ProductoUso",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductoMarca",
                table: "ProductoMarca",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductoCategoria",
                table: "ProductoCategoria",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MotivoNotaCredito",
                table: "MotivoNotaCredito",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImpuestoMoneda",
                table: "ImpuestoMoneda",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FormaPago",
                table: "FormaPago",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("3785474b-f656-4d49-99c6-c144708d6a62"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 10, 1, 26, 44, 410, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "empresa",
                keyColumn: "Id",
                keyValue: new Guid("9d79cde1-babd-44dc-ac5a-9379afa68a75"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 10, 1, 26, 44, 405, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("4649554b-ab5e-4647-866e-1cc4e4b50ffa"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 10, 1, 26, 44, 411, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("9414a1d9-c237-4e95-9d76-3290ecb1c551"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 10, 1, 26, 44, 411, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "empresa_sucursal",
                keyColumn: "Id",
                keyValue: new Guid("e84ee21d-48bc-4ef7-978a-a0ae02520904"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 10, 1, 26, 44, 410, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "proveedor",
                keyColumn: "Id",
                keyValue: new Guid("4e7da830-71a2-4758-9b21-ec7d0dda7984"),
                column: "FechaCreacion",
                value: new DateTime(2022, 7, 10, 1, 26, 44, 411, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_ProductoCategoria_CategoriaId",
                table: "Producto",
                column: "CategoriaId",
                principalTable: "ProductoCategoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoProductoMarca_ProductoMarca_MarcasId",
                table: "ProductoProductoMarca",
                column: "MarcasId",
                principalTable: "ProductoMarca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoProductoUso_ProductoUso_UsosId",
                table: "ProductoProductoUso",
                column: "UsosId",
                principalTable: "ProductoUso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
