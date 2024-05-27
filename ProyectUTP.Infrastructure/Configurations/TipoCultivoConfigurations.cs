using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectUTP.Domain.Identity.Entities;

namespace ProyectUTP.Infrastructure.Configurations
{
    internal sealed class TipoCultivoConfigurations : IEntityTypeConfiguration<TipoCultivo>
    {
        public void Configure(EntityTypeBuilder<TipoCultivo> builder)
        {
            builder.ToTable("TipoCultivo");
            builder.HasKey(TipoCultivo => TipoCultivo.Id);
        }
    }
}
