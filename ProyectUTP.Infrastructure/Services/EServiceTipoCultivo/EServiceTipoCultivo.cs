﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProyectUTP.Aplication.Models.Identity;
using ProyectUTP.Application.Contracts.Identity;
using ProyectUTP.Application.Features.Commands.TipoCultipo.CreateTipoCultivo;
using ProyectUTP.Application.Features.Commands.TipoCultipo.DeleteTipoCultivo;
using ProyectUTP.Application.Features.Commands.TipoCultipo.UpdateTipoCultivo;
using ProyectUTP.Application.Features.Queries.GetTipoCultivo;
using ProyectUTP.Domain.Identity.Entities;
using ProyectUTP.Infrastructure.Services.FunctionQuery;

namespace ProyectUTP.Infrastructure.Services.EServiceTipoCultivo
{
    public class EServiceTipoCultivo : ITipoCultivo
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly FunctionQuery.AddQuerys _addQuerys;
        private readonly FunctionQuery.GetQuerys _getQuerys;
        private readonly FunctionQuery.UpdateRegister _updateRegister;
        private readonly FunctionResponse.FunctionResponse _Response;
        private readonly ILogger<EServiceTipoCultivo> _logger;

        public EServiceTipoCultivo(ApplicationDbContext dbContext, AddQuerys addQuerys, GetQuerys getQuerys, UpdateRegister updateRegister, FunctionResponse.FunctionResponse response, ILogger<EServiceTipoCultivo> logger)
        {
            _dbContext = dbContext;
            _addQuerys = addQuerys;
            _getQuerys = getQuerys;
            _updateRegister = updateRegister;
            _Response = response;
            _logger = logger;
        }

        public async Task<CreateTipoCultivoResponse> AddCultivoAsync(CreateTipoCultivoCommand command)
        {
            try
            {
                var addAsignacion = _addQuerys.AddtipoCultivo(command);
                _dbContext.Add(addAsignacion);
                await _dbContext.SaveChangesAsync();

                return new CreateTipoCultivoResponse { IsError = false, StatusCode = 200, Message = "Registro creado exitosamente." };

            }
            catch (Exception ex)
            {
                return _Response.ServerError<CreateTipoCultivoResponse>("Error interno del servidor > " + $"{ex}");
            }
        }

        public async Task<DeleteTipoCultivoResult> DeleteCultivoAsync(DeleteTipoCultivoCommand command)
        {
            using var transaction = await _dbContext.Database.BeginTransactionAsync();
            try
            {
                var getDataDelete = await _dbContext.TipoCultivo
                    .FirstOrDefaultAsync(t => t.Id == command.TipoCultivoId);

                if (getDataDelete == null)
                {
                    _logger.LogWarning("No se encontró el registro con Id {Id} para eliminar.", command.TipoCultivoId);
                    return new DeleteTipoCultivoResult
                    {
                        IsError = false,
                        StatusCode = 404,
                        Message = "Sin registro"
                    };
                }
                var isTipoCultivoInUse = await _dbContext.MuestraToke
                    .AnyAsync(t => t.TipoCultivoId == command.TipoCultivoId);
                /*var isTipoCultivoInUse = await _dbContext.SueloMediciones
                    .AnyAsync(t => t.TipoCultivoId == command.TipoCultivoId);*/

                if (isTipoCultivoInUse)
                {
                    _logger.LogInformation("No se puede eliminar el registro con Id {Id} ya que está en uso.", command.TipoCultivoId);
                    return new DeleteTipoCultivoResult
                    {
                        IsError = false,
                        StatusCode = 200,
                        Message = $"No se puede eliminar el registro con Id {command.TipoCultivoId} ya que está en uso."
                    };
                }

                _dbContext.TipoCultivo.Remove(getDataDelete);
                await _dbContext.SaveChangesAsync();
                await transaction.CommitAsync();

                _logger.LogInformation("Registro con Id {Id} eliminado exitosamente.", command.TipoCultivoId);

                return new DeleteTipoCultivoResult
                {
                    IsError = false,
                    StatusCode = 200,
                    Message = "Registro eliminado"
                };
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                _logger.LogError(ex, "Error al eliminar el TipoCultivo con Id {Id}", command.TipoCultivoId);

                return new DeleteTipoCultivoResult
                {
                    IsError = true,
                    StatusCode = 500,
                    Message = "Error interno del servidor. Por favor, intente nuevamente más tarde."
                };
            }
        }



        public async Task<AllResponseMessage<GetTipoCultivoResult>> GetCultivoAsync(GetTipoCultivoQuery query)
        {
            try
            {
                var reuqest = await _getQuerys.GetAllTipoCultivoAsync(query.Id);
                if (reuqest!=null)
                {
                    return new AllResponseMessage<GetTipoCultivoResult>
                    {
                        DataResult = reuqest,
                    };
                }
                
                return _Response.NotFoundResponse<AllResponseMessage<GetTipoCultivoResult>>("Sin Registro", 404, false);
            }
            catch(Exception ex)
            {
                return _Response.ServerError<AllResponseMessage<GetTipoCultivoResult>>("Error interno del servidor > " + $"{ex}");
            }
        }

        public async Task<UpdateTipoCultivoResult> UpdateCultivoAsync(UpdateTipoCultivoCommand command)
        {
            try
            {
                var toUpdateTipoCultipo = await _dbContext.TipoCultivo.FirstOrDefaultAsync(t=> t.Id==command.TipoCultipoId && t.StatusId==1);
                if (toUpdateTipoCultipo!=null)
                {
                    await _updateRegister.UpdateTipoCultivo(toUpdateTipoCultipo, command);
                    return new UpdateTipoCultivoResult { IsError = false, StatusCode = 200, Message = "Se actualizó de manera exitosa." };
                }
                return _Response.NotFoundResponse<UpdateTipoCultivoResult>("Sin Registro", 404, false);

            }
            catch(Exception ex)
            {
                return _Response.ServerError<UpdateTipoCultivoResult>("Error interno del servidor > " + $"{ex}");
            }
        }
    }
}
