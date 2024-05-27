using ProyectUTP.Aplication.Models.Identity;
using ProyectUTP.Application.Features.Commands.TipoCultipo.CreateTipoCultivo;
using ProyectUTP.Application.Features.Commands.TipoCultipo.DeleteTipoCultivo;
using ProyectUTP.Application.Features.Commands.TipoCultipo.UpdateTipoCultivo;
using ProyectUTP.Application.Features.Queries.GetTipoCultivo;

namespace ProyectUTP.Application.Contracts.Identity
{
    public interface ITipoCultivo
    {
        Task<CreateTipoCultivoResponse> AddCultivoAsync(CreateTipoCultivoCommand command);
        Task<AllResponseMessage<GetTipoCultivoResult>> GetCultivoAsync(GetTipoCultivoQuery query);
        Task<DeleteTipoCultivoResult> DeleteCultivoAsync(DeleteTipoCultivoCommand command);
        Task<UpdateTipoCultivoResult> UpdateCultivoAsync(UpdateTipoCultivoCommand command);
    }
}
