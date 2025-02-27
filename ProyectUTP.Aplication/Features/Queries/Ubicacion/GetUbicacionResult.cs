namespace ProyectUTP.Application.Features.Queries.Ubicacion
{
    public class GetUbicacionResult
    {
        public int UbicacionId { get; set; }
        public string NombreUbicacion { get; set; }
        public string Direccion { get; set; }
        public string EstadoProvincia { get; set; }
        public string Descripcion { get; set; }
        public string Comentarios { get; set; }
        public decimal? Latitud { get; set; }
        public decimal? Longitud { get; set; }
        public string? CreadoPor { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
