using MediatR;
using ProyectUTP.Application.Contracts.Identity;

namespace ProyectUTP.Application.Features.Commands.TipoCultipo.UpdateTipoCultivo
{
    public class UpdateTipoCultivoHandler : IRequestHandler<UpdateTipoCultivoCommand, UpdateTipoCultivoResult>
    {
        private readonly ITipoCultivo _tipoCultivo;

        public UpdateTipoCultivoHandler(ITipoCultivo tipoCultivo)
        {
            _tipoCultivo = tipoCultivo;
        }

        public async Task<UpdateTipoCultivoResult> Handle(UpdateTipoCultivoCommand request, CancellationToken cancellationToken)
        {
            var updateTipoCultipo = await _tipoCultivo.UpdateCultivoAsync(request);
            return updateTipoCultipo;
        }
    }
}
