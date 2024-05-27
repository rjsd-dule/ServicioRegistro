using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ProyectUTP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEtityTipoCultipoV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                schema: "Soil",
                table: "TipoCultivo",
                type: "integer",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_TipoCultivo_StatusId",
                schema: "Soil",
                table: "TipoCultivo",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_TipoCultivo_Status_StatusId",
                schema: "Soil",
                table: "TipoCultivo",
                column: "StatusId",
                principalSchema: "Soil",
                principalTable: "Status",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TipoCultivo_Status_StatusId",
                schema: "Soil",
                table: "TipoCultivo");

            migrationBuilder.DropTable(
                name: "Status",
                schema: "Soil");

            migrationBuilder.DropIndex(
                name: "IX_TipoCultivo_StatusId",
                schema: "Soil",
                table: "TipoCultivo");

            migrationBuilder.DropColumn(
                name: "StatusId",
                schema: "Soil",
                table: "TipoCultivo");
        }
    }
}
