using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProyectUTP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationProyectUTP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Soil");

            migrationBuilder.CreateTable(
                name: "Status",
                schema: "Soil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaUltimaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ubicacion",
                schema: "Soil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreUbicacion = table.Column<string>(type: "text", nullable: false),
                    Direccion = table.Column<string>(type: "text", nullable: false),
                    EstadoProvincia = table.Column<string>(type: "text", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    Comentarios = table.Column<string>(type: "text", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "MuestraToke",
                schema: "Soil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TokenValue = table.Column<string>(type: "text", nullable: true),
                    TipoCultivoId = table.Column<int>(type: "integer", nullable: true),
                    StatusId = table.Column<int>(type: "integer", nullable: true),
                    ExpiresAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaUltimaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuestraToke", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MuestraToke_Ubicacion_TipoCultivoId",
                        column: x => x.TipoCultivoId,
                        principalSchema: "Soil",
                        principalTable: "Ubicacion",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TipoCultivo",
                schema: "Soil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreCultivo = table.Column<string>(type: "text", nullable: true),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    CicloDeCultivo = table.Column<int>(type: "integer", nullable: true),
                    Temporada = table.Column<string>(type: "text", nullable: true),
                    RequerimientosClimaticos = table.Column<string>(type: "text", nullable: true),
                    FechaSiembra = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    FechaCosecha = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    TipoDeSuelo = table.Column<string>(type: "text", nullable: true),
                    PHRecomendado = table.Column<string>(type: "text", nullable: true),
                    StatusId = table.Column<int>(type: "integer", nullable: true),
                    Ubicacionid = table.Column<int>(type: "integer", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreadoPor = table.Column<string>(type: "text", nullable: true),
                    FechaUltimaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModificadoPor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCultivo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TipoCultivo_Status_StatusId",
                        column: x => x.StatusId,
                        principalSchema: "Soil",
                        principalTable: "Status",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TipoCultivo_Ubicacion_Ubicacionid",
                        column: x => x.Ubicacionid,
                        principalSchema: "Soil",
                        principalTable: "Ubicacion",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "Soil",
                table: "Status",
                columns: new[] { "Id", "CreadoPor", "FechaCreacion", "FechaUltimaModificacion", "ModificadoPor", "Name" },
                values: new object[,]
                {
                    { 1, "Sistema", new DateTime(2025, 2, 6, 6, 25, 40, 219, DateTimeKind.Utc).AddTicks(9746), null, null, "Activo" },
                    { 2, "Sistema", new DateTime(2025, 2, 6, 6, 25, 40, 219, DateTimeKind.Utc).AddTicks(9752), null, null, "Inactivo" },
                    { 3, "Sistema", new DateTime(2025, 2, 6, 6, 25, 40, 219, DateTimeKind.Utc).AddTicks(9753), null, null, "En Proceso de analisis" },
                    { 4, "Sistema", new DateTime(2025, 2, 6, 6, 25, 40, 219, DateTimeKind.Utc).AddTicks(9754), null, null, "Aceptado" },
                    { 5, "Sistema", new DateTime(2025, 2, 6, 6, 25, 40, 219, DateTimeKind.Utc).AddTicks(9756), null, null, "Rechazado" },
                    { 6, "Sistema", new DateTime(2025, 2, 6, 6, 25, 40, 219, DateTimeKind.Utc).AddTicks(9757), null, null, "Revisado" },
                    { 7, "Sistema", new DateTime(2025, 2, 6, 6, 25, 40, 219, DateTimeKind.Utc).AddTicks(9758), null, null, "En revisión" },
                    { 8, "Sistema", new DateTime(2025, 2, 6, 6, 25, 40, 219, DateTimeKind.Utc).AddTicks(9759), null, null, "Analisis Finalizado" },
                    { 9, "Sistema", new DateTime(2025, 2, 6, 6, 25, 40, 219, DateTimeKind.Utc).AddTicks(9760), null, null, "Suspendido" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MuestraToke_TipoCultivoId",
                schema: "Soil",
                table: "MuestraToke",
                column: "TipoCultivoId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoCultivo_StatusId",
                schema: "Soil",
                table: "TipoCultivo",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoCultivo_Ubicacionid",
                schema: "Soil",
                table: "TipoCultivo",
                column: "Ubicacionid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MuestraToke",
                schema: "Soil");

            migrationBuilder.DropTable(
                name: "TipoCultivo",
                schema: "Soil");

            migrationBuilder.DropTable(
                name: "Status",
                schema: "Soil");

            migrationBuilder.DropTable(
                name: "Ubicacion",
                schema: "Soil");
        }
    }
}
