using MediatR;
using ProyectUTP.Application.Contracts.Identity;

namespace ProyectUTP.Application.Features.Commands.TipoCultipo.CreateTipoCultivo
{
    public class CreateTipoCultivoHandler : IRequestHandler<CreateTipoCultivoCommand, CreateTipoCultivoResponse>
    {
        private readonly ITipoCultivo _tipoCultivo;

        public CreateTipoCultivoHandler(ITipoCultivo tipoCultivo)
        {
            _tipoCultivo = tipoCultivo;
        }

        public async Task<CreateTipoCultivoResponse> Handle(CreateTipoCultivoCommand request, CancellationToken cancellationToken)
        {
            var addTipoCultipo = await _tipoCultivo.AddCultivoAsync(request);
            return addTipoCultipo;
        }
    }
}
