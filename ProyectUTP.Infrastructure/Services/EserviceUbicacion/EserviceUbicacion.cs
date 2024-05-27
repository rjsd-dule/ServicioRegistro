using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProyectUTP.Aplication.Models.Identity;
using ProyectUTP.Application.Contracts.Identity;
using ProyectUTP.Application.Features.Commands.Ubicacion.CreateUbicacion;
using ProyectUTP.Application.Features.Commands.Ubicacion.DeleteUbicacion;
using ProyectUTP.Application.Features.Commands.Ubicacion.UpdateUbicacion;
using ProyectUTP.Application.Features.Queries.Ubicacion;
using ProyectUTP.Infrastructure.Services.FunctionQuery;

namespace ProyectUTP.Infrastructure.Services.EserviceUbicacion
{
    public class EserviceUbicacion:IUbicacion
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly FunctionQuery.AddQuerys _addQuerys;
        private readonly FunctionQuery.GetQuerys _getQuerys;
        private readonly FunctionQuery.UpdateRegister _updateRegister;
        private readonly FunctionResponse.FunctionResponse _Response;
        private readonly ILogger<EserviceUbicacion> _logger;
        private readonly TokenService.TokenService _tokenService;

        public EserviceUbicacion(ApplicationDbContext dbContext, AddQuerys addQuerys, GetQuerys getQuerys, UpdateRegister updateRegister, FunctionResponse.FunctionResponse response, ILogger<EserviceUbicacion> logger, TokenService.TokenService tokenService)
        {
            _dbContext = dbContext;
            _addQuerys = addQuerys;
            _getQuerys = getQuerys;
            _updateRegister = updateRegister;
            _Response = response;
            _logger = logger;
            _tokenService = tokenService;
        }

        public async Task<CreateUbicacionResult> AddUbicacionAsync(CreateUbicacionCommand command)
        {
            try
            {
                var addUbicacion = _addQuerys.AddUbicacion(command);
                _dbContext.Add(addUbicacion);
                await _dbContext.SaveChangesAsync();
                var token = _tokenService.GenerateToken(DateTime.UtcNow.AddYears(1));
                /*-------------------------------------------------------------------------------------*/
                var addUbicacionToken = _addQuerys.addUbicacionToken(token, command.CreadoPor,addUbicacion.Id, DateTime.UtcNow.AddYears(1));
                _dbContext.Add(addUbicacionToken);
                await _dbContext.SaveChangesAsync();

                _logger.LogWarning($"DateTime.UtcNow.AddYears(1) {DateTime.UtcNow.AddYears(1)}.");
                _logger.LogWarning($"token {token} para eliminar.");

                return new CreateUbicacionResult { IsError = false, StatusCode = 200, Message = "Registro creado exitosamente." };
            }
            catch (Exception ex)
            {
                return _Response.ServerError<CreateUbicacionResult>("Error interno del servidor > " + $"{ex}");
            }
        }

        public async Task<DeleteUbicacionResult> DeleteUbicacionAsync(DeleteUbicacionCommand command)
        {
            try
            {
                var getDataDelete = await _dbContext.Ubicacion.FirstOrDefaultAsync(u => u.Id == command.UbicacionId);

                if (getDataDelete != null)
                {
                    _dbContext.Ubicacion.Remove(getDataDelete);
                    await _dbContext.SaveChangesAsync();

                    _logger.LogInformation("Registro con Id {Id} eliminado exitosamente.", command.UbicacionId);

                    return new DeleteUbicacionResult
                    {
                        IsError = false,
                        StatusCode = 200,
                        Message = "Registro eliminado"
                    };
                }

                _logger.LogWarning("No se encontró el registro con Id {Id} para eliminar.", command.UbicacionId);

                return new DeleteUbicacionResult
                {
                    IsError = false,
                    StatusCode = 404,
                    Message = "Sin registro"
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al eliminar el TipoCultivo con Id {Id}", command.UbicacionId);

                return _Response.ServerError<DeleteUbicacionResult>("Error interno del servidor. Por favor, intente nuevamente más tarde.");
            }
        }

        public async Task<AllResponseMessage<GetUbicacionResult>> GetUbicacionAsync(GetUbicacionQuery query)
        {
            try
            {
                var reuqest = await _getQuerys.GetAllUbicacionAsync(query.Id);
                if (reuqest != null)
                {
                    return new AllResponseMessage<GetUbicacionResult>
                    {
                        IsError = false,
                        StatusCode = 200,
                        Message = "Ok",
                        DataResult = reuqest,
                    };
                }

                return _Response.NotFoundResponse<AllResponseMessage<GetUbicacionResult>>("Sin Registro", 404, false);
            }
            catch (Exception ex)
            {
                return _Response.ServerError<AllResponseMessage<GetUbicacionResult>>("Error interno del servidor > " + $"{ex}");
            }
        }

        public async Task<UpdateUbicacionResult> UpdateUbicacionAsync(UpdateUbicacionCommand command)
        {
            try
            {
                var toUpdateUbicacion = await _dbContext.Ubicacion.FirstOrDefaultAsync(t => t.Id == command.UbicacionId);
                if (toUpdateUbicacion != null)
                {
                    await _updateRegister.UpdateUbicacion(toUpdateUbicacion, command);
                    return new UpdateUbicacionResult { IsError = false, StatusCode = 200, Message = "Se actualizó de manera exitosa." };
                }
                return _Response.NotFoundResponse<UpdateUbicacionResult>("Sin Registro", 404, false);

            }
            catch (Exception ex)
            {
                return _Response.ServerError<UpdateUbicacionResult>("Error interno del servidor > " + $"{ex}");
            }
        }
    }
}
