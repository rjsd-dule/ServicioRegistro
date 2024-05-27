
using MediatR;
using ProyectUTP.Application.Contracts.Identity;

namespace ProyectUTP.Application.Features.Commands.TipoCultipo.DeleteTipoCultivo
{
    public class DeleteTipoCultivoHandler : IRequestHandler<DeleteTipoCultivoCommand, DeleteTipoCultivoResult>
    {
        private readonly ITipoCultivo _tipoCultivo;

        public DeleteTipoCultivoHandler(ITipoCultivo tipoCultivo)
        {
            _tipoCultivo = tipoCultivo;
        }

        public async Task<DeleteTipoCultivoResult> Handle(DeleteTipoCultivoCommand request, CancellationToken cancellationToken)
        {
            var deleteTipoCultipo = await _tipoCultivo.DeleteCultivoAsync(request);
            return deleteTipoCultipo;
        }
    }
}
