using ProyectUTP.Aplication.Models.Identity;
using ProyectUTP.Application.Features.Commands.Ubicacion.CreateUbicacion;
using ProyectUTP.Application.Features.Commands.Ubicacion.DeleteUbicacion;
using ProyectUTP.Application.Features.Commands.Ubicacion.UpdateUbicacion;
using ProyectUTP.Application.Features.Queries.Ubicacion;

namespace ProyectUTP.Application.Contracts.Identity
{
    public interface IUbicacion
    {
        Task<CreateUbicacionResult> AddUbicacionAsync(CreateUbicacionCommand command);
        Task<AllResponseMessage<GetUbicacionResult>> GetUbicacionAsync(GetUbicacionQuery query);
        Task<DeleteUbicacionResult> DeleteUbicacionAsync(DeleteUbicacionCommand command);
        Task<UpdateUbicacionResult> UpdateUbicacionAsync(UpdateUbicacionCommand command);
    }
}
