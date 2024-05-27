using MediatR;

namespace ProyectUTP.Application.Features.Commands.Ubicacion.DeleteUbicacion
{
    public class DeleteUbicacionCommand:IRequest<DeleteUbicacionResult>
    {
        public int UbicacionId { get; set; }
    }
}
