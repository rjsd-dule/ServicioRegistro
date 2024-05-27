using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProyectUTP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEtityTipoCultipoV3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Soil",
                table: "Status",
                columns: new[] { "Id", "CreadoPor", "FechaCreacion", "FechaUltimaModificacion", "ModificadoPor", "Name" },
                values: new object[,]
                {
                    { 1, "Sistema", new DateTime(2024, 5, 23, 6, 29, 20, 58, DateTimeKind.Utc).AddTicks(1423), null, null, "Activo" },
                    { 2, "Sistema", new DateTime(2024, 5, 23, 6, 29, 20, 58, DateTimeKind.Utc).AddTicks(1433), null, null, "Inactivo" },
                    { 3, "Sistema", new DateTime(2024, 5, 23, 6, 29, 20, 58, DateTimeKind.Utc).AddTicks(1434), null, null, "En Proceso de analisis" },
                    { 4, "Sistema", new DateTime(2024, 5, 23, 6, 29, 20, 58, DateTimeKind.Utc).AddTicks(1436), null, null, "Aceptado" },
                    { 5, "Sistema", new DateTime(2024, 5, 23, 6, 29, 20, 58, DateTimeKind.Utc).AddTicks(1437), null, null, "Rechazado" },
                    { 6, "Sistema", new DateTime(2024, 5, 23, 6, 29, 20, 58, DateTimeKind.Utc).AddTicks(1438), null, null, "Revisado" },
                    { 7, "Sistema", new DateTime(2024, 5, 23, 6, 29, 20, 58, DateTimeKind.Utc).AddTicks(1439), null, null, "En revisión" },
                    { 8, "Sistema", new DateTime(2024, 5, 23, 6, 29, 20, 58, DateTimeKind.Utc).AddTicks(1440), null, null, "Analisis Finalizado" },
                    { 9, "Sistema", new DateTime(2024, 5, 23, 6, 29, 20, 58, DateTimeKind.Utc).AddTicks(1442), null, null, "Suspendido" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
