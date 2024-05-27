using MediatR;

namespace ProyectUTP.Application.Features.Commands.Ubicacion.UpdateUbicacion
{
    public class UpdateUbicacionCommand:IRequest<UpdateUbicacionResult>
    {
        public int UbicacionId { get; set; }
        public string NombreUbicacion { get; set; }
        public string Direccion { get; set; }
        public string EstadoProvincia { get; set; }
        public string Descripcion { get; set; }
        public string Comentarios { get; set; }
        public decimal? Latitud { get; set; }
        public decimal? Longitud { get; set; }
        public string ModificadoPor { get; set; }
    }
}
