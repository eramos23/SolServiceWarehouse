using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Solution.Domain.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "entidad_financiera",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(2)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entidad_financiera", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipo_comprobante_pago",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(2)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_comprobante_pago", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "unidad_medida",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(2)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_unidad_medida", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EmpresaUnidadMedida",
                columns: table => new
                {
                    IdEmpresa = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdUnidadMedida = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    EmpresaId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    UnidadMedidaId = table.Column<string>(type: "char(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaUnidadMedida", x => new { x.IdEmpresa, x.IdUnidadMedida });
                    table.ForeignKey(
                        name: "FK_EmpresaUnidadMedida_empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmpresaUnidadMedida_unidad_medida_UnidadMedidaId",
                        column: x => x.UnidadMedidaId,
                        principalTable: "unidad_medida",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "entidad_financiera",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "01", "CENTRAL RESERVA DEL PERU" },
                    { "99", "OTROS" },
                    { "53", "HSBC BANK PERU S.A." },
                    { "50", "BNP PARIBAS" },
                    { "48", "DEL PAIS" },
                    { "47", "ORION" },
                    { "46", "BANK OF BOSTON" },
                    { "45", "SERBANCO SA." },
                    { "44", "SOLVENTA" },
                    { "43", "DEL TRABAJO" },
                    { "42", "DEL LIBERTADOR" },
                    { "41", "SUDAMERICANO" },
                    { "40", "NUEVO MUNDO" },
                    { "39", "BANEX" },
                    { "38", "INTERAMERICANO FINANZAS" },
                    { "37", "DEL PROGRESO" },
                    { "49", "MI BANCO" },
                    { "29", "BANCOSUR" },
                    { "02", "DE CREDITO DEL PERU" },
                    { "03", "INTERNACIONAL DEL PERU" },
                    { "05", "LATINO" },
                    { "07", "CITIBANK DEL PERU S.A." },
                    { "09", "SCOTIABANK PERU" },
                    { "11", "CONTINENTAL" },
                    { "08", "STANDARD CHARTERED" },
                    { "16", "MERCANTIL" },
                    { "18", "NACION" },
                    { "22", "SANTANDER CENTRAL HISPANO" },
                    { "23", "DE COMERCIO" },
                    { "25", "REPUBLICA" },
                    { "26", "NBK BANK" },
                    { "12", "DE LIMA" },
                    { "35", "FINANCIERO DEL PERU" }
                });

            migrationBuilder.InsertData(
                table: "tipo_comprobante_pago",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "08", "Nota de débito" },
                    { "31", "Guía de Remisión - Transportista" },
                    { "12", "Ticket o cinta emitido por máquina registradora" },
                    { "10", "Recibo por Arrendamiento" },
                    { "09", "Guía de remisión - Remitente" },
                    { "07", "Nota de crédito" },
                    { "03", "Boleta de Venta" },
                    { "02", "Recibo por Honorarios" },
                    { "01", "Factura" },
                    { "00", "Otros" },
                    { "04", "Liquidación de compra" }
                });

            migrationBuilder.InsertData(
                table: "unidad_medida",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { "14", "METROS CÚBICOS" },
                    { "13", "MILLARES" },
                    { "12", "CAJAS" },
                    { "11", "LATAS" },
                    { "10", "BARRILES" },
                    { "09", "GALONES" },
                    { "08", "LITROS" },
                    { "06", "GRAMOS" },
                    { "05", "TONELADAS CORTAS" },
                    { "04", "TONELADAS MÉTRICAS" },
                    { "03", "TONELADAS LARGAS" },
                    { "02", "LIBRAS" },
                    { "01", "KILOGRAMOS" },
                    { "15", "METROS" },
                    { "07", "UNIDADES" },
                    { "99", "OTROS (ESPECIFICAR)" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaUnidadMedida_EmpresaId",
                table: "EmpresaUnidadMedida",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaUnidadMedida_UnidadMedidaId",
                table: "EmpresaUnidadMedida",
                column: "UnidadMedidaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpresaUnidadMedida");

            migrationBuilder.DropTable(
                name: "entidad_financiera");

            migrationBuilder.DropTable(
                name: "tipo_comprobante_pago");

            migrationBuilder.DropTable(
                name: "unidad_medida");
        }
    }
}
