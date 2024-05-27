using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectUTP.Domain.Identity.Entities;

namespace ProyectUTP.Infrastructure.Configurations
{
    public class StatusConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.HasData(
                new Status
                {
                    Id = 1,
                    Name = "Activo",
                    FechaCreacion = DateTime.UtcNow,
                    CreadoPor = "Sistema"
                },
                new Status
                {
                    Id = 2,
                    Name = "Inactivo",
                    FechaCreacion = DateTime.UtcNow,
                    CreadoPor = "Sistema"
                },
                new Status
                {
                    Id = 3,
                    Name = "En Proceso de analisis",
                    FechaCreacion = DateTime.UtcNow,
                    CreadoPor = "Sistema"
                },
                new Status
                {
                    Id = 4,
                    Name = "Aceptado",
                    FechaCreacion = DateTime.UtcNow,
                    CreadoPor = "Sistema"
                },
                new Status
                {
                    Id = 5,
                    Name = "Rechazado",
                    FechaCreacion = DateTime.UtcNow,
                    CreadoPor = "Sistema"
                },
                new Status
                {
                    Id = 6,
                    Name = "Revisado",
                    FechaCreacion = DateTime.UtcNow,
                    CreadoPor = "Sistema"
                },
                new Status
                {
                    Id = 7,
                    Name = "En revisión",
                    FechaCreacion = DateTime.UtcNow,
                    CreadoPor = "Sistema"
                },
                new Status
                {
                    Id = 8,
                    Name = "Analisis Finalizado",
                    FechaCreacion = DateTime.UtcNow,
                    CreadoPor = "Sistema"
                },
                new Status
                {
                    Id = 9,
                    Name = "Suspendido",
                    FechaCreacion = DateTime.UtcNow,
                    CreadoPor = "Sistema"
                }
            );
        }
    }
}
