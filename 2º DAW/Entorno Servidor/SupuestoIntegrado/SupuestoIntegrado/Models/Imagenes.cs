using Newtonsoft.Json;

namespace SupuestoIntegrado.Models
{
    public class Imagenes
    {
        public int Id { get; set; }

        public string? Descripcion { get; set; }

        public string url { get; set; }

        public int? ProductoId { get; set; }

        [JsonIgnore]
        private Productos? Producto { get; set; }
    }
}
