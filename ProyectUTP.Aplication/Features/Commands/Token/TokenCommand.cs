using MediatR;

namespace ProyectUTP.Application.Features.Commands.Token
{
    public class TokenCommand:IRequest<TokenResult>
    {
        public int TokenId { get; set; }
        public DateTime? NuevaFecha { get; set; }
    }
}
