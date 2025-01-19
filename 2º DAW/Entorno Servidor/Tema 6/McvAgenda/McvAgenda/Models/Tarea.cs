using System.ComponentModel.DataAnnotations;

namespace MvcAgenda.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        [Display(Name = "Descripción")]
        public string? Descripcion { get; set; }
        [Display(Name = "Fecha de inicio")]
        [Required(ErrorMessage = "La fecha de inicio es un campo requerido.")]
        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }
        [Display(Name = "Fecha de fin")]
        [DataType(DataType.Date)]
        public DateTime? FechaFin { get; set; }
        [Display(Name = "Hora de inicio")]
        [Required(ErrorMessage = "La hora de inicio es un campo requerido.")]
        [DataType(DataType.Time)]
        public DateTime HoraInicio { get; set; }
        [Display(Name = "Hora de fin")]
        [DataType(DataType.Time)]
        public DateTime? HoraFin { get; set; }
        [Display(Name = "Empleado")]
        public int EmpleadoId { get; set; }
        public Empleado? Empleado { get; set; }
    }
}
