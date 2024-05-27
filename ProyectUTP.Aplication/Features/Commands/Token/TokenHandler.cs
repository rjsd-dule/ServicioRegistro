using MediatR;
using ProyectUTP.Application.Contracts.Identity;

namespace ProyectUTP.Application.Features.Commands.Token
{
    public class TokenHandler : IRequestHandler<TokenCommand, TokenResult>
    {
        private readonly IToken _token;

        public TokenHandler(IToken token)
        {
            _token = token;
        }

        public async Task<TokenResult> Handle(TokenCommand request, CancellationToken cancellationToken)
        {
            var updateToken = await _token.UpdateToken(request);
            return updateToken;
        }
    }
}
