using System.ComponentModel.DataAnnotations;

namespace contacto.Models
{
    public class Contacto
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Mensaje { get; set; }
    }
}