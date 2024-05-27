using MediatR;
using ProyectUTP.Application.Contracts.Identity;

namespace ProyectUTP.Application.Features.Commands.Ubicacion.UpdateUbicacion
{
    public class UpdateUbicacionHandler : IRequestHandler<UpdateUbicacionCommand, UpdateUbicacionResult>
    {
        private readonly IUbicacion _ubicacion;

        public UpdateUbicacionHandler(IUbicacion ubicacion)
        {
            _ubicacion = ubicacion;
        }

        public async Task<UpdateUbicacionResult> Handle(UpdateUbicacionCommand request, CancellationToken cancellationToken)
        {
            var updatUbicacion = await _ubicacion.UpdateUbicacionAsync(request);
            return updatUbicacion;
        }
    }
}
