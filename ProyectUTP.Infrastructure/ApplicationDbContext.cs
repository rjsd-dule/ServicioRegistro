using Microsoft.EntityFrameworkCore;
using ProyectUTP.Domain.Identity.Entities;
using ProyectUTP.Domain.Identity.ExternalEntities;
using ProyectUTP.Infrastructure.Configurations;

namespace ProyectUTP.Infrastructure
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("Soil");
            builder.ApplyConfiguration(new StatusConfiguration());

            //builder.Ignore<User>();
            /*builder.Ignore<AspNetUserRoles>();
            builder.Ignore<Status>();*/
        }

        public DbSet<MuestraToke> MuestraToke { get; set; }
        public DbSet<Ubicacion> Ubicacion { get; set; }
        public DbSet<TipoCultivo> TipoCultivo { get; set;}
        public DbSet<Status> Status { get; set; }
    }
}
