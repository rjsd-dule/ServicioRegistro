using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ProyectUTP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Soil");

            migrationBuilder.CreateTable(
                name: "TipoCultivo",
                schema: "Soil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreCultivo = table.Column<string>(type: "text", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaUltimaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCultivo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ubicacion",
                schema: "Soil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Latitud = table.Column<decimal>(type: "numeric(9,6)", nullable: true),
                    Longitud = table.Column<decimal>(type: "numeric(9,6)", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaUltimaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicacion", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TipoCultivo",
                schema: "Soil");

            migrationBuilder.DropTable(
                name: "Ubicacion",
                schema: "Soil");
        }
    }
}
