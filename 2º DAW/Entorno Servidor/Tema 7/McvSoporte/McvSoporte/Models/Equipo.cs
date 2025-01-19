using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace McvSoporte.Models
{
    public class Equipo
    {
        public int Id { get; set; }
        [Display(Name = "Código equipo")]
        [Required(ErrorMessage = "El código del equipo es un campo requerido.")]
        public string? CodigoEquipo { get; set; }
        [Required(ErrorMessage = "La marca es un campo requerido.")]
        public string? Marca { get; set; }
        [Required(ErrorMessage = "El modelo es un campo requerido.")]
        public string? Modelo { get; set; }
        [Display(Name = "Número de serie")]
        [Required(ErrorMessage = "El número de serie es un campo requerido.")]
        public string? NumeroSerie { get; set; }
        [Display(Name = "Características técnicas")]
        public string? Caracteristicas { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Precio { get; set; }
        [Display(Name = "Precio")]
        [RegularExpression(@"^[-0123456789]+[0-9.,]*$",
        ErrorMessage = "El valor introducido debe ser de tipo monetario.")]
        [Required(ErrorMessage = "El precio es un campo requerido")]
        public string PrecioCadena
        {
            get
            {
                return Convert.ToString(Precio).Replace(',', '.');
            }
            set
            {
                Precio = Convert.ToDecimal(value.Replace('.', ','));
            }
        }
        [Display(Name = "Fecha de compra")]
        [Required(ErrorMessage = "La fecha de compra es un campo requerido.")]
        [DataType(DataType.Date)]
        public DateTime FechaCompra { get; set; }
        [Display(Name = "Fecha de baja")]
        [DataType(DataType.Date)]
        public DateTime? FechaBaja { get; set; }
        [Display(Name = "Localización")]
        public int LocalizacionId { get; set; }
        public ICollection<Aviso>? Avisos { get; set; }
        public Localizacion? Localizacion { get; set; }
    }
}
