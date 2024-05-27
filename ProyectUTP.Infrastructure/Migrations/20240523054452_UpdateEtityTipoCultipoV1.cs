using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectUTP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEtityTipoCultipoV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CicloDeCultivo",
                schema: "Soil",
                table: "TipoCultivo",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                schema: "Soil",
                table: "TipoCultivo",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCosecha",
                schema: "Soil",
                table: "TipoCultivo",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaSiembra",
                schema: "Soil",
                table: "TipoCultivo",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PHRecomendado",
                schema: "Soil",
                table: "TipoCultivo",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RequerimientosClimaticos",
                schema: "Soil",
                table: "TipoCultivo",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Temporada",
                schema: "Soil",
                table: "TipoCultivo",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoDeSuelo",
                schema: "Soil",
                table: "TipoCultivo",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CicloDeCultivo",
                schema: "Soil",
                table: "TipoCultivo");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                schema: "Soil",
                table: "TipoCultivo");

            migrationBuilder.DropColumn(
                name: "FechaCosecha",
                schema: "Soil",
                table: "TipoCultivo");

            migrationBuilder.DropColumn(
                name: "FechaSiembra",
                schema: "Soil",
                table: "TipoCultivo");

            migrationBuilder.DropColumn(
                name: "PHRecomendado",
                schema: "Soil",
                table: "TipoCultivo");

            migrationBuilder.DropColumn(
                name: "RequerimientosClimaticos",
                schema: "Soil",
                table: "TipoCultivo");

            migrationBuilder.DropColumn(
                name: "Temporada",
                schema: "Soil",
                table: "TipoCultivo");

            migrationBuilder.DropColumn(
                name: "TipoDeSuelo",
                schema: "Soil",
                table: "TipoCultivo");
        }
    }
}
