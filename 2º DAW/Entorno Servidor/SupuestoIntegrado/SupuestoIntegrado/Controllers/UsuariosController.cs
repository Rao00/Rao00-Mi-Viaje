using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SupuestoIntegrado.Models;
using SupuestoIntegrado.Data;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
using SupuestoIntegrado.Static;

namespace SupuestoIntegrado.Controllers
{
    [ApiController]
    public class UsuariosController : Controller
    {
        readonly internal ApplicationDbContext _context;

        public UsuariosController(ApplicationDbContext context) 
        {
            _context = context;
        }

        /// <summary>
        /// Obtiene los usuarios que coinciden con los filtros especificados.
        /// </summary>
        /// <param name="nombre">El nombre del usuario. Valor por defecto: "%" (coincidencia parcial).</param>
        /// <param name="correo">El correo electrónico del usuario. Valor por defecto: "%" (coincidencia parcial).</param>
        /// <returns>Una lista de usuarios que coinciden con los filtros.</returns>
        [HttpGet]
        [Route("api/users")]
        [ProducesResponseType(typeof(List<Usuarios>), StatusCodes.Status200OK)]  // 200 OK: Usuarios encontrados
        [ProducesResponseType(StatusCodes.Status401Unauthorized)] // 401 Unauthorized: Usuario no autorizado
        [ProducesResponseType(StatusCodes.Status404NotFound)] // 404 Not Found: No se encontraron usuarios
        public ActionResult<UsuariosController> GetUsuario([FromQuery] string nombre = "%", [FromQuery] string correo = "%") //Conseguir Datos
        {
            if (new Cookies(_context).ComprobarRol("1", "2") is UnauthorizedResult)
            { 
                return Unauthorized(); 
            };

            List<Usuarios> consulta =
                _context.Usuarios.FromSqlRaw(
                    $"SELECT * FROM Usuarios " +
                    $"WHERE Name LIKE @nombre AND " +
                    $"Correo LIKE @correo ",
                    new SqlParameter("@nombre", nombre),
                    new SqlParameter("@correo", correo)).ToList();

            if (consulta.Count() == 0)
            {
                return NotFound($"Usuario no encontrado");
            }

            JsonResult usuarioJson = Json(consulta);
            
            return Ok(usuarioJson);
        }

        /// <summary>
        /// Crea una nueva cuenta de usuario.
        /// </summary>
        /// <param name="usuario">Objeto que contiene los datos del nuevo usuario.</param>
        /// <returns>Un mensaje de éxito o conflicto dependiendo de si el usuario ya existe o el correo ya está en uso.</returns>
        [HttpPost]
        [Route("api/users/new")]
        [ProducesResponseType(typeof(Usuarios), StatusCodes.Status200OK)] // 200 OK: Usuario creado con éxito
        [ProducesResponseType(StatusCodes.Status401Unauthorized)] // 401 Unauthorized: El usuario no tiene permisos
        [ProducesResponseType(StatusCodes.Status409Conflict)] // 409 Conflict: Usuario o correo ya existe
        public ActionResult<UsuariosController> CrearCuenta([FromBody]Usuarios usuario)
        {
            // Verificar permisos de rol
            if (new Cookies(_context).ComprobarRol("1", "3") is UnauthorizedResult)
            {
                return Unauthorized();
            }

            // Verificar si el nombre de usuario ya está registrado
            if (_context.Usuarios.Any(user => user.Name == usuario.Name))
            {
                return Conflict($"El usuario {usuario.Name} ya existe");
            }

            // Verificar si el correo ya está registrado
            if (!string.IsNullOrEmpty(usuario.Correo) && _context.Usuarios.Any(user => user.Correo == usuario.Correo))
            {
                return Conflict($"El correo {usuario.Correo} ya está en uso");
            }

            // Generar un token de usuario
            string token = usuario.GetHashCode().ToString();
            usuario.Token = token;

            // Agregar el nuevo usuario a la base de datos
            _context.Usuarios.Add(usuario);
            _context.SaveChanges(true);

            JsonResult usuarioJson = Json(usuario);

            return Ok(usuarioJson);
        }

        /// <summary>
        /// Elimina una cuenta de usuario.
        /// </summary>
        /// <param name="usuario">Objeto que contiene los datos del usuario a eliminar.</param>
        /// <returns>Un mensaje de éxito o conflicto si no se encuentra el usuario o la contraseña es incorrecta.</returns>
        [HttpPost]
        [Route("api/users/delete")]
        [ProducesResponseType(typeof(Usuarios), StatusCodes.Status200OK)] // 200 OK: Usuario eliminado con éxito
        [ProducesResponseType(StatusCodes.Status401Unauthorized)] // 401 Unauthorized: El usuario no tiene permisos
        [ProducesResponseType(StatusCodes.Status409Conflict)] // 409 Conflict: Usuario no existe o contraseña incorrecta
        public ActionResult<UsuariosController> BorrarCuenta([FromBody] Usuarios usuario)
        {
            // Verificar permisos de rol
            if (new Cookies(_context).ComprobarRol("1", "2") is UnauthorizedResult)
            {
                return Unauthorized();
            }

            // Verificar si el usuario existe
            if (!_context.Usuarios.Any(user => user.Name == usuario.Name))
            {
                return Conflict($"El usuario {usuario.Name} no existe");
            }

            // Verificar si la contraseña es correcta
            if (!_context.Usuarios.Any(user => user.Name == usuario.Name && user.Password == usuario.Password))
            {
                return Conflict("Contraseña incorrecta");
            }

            // Eliminar el usuario de la base de datos
            _context.Usuarios.Remove(_context.Usuarios.First(user => user.Name == usuario.Name));
            _context.SaveChanges(true);

            JsonResult usuarioJson = Json(usuario);

            return Ok(usuarioJson);
        }

        /// <summary>
        /// Edita los datos de una cuenta de usuario.
        /// </summary>
        /// <param name="usuario">Objeto que contiene los datos del usuario a editar.</param>
        /// <returns>Un mensaje de éxito o conflicto si no hay cambios o el usuario no está disponible.</returns>
        [HttpPost]
        [Route("api/users/edit")]
        [ProducesResponseType(typeof(Usuarios), StatusCodes.Status200OK)] // 200 OK: Usuario actualizado con éxito
        [ProducesResponseType(StatusCodes.Status401Unauthorized)] // 401 Unauthorized: El usuario no tiene permisos
        [ProducesResponseType(StatusCodes.Status409Conflict)] // 409 Conflict: No hay cambios a realizar o el usuario ya está en uso
        public ActionResult<UsuariosController> EditarCuenta([FromBody] Usuarios usuario)
        {
            // Verificar permisos de rol
            if (new Cookies(_context).ComprobarRol("1", "2") is UnauthorizedResult)
            {
                return Unauthorized();
            }

            // Verificar si el usuario existe
            var usuarioComprobar = _context.Usuarios.FirstOrDefault(user => user.Name == usuario.Name);
            if (usuarioComprobar == null)
            {
                return Conflict($"El usuario {usuario.Name} no existe");
            }

            // Verificar si el token no coincide con el de la base de datos
            if (usuarioComprobar.Token != usuario.Token)
            {
                return Conflict($"El usuario {usuario.Name} ya está en uso");
            }

            // Verificar si no hay cambios
            if (usuarioComprobar.Equals(usuario))
            {
                return Conflict("No hay cambios a realizar");
            }

            // Actualizar la cuenta de usuario
            _context.Usuarios.Update(usuarioComprobar);
            _context.SaveChanges(true);

            // Retornar los datos actualizados del usuario
            JsonResult usuarioJson = Json(_context.Usuarios.Where(user => user.Token == usuario.Token));
            return Ok($"Usuario actualizado con éxito\n{usuarioJson}");
        }

    }
}
