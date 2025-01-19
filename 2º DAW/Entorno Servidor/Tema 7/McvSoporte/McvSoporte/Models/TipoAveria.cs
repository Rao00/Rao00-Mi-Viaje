using System.ComponentModel.DataAnnotations;

namespace McvSoporte.Models
{
    public class TipoAveria
    {
        public int Id { get; set; }
        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "La descripción del tipo de avería es un campo requerido.")]
        public string? Descripcion { get; set; }
        public ICollection<Aviso>? Avisos { get; set; }
    }
}
