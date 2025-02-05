using ProyectUTP.Domain.Common;

namespace ProyectUTP.Domain.Identity.Entities
{
    public class TipoCultivo: EntidadBase
    {
        public string? NombreCultivo { get; set; }
        public string? Descripcion { get; set; }
        public int? CicloDeCultivo { get; set; }
        public string? Temporada { get; set; }
        public string? RequerimientosClimaticos { get; set; }
        public DateTime? FechaSiembra { get; set; }
        public DateTime? FechaCosecha { get; set; }
        public string? TipoDeSuelo { get; set; }
        public string? PHRecomendado { get; set; }
        public int? StatusId { get; set; }
        public int? Ubicacionid { get; set; }

        public Status Status { get; set; }
        public Ubicacion Ubicacion { get; set; }
    }
}
