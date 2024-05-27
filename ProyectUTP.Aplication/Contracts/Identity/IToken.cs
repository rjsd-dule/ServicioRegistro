using ProyectUTP.Aplication.Models.Identity;
using ProyectUTP.Application.Features.Commands.Token;
using ProyectUTP.Application.Features.Queries.TokenQuery;

namespace ProyectUTP.Application.Contracts.Identity
{
    public interface IToken
    {
        Task<AllResponseMessage<GetTokenResult>> GetToken(TokenQuery command);
        Task<TokenResult> UpdateToken(TokenCommand command);
    }
}
