using ProyectUTP.Domain.Common;
using ProyectUTP.Domain.Identity.Entities;

namespace ProyectUTP.Domain.Identity.ExternalEntities
{
    public class User: EntidadBase
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? CorreoElectronico { get; set; }
        public string? NumeroTelefono { get; set; }
        public string? CorreoConfirmado { get; set; }
        public bool? FinBloqueo { get; set; }
        public bool? BloqueoHabilitado { get; set; }
        public bool? EstaRegistrado { get; set; }
        public int? EstadoId { get; set; }
        public DateTime? FechaExpiracionToken { get; set; }
        public virtual Status Status { get; set; }

        //public virtual ICollection<ApplicationUserRole>? UserRoles { get; set; }

    }
}
