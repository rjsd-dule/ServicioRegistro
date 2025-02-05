using MediatR;

namespace ProyectUTP.Application.Features.Commands.TipoCultipo.CreateTipoCultivo
{
    public class CreateTipoCultivoCommand : IRequest<CreateTipoCultivoResponse>
    {
        public string? NombreCultivo { get; set; }
        public string? Descripcion { get; set; }
        public int? CicloDeCultivo { get; set; }
        public string? Temporada { get; set; }
        public string? RequerimientosClimaticos { get; set; }
        public DateTime? FechaSiembra { get; set; }
        public DateTime? FechaCosecha { get; set; }
        public string? TipoDeSuelo { get; set; }
        public int? Ubicacionid { get; set; }
        public string? PHRecomendado { get; set; }
        public string CreadoPor { get; set; }
    }
}
