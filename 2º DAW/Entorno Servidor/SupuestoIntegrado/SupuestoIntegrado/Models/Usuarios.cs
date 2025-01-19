using System.Runtime.Serialization;

namespace SupuestoIntegrado.Models
{
    public class Usuarios
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string? Correo { get; set; }

        public string? Token { get; set; }

        public int? RolesId { get; set; }

        [IgnoreDataMember]
        private Roles? Roles { get; set; }
    }
}
