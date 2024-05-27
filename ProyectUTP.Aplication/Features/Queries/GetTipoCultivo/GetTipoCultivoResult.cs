namespace ProyectUTP.Application.Features.Queries.GetTipoCultivo
{
    public class GetTipoCultivoResult
    {
        public int TipoCultipoId { get; set; }
        public string? NombreCultivo { get; set; }
        public string? Descripcion { get; set; }
        public int? CicloDeCultivo { get; set; }
        public string? Temporada { get; set; }
        public string? RequerimientosClimaticos { get; set; }
        public DateTime? FechaSiembra { get; set; }
        public DateTime? FechaCosecha { get; set; }
        public string? TipoDeSuelo { get; set; }
        public string? PHRecomendado { get; set; }
        public string CreadoPor { get; set; }
        public string ModificadoPor { get; set; }
    }
}
