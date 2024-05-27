using MediatR;
using ProyectUTP.Application.Contracts.Identity;

namespace ProyectUTP.Application.Features.Commands.Ubicacion.DeleteUbicacion
{
    public class DeleteUbicacionHandler : IRequestHandler<DeleteUbicacionCommand, DeleteUbicacionResult>
    {
        private readonly IUbicacion _ubicacion;

        public DeleteUbicacionHandler(IUbicacion ubicacion)
        {
            _ubicacion = ubicacion;
        }

        public async Task<DeleteUbicacionResult> Handle(DeleteUbicacionCommand request, CancellationToken cancellationToken)
        {
            var deleteUbicacion = await _ubicacion.DeleteUbicacionAsync(request);
            return deleteUbicacion;
        }
    }
}
