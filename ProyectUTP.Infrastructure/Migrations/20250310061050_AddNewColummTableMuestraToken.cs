using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectUTP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddNewColummTableMuestraToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UbicacionId",
                schema: "Soil",
                table: "MuestraToke",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 10, 6, 10, 50, 504, DateTimeKind.Utc).AddTicks(5003));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 10, 6, 10, 50, 504, DateTimeKind.Utc).AddTicks(5011));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 10, 6, 10, 50, 504, DateTimeKind.Utc).AddTicks(5013));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 10, 6, 10, 50, 504, DateTimeKind.Utc).AddTicks(5015));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 10, 6, 10, 50, 504, DateTimeKind.Utc).AddTicks(5016));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 10, 6, 10, 50, 504, DateTimeKind.Utc).AddTicks(5017));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 10, 6, 10, 50, 504, DateTimeKind.Utc).AddTicks(5019));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 10, 6, 10, 50, 504, DateTimeKind.Utc).AddTicks(5020));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 10, 6, 10, 50, 504, DateTimeKind.Utc).AddTicks(5022));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UbicacionId",
                schema: "Soil",
                table: "MuestraToke");

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 6, 6, 25, 40, 219, DateTimeKind.Utc).AddTicks(9746));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 6, 6, 25, 40, 219, DateTimeKind.Utc).AddTicks(9752));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 6, 6, 25, 40, 219, DateTimeKind.Utc).AddTicks(9753));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 6, 6, 25, 40, 219, DateTimeKind.Utc).AddTicks(9754));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 6, 6, 25, 40, 219, DateTimeKind.Utc).AddTicks(9756));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 6, 6, 25, 40, 219, DateTimeKind.Utc).AddTicks(9757));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 6, 6, 25, 40, 219, DateTimeKind.Utc).AddTicks(9758));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 6, 6, 25, 40, 219, DateTimeKind.Utc).AddTicks(9759));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 6, 6, 25, 40, 219, DateTimeKind.Utc).AddTicks(9760));
        }
    }
}
