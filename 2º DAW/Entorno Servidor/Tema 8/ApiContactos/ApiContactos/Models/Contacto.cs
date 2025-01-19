using System.ComponentModel.DataAnnotations;

namespace ApiContactos.Models
{
    public class Contacto
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "El nombre del empleado es un campo requerido.")]
        public string? Nombre { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public bool Activado { get; set; }
    }
}
