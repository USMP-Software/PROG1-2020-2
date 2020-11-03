using System.ComponentModel.DataAnnotations;

namespace webapp.Models
{
    public class Contacto
    {
        [Required]
        [Display(Name="Nombre completo")]
        public string Nombre { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name="Correo electrónico")]
        public string Correo { get; set; }

        [Required]
        public string Mensaje { get; set; }
    }
}