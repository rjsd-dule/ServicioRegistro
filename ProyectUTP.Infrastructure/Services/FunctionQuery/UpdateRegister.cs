using Microsoft.EntityFrameworkCore;
using ProyectUTP.Application.Features.Commands.TipoCultipo.UpdateTipoCultivo;
using ProyectUTP.Application.Features.Commands.Ubicacion.UpdateUbicacion;
using ProyectUTP.Domain.Identity.Entities;

namespace ProyectUTP.Infrastructure.Services.FunctionQuery
{
    public class UpdateRegister
    {
        private readonly ApplicationDbContext _dbContext;

        public UpdateRegister(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task UpdateTipoCultivo(TipoCultivo? toUpdate, UpdateTipoCultivoCommand command)
        {
            try
            {
                if (command.NombreCultivo!=null)
                    toUpdate.NombreCultivo = command.NombreCultivo;
                if (command.Descripcion != null)
                    toUpdate.Descripcion = command.Descripcion;
                if (command.CicloDeCultivo != null)
                    toUpdate.CicloDeCultivo = command.CicloDeCultivo;
                if (command.Temporada != null)
                    toUpdate.Temporada = command.Temporada;
                if (command.RequerimientosClimaticos != null)
                    toUpdate.RequerimientosClimaticos = command.RequerimientosClimaticos;
                if (command.FechaSiembra != null)
                    toUpdate.FechaSiembra = command.FechaSiembra;
                if (command.FechaCosecha != null)
                    toUpdate.FechaCosecha = command.FechaCosecha;
                if (command.TipoDeSuelo != null)
                    toUpdate.TipoDeSuelo = command.TipoDeSuelo;
                if (command.PHRecomendado != null)
                    toUpdate.PHRecomendado = command.PHRecomendado;

                toUpdate.ModificadoPor = command.ModificadoPor;
                toUpdate.FechaUltimaModificacion = DateTime.UtcNow;

                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("Error al actualizar la solicitud en la base de datos.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la solicitud: " + ex.Message);
            }
        }

        public async Task UpdateUbicacion(Ubicacion? toUpdate, UpdateUbicacionCommand command)
        {
            try
            {
                if (command.NombreUbicacion != null)
                    toUpdate.NombreUbicacion = command.NombreUbicacion;
                if (command.Direccion != null)
                    toUpdate.Direccion = command.Direccion;
                if (command.EstadoProvincia != null)
                    toUpdate.EstadoProvincia = command.EstadoProvincia;
                if (command.Descripcion != null)
                    toUpdate.Descripcion = command.Descripcion;
                if (command.Comentarios != null)
                    toUpdate.Comentarios = command.Comentarios;
                if (command.Latitud != null)
                    toUpdate.Latitud = command.Latitud;
                if (command.Longitud != null)
                    toUpdate.Longitud = command.Longitud;

                toUpdate.ModificadoPor = command.ModificadoPor;
                toUpdate.FechaUltimaModificacion = DateTime.UtcNow;

                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("Error al actualizar la solicitud en la base de datos.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la solicitud: " + ex.Message);
            }
        }
    }
}
