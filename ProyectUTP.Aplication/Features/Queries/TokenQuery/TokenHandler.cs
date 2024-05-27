using MediatR;
using ProyectUTP.Aplication.Models.Identity;
using ProyectUTP.Application.Contracts.Identity;

namespace ProyectUTP.Application.Features.Queries.TokenQuery
{
    public class TokenHandler : IRequestHandler<TokenQuery, AllResponseMessage<GetTokenResult>>
    {
        private readonly IToken _token;

        public TokenHandler(IToken token)
        {
            _token = token;
        }

        public async Task<AllResponseMessage<GetTokenResult>> Handle(TokenQuery request, CancellationToken cancellationToken)
        {
            var getToken = await _token.GetToken(request);
            return getToken;
        }
    }
}
