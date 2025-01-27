using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SupuestoIntegrado.Models;
using SupuestoIntegrado.Data;
using Microsoft.Data.SqlClient;
using SupuestoIntegrado.Static;

namespace SupuestoIntegrado.Controllers
{
    [ApiController]
    [Route("api/roles")]
    public class RolesController : Controller
    {
        readonly internal ApplicationDbContext _context;

        public RolesController(ApplicationDbContext context) 
        {
            _context = context;
        }

        /// <summary>
        /// Obtiene los roles que coinciden con los filtros especificados.
        /// </summary>
        /// <param name="rol">El nombre del rol. Valor por defecto: "%" (coincidencia parcial).</param>
        /// <returns>Una lista de roles que coinciden con los filtros.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<Roles>), StatusCodes.Status200OK)]  // 200 OK: Usuarios encontrados
        [ProducesResponseType(StatusCodes.Status401Unauthorized)] // 401 Unauthorized: Usuario no autorizado
        [ProducesResponseType(StatusCodes.Status404NotFound)] // 404 Not Found: No se encontraron usuarios
        public ActionResult<RolesController> GetRol(string rol = "%")
        {
            string token = Request.Headers["Authorization"];
            if (new Cookies(_context).ComprobarRol(token, "1") is UnauthorizedResult) 
            { return Unauthorized(); };

            List<Roles> consulta =
                _context.Roles.FromSqlRaw(
                    $"SELECT * FROM Roles " +
                    $"WHERE DescripcionRol LIKE @rol",
                    new SqlParameter("@rol", rol)).ToList();

            if (consulta.Count() > 0)
            {
                JsonResult resultado = Json(consulta);
                return Ok(resultado);
            }
            return Conflict("No se han encontrado roles con ese filtro");
        }

        /// <summary>
        /// Crea un nuevo rol en el sistema.
        /// </summary>
        /// <param name="rol">Objeto que contiene los datos del nuevo rol.</param>
        /// <returns>Un mensaje de éxito o conflicto dependiendo de si el rol ya existe.</returns>
        [HttpPost]
        [ProducesResponseType(typeof(Roles), StatusCodes.Status200OK)] // 200 OK: Rol creado con éxito
        [ProducesResponseType(StatusCodes.Status401Unauthorized)] // 401 Unauthorized: Usuario no tiene permisos
        [ProducesResponseType(StatusCodes.Status409Conflict)] // 409 Conflict: El rol ya existe
        public ActionResult<RolesController> CrearRol([FromBody] Roles rol) //Crear Rol
        {
            string token = Request.Headers["Authorization"];
            if (new Cookies(_context).ComprobarRol(token, "1") is UnauthorizedResult)
            { return Unauthorized(); };

            if (_context.Roles.Where(role => role.DescripcionRol == rol.DescripcionRol).Count() > 0)
            {
                return Conflict($"El rol {rol.DescripcionRol} ya existe");
            }

            _context.Roles.Add(rol);
            _context.SaveChanges(true);

            JsonResult rolJson = Json(rol);

            return Ok(rolJson);
        }

        /// <summary>
        /// Elimina un rol del sistema.
        /// </summary>
        /// <param name="nombre">Nombre del rol a eliminar.</param>
        /// <returns>Un mensaje de éxito o conflicto dependiendo de si el rol existe.</returns>
        [HttpDelete]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)] // 200 OK: Rol eliminado con éxito
        [ProducesResponseType(StatusCodes.Status401Unauthorized)] // 401 Unauthorized: Usuario no tiene permisos
        [ProducesResponseType(StatusCodes.Status409Conflict)] // 409 Conflict: El rol no existe
        public ActionResult<RolesController> BorrarRol([FromBody] string nombre) //Borrar Rol
        {
            string token = Request.Headers["Authorization"];
            if (new Cookies(_context).ComprobarRol(token, "1") is UnauthorizedResult)
            { return Unauthorized(); };

            if (_context.Roles.Where(role => role.DescripcionRol == nombre).Count() == 0)
            {
                return Conflict($"El rol {nombre} no existe");
            }

            _context.Roles.Remove(_context.Roles.Where(role => role.DescripcionRol == nombre).First());
            _context.SaveChanges(true);

            return Ok("Rol borrado con exito");
        }

        /// <summary>
        /// Asigna un rol a un usuario.
        /// </summary>
        /// <param name="datos">Objeto que contiene el nombre del usuario y el rol a asignar.</param>
        /// <returns>Un mensaje de éxito o conflicto dependiendo de si el usuario ya tiene un rol asignado.</returns>
        [HttpPut]
        [Route("asign")]
        [ProducesResponseType(typeof(Usuarios), StatusCodes.Status200OK)] // 200 OK: Rol asignado con éxito
        [ProducesResponseType(StatusCodes.Status401Unauthorized)] // 401 Unauthorized: Usuario no tiene permisos
        [ProducesResponseType(StatusCodes.Status409Conflict)] // 409 Conflict: El usuario ya tiene un rol asignado o el rol no existe
        public ActionResult<RolesController> AsignarRol([FromBody] PlantillaAsignarDeasignarRol datos) //Asignar Rol
        {
            string token = Request.Headers["Authorization"];
            if (new Cookies(_context).ComprobarRol(token, "1") is UnauthorizedResult)
            { return Unauthorized(); };

            List<Usuarios> user = _context.Usuarios.Where(p => p.Name == datos.NombreUsuario).ToList();       
            if (user.Count() == 0)
            {
                return Conflict($"El usuario {datos.NombreUsuario} no existe");
            }

            List<Roles> rol = _context.Roles.Where(role => role.DescripcionRol == datos.NombreRol).ToList();
            if (rol.Count == 0)
            {
                return Conflict($"El rol {datos.NombreRol} no existe");
            }

            if (user[0].RolesId != null)
            {
                return Conflict($"El usuario {datos.NombreUsuario} ya tiene el rol {_context.Roles.Where(role => role.Id == user[0].RolesId).First().DescripcionRol} asignado");
            }

            user[0].RolesId = rol[0].Id;

            _context.Usuarios.Update(user[0]);
            _context.SaveChanges(true);

            return Ok(user[0]);
        }

        /// <summary>
        /// Desasigna el rol actual de un usuario.
        /// </summary>
        /// <param name="NombreUsuario">Nombre del usuario al que se le desasignará el rol.</param>
        /// <returns>Un mensaje de éxito o conflicto dependiendo de si el usuario tiene un rol asignado.</returns>
        [HttpPut]
        [Route("deasign")]
        [ProducesResponseType(typeof(Usuarios), StatusCodes.Status200OK)] // 200 OK: Rol desasignado con éxito
        [ProducesResponseType(StatusCodes.Status401Unauthorized)] // 401 Unauthorized: Usuario no tiene permisos
        [ProducesResponseType(StatusCodes.Status409Conflict)] // 409 Conflict: El usuario no tiene un rol asignado o no existe
        public ActionResult<RolesController> DesasignarRol([FromBody] string NombreUsuario) //Desasignar Rol
        {
            string token = Request.Headers["Authorization"];
            if (new Cookies(_context).ComprobarRol(token, "1") is UnauthorizedResult)
            { return Unauthorized(); };

            List<Usuarios> user = _context.Usuarios.Where(p => p.Name == NombreUsuario).ToList();
            if (user.Count() == 0)
            {
                return Conflict($"El usuario {NombreUsuario} no existe");
            }

            if (user[0].RolesId == null)
            {
                return Conflict($"El usuario {NombreUsuario} no tiene un rol asignado");
            }

            string rol = _context.Roles.Where(p => p.Id == user[0].RolesId).First().DescripcionRol;
            user[0].RolesId = null;

            _context.Usuarios.Update(user[0]);
            _context.SaveChanges(true);

            return Ok(user[0]);
        }
    }
}
