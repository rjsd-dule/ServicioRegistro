using Microsoft.EntityFrameworkCore;
using ProyectUTP.Application.Features.Queries.GetTipoCultivo;
using ProyectUTP.Application.Features.Queries.TokenQuery;
using ProyectUTP.Application.Features.Queries.Ubicacion;
using ProyectUTP.Domain.Identity.Entities;

namespace ProyectUTP.Infrastructure.Services.FunctionQuery
{
    public class GetQuerys
    {
        private readonly ApplicationDbContext _dbContext;

        public GetQuerys(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //public async Task<List<TipoCultivo>> GetAllTipoCultivoAsync()
        //{
        //    return await _dbContext.TipoCultivo.Where(tc => tc.StatusId == 1).ToListAsync();
        //}

        public async Task<TipoCultivo?> GetTipoCultivoByIdAsync(int id)
        {
            return await _dbContext.TipoCultivo.FirstOrDefaultAsync(tc => tc.Id == id && tc.StatusId == 1);
        }

        public async Task<List<GetTipoCultivoResult>> GetAllTipoCultivoAsync(int? Id)
        {
            var query = from t in _dbContext.TipoCultivo
                        where Id == 0 || t.Id == Id
                        select new GetTipoCultivoResult 
                        {
                            TipoCultipoId=t.Id,
                            NombreCultivo=t.NombreCultivo,
                            Descripcion=t.Descripcion,
                            CicloDeCultivo=t.CicloDeCultivo,
                            Temporada=t.Temporada,
                            RequerimientosClimaticos=t.RequerimientosClimaticos,
                            FechaSiembra = t.FechaSiembra,
                            FechaCosecha = t.FechaCosecha,
                            TipoDeSuelo= t.TipoDeSuelo,
                            PHRecomendado= t.PHRecomendado,
                            CreadoPor= t.CreadoPor,
                            ModificadoPor=t.ModificadoPor
                        };
            var request=await query.ToListAsync();
            return request;
        }

        public async Task<List<GetUbicacionResult>> GetAllUbicacionAsync(int? Id)
        {
            var query = from u in _dbContext.Ubicacion
                        where Id == 0 || u.Id == Id
                        select new GetUbicacionResult
                        {
                            UserId=u.Id,
                            NombreUbicacion = u.NombreUbicacion,
                            Direccion = u.Direccion,
                            EstadoProvincia = u.EstadoProvincia,
                            Descripcion = u.Descripcion,
                            Comentarios = u.Comentarios,
                            Latitud=u.Latitud,
                            Longitud=u.Longitud,
                            FechaCreacion = u.FechaCreacion,
                            CreadoPor = u.CreadoPor,
                        };
            var request = await query.ToListAsync();
            return request;
        }

        public async Task<List<GetTokenResult>> GetTokenAsync(int? Id)
        {
            var query = from u in _dbContext.TipoCultivo
                        join t in _dbContext.MuestraToke on u.Id equals t.TipoCultivoId
                        where Id == 0 || t.TipoCultivoId == Id
                        select new GetTokenResult
                        {
                            TokenId=t.Id,
                            NombreCultivo = u.NombreCultivo,
                            TokenValue=t.TokenValue,
                            Expira = t.ExpiresAt,
                        };
            var request = await query.ToListAsync();
            return request;
        }
    }
}
