using System.ComponentModel.DataAnnotations;

namespace McvSoporte.Models
{
    public class Aviso
    {
        public int Id { get; set; }
        [Display(Name = "Descripción del problema")]
        [Required(ErrorMessage = "La descripción del aviso es un campo requerido.")]
        public string? Descripcion { get; set; }
        [Display(Name = "Fecha de aviso")]
        [Required(ErrorMessage = "La fecha en que se realiza el aviso es un campo requerido.")]
        [DataType(DataType.Date)]
        public DateTime FechaAviso { get; set; }
        [Display(Name = "Fecha de cierre")]
        [DataType(DataType.Date)]
        public DateTime? FechaCierre { get; set; }
        public string? Observaciones { get; set; }
        [Display(Name = "Empleado")]
        public int EmpleadoId { get; set; }
        [Display(Name = "Tipo de avería")]
        public int TipoAveriaId { get; set; }
        [Display(Name = "Equipo")]
        public int EquipoId { get; set; }
        public Empleado? Empleado { get; set; }
        public TipoAveria? TipoAveria { get; set; }
        public Equipo? Equipo { get; set; }
    }
}
