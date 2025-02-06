using ProyectUTP.Domain.Common;

namespace ProyectUTP.Domain.Identity.Entities
{
    public class MuestraToke: EntidadBase
    {
        public string? TokenValue { get; set; }
        public int? TipoCultivoId { get; set; }
        public int? StatusId { get; set; }
        public DateTime? ExpiresAt { get; set; }
        public Ubicacion? TipoCultivo { get; set; }
    }
}
