using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectUTP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddEntityUbicacionV6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiresAt",
                schema: "Soil",
                table: "MuestraToke",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 24, 17, 33, 54, 580, DateTimeKind.Utc).AddTicks(9255));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 24, 17, 33, 54, 580, DateTimeKind.Utc).AddTicks(9266));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 24, 17, 33, 54, 580, DateTimeKind.Utc).AddTicks(9268));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 24, 17, 33, 54, 580, DateTimeKind.Utc).AddTicks(9269));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 24, 17, 33, 54, 580, DateTimeKind.Utc).AddTicks(9270));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 24, 17, 33, 54, 580, DateTimeKind.Utc).AddTicks(9271));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 24, 17, 33, 54, 580, DateTimeKind.Utc).AddTicks(9273));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 24, 17, 33, 54, 580, DateTimeKind.Utc).AddTicks(9274));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 24, 17, 33, 54, 580, DateTimeKind.Utc).AddTicks(9275));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpiresAt",
                schema: "Soil",
                table: "MuestraToke");

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
        }
    }
}
