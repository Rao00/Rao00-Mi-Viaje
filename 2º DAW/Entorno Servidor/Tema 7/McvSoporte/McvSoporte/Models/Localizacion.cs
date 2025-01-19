using System.ComponentModel.DataAnnotations;

namespace McvSoporte.Models
{
    public class Localizacion
    {
        public int Id { get; set; }
        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "La descripción de la localización es un campo requerido.")]
        public string? Descripcion { get; set; }
        public ICollection<Equipo>? Equipos { get; set; }
    }
}
