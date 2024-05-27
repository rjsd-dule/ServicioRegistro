using MediatR;
using ProyectUTP.Aplication.Models.Identity;
using ProyectUTP.Application.Contracts.Identity;

namespace ProyectUTP.Application.Features.Queries.Ubicacion
{
    public class GetUbicacionHandler : IRequestHandler<GetUbicacionQuery, AllResponseMessage<GetUbicacionResult>>
    {
        private readonly IUbicacion _ubicacion;

        public GetUbicacionHandler(IUbicacion ubicacion)
        {
            _ubicacion = ubicacion;
        }

        public async Task<AllResponseMessage<GetUbicacionResult>> Handle(GetUbicacionQuery request, CancellationToken cancellationToken)
        {
            var getUbicacion = await _ubicacion.GetUbicacionAsync(request);
            return getUbicacion;
        }
    }
}
