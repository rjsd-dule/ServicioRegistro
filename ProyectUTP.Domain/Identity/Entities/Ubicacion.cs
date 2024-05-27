using ProyectUTP.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectUTP.Domain.Identity.Entities
{
    public class Ubicacion: EntidadBase
    {
        
        public string NombreUbicacion { get; set; } 
        public string Direccion { get; set; }
        public string EstadoProvincia { get; set; }
        public string Descripcion { get; set; } 
        public string Comentarios { get; set; }

        [Column(TypeName = "decimal(9, 6)")]
        public decimal? Latitud { get; set; }

        [Column(TypeName = "decimal(9, 6)")]
        public decimal? Longitud { get; set; }
    }
}
