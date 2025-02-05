using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectUTP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddNewColumnFromTipoCultipo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ubicacionid",
                schema: "Soil",
                table: "TipoCultivo",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 5, 3, 59, 17, 492, DateTimeKind.Utc).AddTicks(2665));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 5, 3, 59, 17, 492, DateTimeKind.Utc).AddTicks(2671));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 5, 3, 59, 17, 492, DateTimeKind.Utc).AddTicks(2673));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 5, 3, 59, 17, 492, DateTimeKind.Utc).AddTicks(2674));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 5, 3, 59, 17, 492, DateTimeKind.Utc).AddTicks(2675));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 5, 3, 59, 17, 492, DateTimeKind.Utc).AddTicks(2677));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 5, 3, 59, 17, 492, DateTimeKind.Utc).AddTicks(2679));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 5, 3, 59, 17, 492, DateTimeKind.Utc).AddTicks(2680));

            migrationBuilder.UpdateData(
                schema: "Soil",
                table: "Status",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 5, 3, 59, 17, 492, DateTimeKind.Utc).AddTicks(2681));

            migrationBuilder.CreateIndex(
                name: "IX_TipoCultivo_Ubicacionid",
                schema: "Soil",
                table: "TipoCultivo",
                column: "Ubicacionid");

            migrationBuilder.AddForeignKey(
                name: "FK_TipoCultivo_Ubicacion_Ubicacionid",
                schema: "Soil",
                table: "TipoCultivo",
                column: "Ubicacionid",
                principalSchema: "Soil",
                principalTable: "Ubicacion",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TipoCultivo_Ubicacion_Ubicacionid",
                schema: "Soil",
                table: "TipoCultivo");

            migrationBuilder.DropIndex(
                name: "IX_TipoCultivo_Ubicacionid",
                schema: "Soil",
                table: "TipoCultivo");

            migrationBuilder.DropColumn(
                name: "Ubicacionid",
                schema: "Soil",
                table: "TipoCultivo");

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
    }
}
