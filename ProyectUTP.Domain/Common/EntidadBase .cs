namespace ProyectUTP.Domain.Common
{
    public class EntidadBase
    {
        public int Id { get; set; } 

        public DateTime? FechaCreacion { get; set; } 
        public string? CreadoPor { get; set; } 

        public DateTime? FechaUltimaModificacion { get; set; }
        public string? ModificadoPor { get; set; } 
    }
}
