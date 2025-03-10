using ProyectUTP.Application.Features.Commands.TipoCultipo.CreateTipoCultivo;
using ProyectUTP.Application.Features.Commands.Ubicacion.CreateUbicacion;
using ProyectUTP.Domain.Identity.Entities;

namespace ProyectUTP.Infrastructure.Services.FunctionQuery
{
    public class AddQuerys
    {
        private readonly ApplicationDbContext _dbContext;

        public AddQuerys(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TipoCultivo AddtipoCultivo (CreateTipoCultivoCommand command)
        {
            return new TipoCultivo
            {
                NombreCultivo=command.NombreCultivo,
                Descripcion=command.Descripcion,
                CicloDeCultivo=command.CicloDeCultivo,
                Temporada=command.Temporada,
                RequerimientosClimaticos=command.RequerimientosClimaticos,
                FechaSiembra=command.FechaSiembra,
                FechaCosecha=command.FechaCosecha,
                TipoDeSuelo=command.TipoDeSuelo,
                PHRecomendado=command.PHRecomendado,
                Ubicacionid=command.Ubicacionid,
                StatusId=1,
                FechaCreacion =DateTime.UtcNow
            };
        }

        public Ubicacion AddUbicacion(CreateUbicacionCommand command)
        {
            return new Ubicacion
            {
                NombreUbicacion=command.NombreUbicacion,
                Direccion=command.Direccion,
                EstadoProvincia =command.EstadoProvincia,
                Descripcion = command.Descripcion,
                Comentarios=command.Comentarios,
                Latitud=command.Latitud,
                Longitud=command.Longitud,
                CreadoPor=command.CreadoPor,
                FechaCreacion = DateTime.UtcNow
            };
        }
        /*TipoCultivoId = Ubicacion*/
        public MuestraToke addUbicacionToken(string Token,string CreadoPor,int TipoCultivoId, DateTime Expirees)
        {
            return new MuestraToke
            {
                TokenValue= Token,
                TipoCultivoId = TipoCultivoId,
                UbicacionId= TipoCultivoId,
                CreadoPor = CreadoPor,
                StatusId=1,
                ExpiresAt= Expirees,
                FechaCreacion = DateTime.UtcNow
            };
        }
    }
}
