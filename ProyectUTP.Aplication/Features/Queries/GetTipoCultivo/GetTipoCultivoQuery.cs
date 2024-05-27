using MediatR;
using ProyectUTP.Aplication.Models.Identity;

namespace ProyectUTP.Application.Features.Queries.GetTipoCultivo
{
    public class GetTipoCultivoQuery:IRequest<AllResponseMessage<GetTipoCultivoResult>>
    {
        public int? Id { get; set; }
    }
}
