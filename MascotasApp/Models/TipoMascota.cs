using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MascotasApp.Models
{
    public class TipoMascota
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public ICollection<Mascota> Mascotas { get; set; }

        [Column(TypeName="decimal(5,2)")]
        public decimal? TiempoVidaPromedio { get; set; }

    }
}