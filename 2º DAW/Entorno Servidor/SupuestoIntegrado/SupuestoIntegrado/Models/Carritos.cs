using Newtonsoft.Json;

namespace SupuestoIntegrado.Models
{
    public class Carritos
    {
        public int Id { get; set; }

        public int UsuariosId { get; set; }

        public int ProductosId { get; set; }

        public int? Cantidad { get; set; }

        public string? Estado { get; set; }

        [JsonIgnore]
        private Usuarios Usuarios { get; set; }

        [JsonIgnore]
        private Productos Productos { get; set; }   
    }
}
