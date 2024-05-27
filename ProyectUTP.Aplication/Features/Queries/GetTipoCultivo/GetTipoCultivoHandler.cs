using MediatR;
using ProyectUTP.Aplication.Models.Identity;
using ProyectUTP.Application.Contracts.Identity;

namespace ProyectUTP.Application.Features.Queries.GetTipoCultivo
{
    public class GetTipoCultivoHandler : IRequestHandler<GetTipoCultivoQuery, AllResponseMessage<GetTipoCultivoResult>>
    {
        private readonly ITipoCultivo _tipoCultivo;

        public GetTipoCultivoHandler(ITipoCultivo tipoCultivo)
        {
            _tipoCultivo = tipoCultivo;
        }

        public async Task<AllResponseMessage<GetTipoCultivoResult>> Handle(GetTipoCultivoQuery request, CancellationToken cancellationToken)
        {
            var getTipoCultipo = await _tipoCultivo.GetCultivoAsync(request);
            return getTipoCultipo;
        }
    }
}
