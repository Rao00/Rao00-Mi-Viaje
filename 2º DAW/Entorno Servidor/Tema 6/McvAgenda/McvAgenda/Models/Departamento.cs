using System.ComponentModel.DataAnnotations;

namespace MvcAgenda.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del departamento es un campo requerido.")]
        public string? Nombre { get; set; }
        public ICollection<Empleado>? Empleados { get; set; }
    }
}
