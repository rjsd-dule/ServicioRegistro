using MediatR;
using ProyectUTP.Aplication.Models.Identity;

namespace ProyectUTP.Application.Features.Queries.Ubicacion
{
    public class GetUbicacionQuery:IRequest<AllResponseMessage<GetUbicacionResult>>
    {
        public int? Id { get; set; }
    }
}
