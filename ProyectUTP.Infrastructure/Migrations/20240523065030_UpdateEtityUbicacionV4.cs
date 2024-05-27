using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectUTP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEtityUbicacionV4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comentarios",
                schema: "Soil",
                table: "Ubicacion",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                schema: "Soil",
                table: "Ubicacion",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                schema: "Soil",
                table: "Ubicacion",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EstadoProvincia",
                schema: "Soil",
                table: "Ubicacion",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NombreUbicacion",
                schema: "Soil",
                table: "Ubicacion",
                type: "text",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comentarios",
                schema: "Soil",
                table: "Ubicacion");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                schema: "Soil",
                table: "Ubicacion");

            migrationBuilder.DropColumn(
                name: "Direccion",
                schema: "Soil",
                table: "Ubicacion");

            migrationBuilder.DropColumn(
                name: "EstadoProvincia",
                schema: "Soil",
                table: "Ubicacion");

            migrationBuilder.DropColumn(
                name: "NombreUbicacion",
                schema: "Soil",
                table: "Ubicacion");

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 23, 6, 29, 20, 58, DateTimeKind.Utc).AddTicks(1423));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 23, 6, 29, 20, 58, DateTimeKind.Utc).AddTicks(1433));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 23, 6, 29, 20, 58, DateTimeKind.Utc).AddTicks(1434));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 23, 6, 29, 20, 58, DateTimeKind.Utc).AddTicks(1436));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 23, 6, 29, 20, 58, DateTimeKind.Utc).AddTicks(1437));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 23, 6, 29, 20, 58, DateTimeKind.Utc).AddTicks(1438));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 23, 6, 29, 20, 58, DateTimeKind.Utc).AddTicks(1439));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 23, 6, 29, 20, 58, DateTimeKind.Utc).AddTicks(1440));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2024, 5, 23, 6, 29, 20, 58, DateTimeKind.Utc).AddTicks(1442));
        }
    }
}
