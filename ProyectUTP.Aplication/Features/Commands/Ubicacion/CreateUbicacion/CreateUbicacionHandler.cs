using MediatR;
using ProyectUTP.Application.Contracts.Identity;

namespace ProyectUTP.Application.Features.Commands.Ubicacion.CreateUbicacion
{
    public class CreateUbicacionHandler : IRequestHandler<CreateUbicacionCommand, CreateUbicacionResult>
    {
        private readonly IUbicacion _ubicacion;

        public CreateUbicacionHandler(IUbicacion ubicacion)
        {
            _ubicacion = ubicacion;
        }

        public async Task<CreateUbicacionResult> Handle(CreateUbicacionCommand request, CancellationToken cancellationToken)
        {
            var addUbicacion=await _ubicacion.AddUbicacionAsync(request);
            return addUbicacion;
        }
    }
}
