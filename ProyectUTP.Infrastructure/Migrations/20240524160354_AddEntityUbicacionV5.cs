using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ProyectUTP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddEntityUbicacionV5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MuestraToke",
                schema: "Soil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TokenValue = table.Column<string>(type: "text", nullable: true),
                    UbicacionId = table.Column<int>(type: "integer", nullable: true),
                    StatusId = table.Column<int>(type: "integer", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaUltimaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuestraToke", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MuestraToke_Ubicacion_UbicacionId",
                        column: x => x.UbicacionId,
                        principalSchema: "Soil",
                        principalTable: "Ubicacion",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 24, 16, 3, 53, 798, DateTimeKind.Utc).AddTicks(7875));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 24, 16, 3, 53, 798, DateTimeKind.Utc).AddTicks(7882));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 24, 16, 3, 53, 798, DateTimeKind.Utc).AddTicks(7884));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 24, 16, 3, 53, 798, DateTimeKind.Utc).AddTicks(7885));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 24, 16, 3, 53, 798, DateTimeKind.Utc).AddTicks(7887));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 24, 16, 3, 53, 798, DateTimeKind.Utc).AddTicks(7888));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 24, 16, 3, 53, 798, DateTimeKind.Utc).AddTicks(7889));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 24, 16, 3, 53, 798, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 24, 16, 3, 53, 798, DateTimeKind.Utc).AddTicks(7892));

            migrationBuilder.CreateIndex(
                name: "IX_MuestraToke_UbicacionId",
                schema: "Soil",
                table: "MuestraToke",
                column: "UbicacionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MuestraToke",
                schema: "Soil");

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 23, 6, 50, 30, 439, DateTimeKind.Utc).AddTicks(7984));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 23, 6, 50, 30, 439, DateTimeKind.Utc).AddTicks(7992));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 23, 6, 50, 30, 439, DateTimeKind.Utc).AddTicks(7994));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 23, 6, 50, 30, 439, DateTimeKind.Utc).AddTicks(7995));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 23, 6, 50, 30, 439, DateTimeKind.Utc).AddTicks(7997));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 23, 6, 50, 30, 439, DateTimeKind.Utc).AddTicks(7998));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 23, 6, 50, 30, 439, DateTimeKind.Utc).AddTicks(8000));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 23, 6, 50, 30, 439, DateTimeKind.Utc).AddTicks(8001));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 23, 6, 50, 30, 439, DateTimeKind.Utc).AddTicks(8007));
        }
    }
}
