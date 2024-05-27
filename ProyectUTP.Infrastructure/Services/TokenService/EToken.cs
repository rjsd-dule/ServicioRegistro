using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProyectUTP.Aplication.Models.Identity;
using ProyectUTP.Application.Contracts.Identity;
using ProyectUTP.Application.Features.Commands.Token;
using ProyectUTP.Application.Features.Queries.TokenQuery;
using ProyectUTP.Application.Features.Queries.Ubicacion;
using ProyectUTP.Infrastructure.Services.FunctionQuery;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ProyectUTP.Infrastructure.Services.TokenService
{
    public class EToken : IToken
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly FunctionQuery.AddQuerys _addQuerys;
        private readonly FunctionQuery.GetQuerys _getQuerys;
        private readonly FunctionQuery.UpdateRegister _updateRegister;
        private readonly FunctionResponse.FunctionResponse _Response;
        private readonly ILogger<EToken> _logger;
        private readonly TokenService _tokenService;

        public EToken(ApplicationDbContext dbContext, AddQuerys addQuerys, GetQuerys getQuerys, UpdateRegister updateRegister, FunctionResponse.FunctionResponse response, ILogger<EToken> logger, TokenService tokenService)
        {
            _dbContext = dbContext;
            _addQuerys = addQuerys;
            _getQuerys = getQuerys;
            _updateRegister = updateRegister;
            _Response = response;
            _logger = logger;
            _tokenService = tokenService;
        }

        public async Task<AllResponseMessage<GetTokenResult>> GetToken(TokenQuery query)
        {
            try
            {
                var reuqest = await _getQuerys.GetTokenAsync(query.UbicacionId);
                if (reuqest != null)
                {
                    return new AllResponseMessage<GetTokenResult>
                    {
                        IsError = false,
                        StatusCode = 200,
                        Message = "Ok",
                        DataResult = reuqest,
                    };
                }

                return _Response.NotFoundResponse<AllResponseMessage<GetTokenResult>>("Sin Registro", 404, false);
            }
            catch (Exception ex)
            {
                return _Response.ServerError<AllResponseMessage<GetTokenResult>>("Error interno del servidor > " + $"{ex}");
            }
        }

        public async Task<TokenResult> UpdateToken(TokenCommand command)
        {
            try
            {
                var getToupdateToken =await _dbContext.MuestraToke.FirstOrDefaultAsync(t=> t.Id==command.TokenId && t.StatusId==1);
                if (getToupdateToken != null)
                {
                    var token = _tokenService.GenerateToken(command.NuevaFecha);
                    getToupdateToken.TokenValue= token;
                    getToupdateToken.ExpiresAt= command.NuevaFecha;
                    await _dbContext.SaveChangesAsync();

                    return _Response.NotFoundResponse<TokenResult>("Se actualizó de manera exitosa.", 200, false);
                }
                return _Response.NotFoundResponse<TokenResult>("No se puede realizar la actualización.", 404, false);
            }
            catch (Exception ex)
            {
                return _Response.ServerError<TokenResult>("Error interno del servidor > " + $"{ex}");
            }
        }
    }
}
