using System.ComponentModel.DataAnnotations;

namespace MascotasApp.Models
{
    public class Mascota
    {
        public int Id { get; set; }
        public string NombreTemporal { get; set; }
        public string Nombre { get; set; }
        public string DescripcionPersonalidad { get; set; }

        [Required]
        public string DescripcionFisica { get; set; }

        public TipoMascota Tipo { get; set; }
        
        // Shadow property
        public int? TipoMascotaId { get; set; }
    }
}