using Microsoft.OpenApi.Models;
using SupuestoIntegrado.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace SupuestoIntegrado.Static
{
    public class SwaggerResponseDescriptionsFilter : ISchemaFilter
    {
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            // Modificar descripción de las propiedades de Usuarios
            if (context.Type == typeof(Usuarios))
            {
                schema.Description = "Representa a un usuario dentro del sistema.";

                if (schema.Properties.ContainsKey("Id"))
                {
                    schema.Properties["Id"].Description = "Identificador único del usuario.";
                }

                if (schema.Properties.ContainsKey("Name"))
                {
                    schema.Properties["Name"].Description = "El nombre del usuario. Este campo es obligatorio.";
                }

                if (schema.Properties.ContainsKey("Password"))
                {
                    schema.Properties["Password"].Description = "Contraseña del usuario. Este campo es obligatorio.";
                }

                if (schema.Properties.ContainsKey("Correo"))
                {
                    schema.Properties["Correo"].Description = "El correo electrónico del usuario. Este campo es único.";
                }

                if (schema.Properties.ContainsKey("Token"))
                {
                    schema.Properties["Token"].Description = "Token único generado para la autenticación del usuario.";
                }
            }

            // Modificar descripción de las propiedades de Roles
            if (context.Type == typeof(Roles))
            {
                schema.Description = "Representa un rol dentro del sistema.";

                if (schema.Properties.ContainsKey("Id"))
                {
                    schema.Properties["Id"].Description = "Identificador único del rol.";
                }

                if (schema.Properties.ContainsKey("DescripcionRol"))
                {
                    schema.Properties["DescripcionRol"].Description = "Descripción del rol de usuario.";
                }
            }

            // Modificar descripción de las propiedades de Imagenes
            if (context.Type == typeof(Imagenes))
            {
                schema.Description = "Representa una imagen asociada a un producto.";

                if (schema.Properties.ContainsKey("Id"))
                {
                    schema.Properties["Id"].Description = "Identificador único de la imagen.";
                }

                if (schema.Properties.ContainsKey("Descripcion"))
                {
                    schema.Properties["Descripcion"].Description = "Descripción de la imagen.";
                }

                if (schema.Properties.ContainsKey("url"))
                {
                    schema.Properties["url"].Description = "URL donde se encuentra la imagen.";
                }

                if (schema.Properties.ContainsKey("ProductoId"))
                {
                    schema.Properties["ProductoId"].Description = "Identificador del producto asociado a la imagen.";
                }
            }

            // Modificar descripción de las propiedades de Productos
            if (context.Type == typeof(Productos))
            {
                schema.Description = "Representa un producto disponible en el sistema.";

                if (schema.Properties.ContainsKey("Id"))
                {
                    schema.Properties["Id"].Description = "Identificador único del producto.";
                }

                if (schema.Properties.ContainsKey("Nombre"))
                {
                    schema.Properties["Nombre"].Description = "Nombre del producto.";
                }

                if (schema.Properties.ContainsKey("Descripcion"))
                {
                    schema.Properties["Descripcion"].Description = "Descripción del producto.";
                }

                if (schema.Properties.ContainsKey("Precio"))
                {
                    schema.Properties["Precio"].Description = "Precio del producto.";
                }
            }

            // Modificar descripción de las propiedades de Carritos
            if (context.Type == typeof(Carritos))
            {
                schema.Description = "Representa un carrito de compras, donde se almacenan productos seleccionados por un usuario.";

                if (schema.Properties.ContainsKey("Id"))
                {
                    schema.Properties["Id"].Description = "Identificador único del carrito.";
                }

                if (schema.Properties.ContainsKey("UsuariosId"))
                {
                    schema.Properties["UsuariosId"].Description = "Identificador del usuario asociado al carrito.";
                }

                if (schema.Properties.ContainsKey("ProductosId"))
                {
                    schema.Properties["ProductosId"].Description = "Identificador del producto asociado al carrito.";
                }

                if (schema.Properties.ContainsKey("Cantidad"))
                {
                    schema.Properties["Cantidad"].Description = "Cantidad del producto en el carrito.";
                }
            }
        }
    }
}
