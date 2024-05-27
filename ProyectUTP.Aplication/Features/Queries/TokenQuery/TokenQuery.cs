using MediatR;
using ProyectUTP.Aplication.Models.Identity;

namespace ProyectUTP.Application.Features.Queries.TokenQuery
{
    public class TokenQuery : IRequest<AllResponseMessage<GetTokenResult>>
    {
        public int? UbicacionId { get; set; }
    }
}
