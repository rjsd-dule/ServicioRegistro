using MediatR;

namespace ProyectUTP.Application.Features.Commands.TipoCultipo.DeleteTipoCultivo
{
    public class DeleteTipoCultivoCommand : IRequest<DeleteTipoCultivoResult>
    {
        public int TipoCultipoId { get; set; }
    }
}
