using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SupuestoIntegrado.Models;
using SupuestoIntegrado.Data;
using Microsoft.Data.SqlClient;
using SupuestoIntegrado.Static;

namespace SupuestoIntegrado.Controllers
{
    /// <summary>
    /// Controlador para gestionar las operaciones relacionadas con los productos.
    /// </summary>
    [ApiController]
    [Route("api/productos")]
    public class ProductosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductosController(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Obtiene los productos que coinciden con el filtro especificado.
        /// </summary>
        /// <param name="nombre">El nombre del producto. Valor por defecto: "%".</param>
        /// <returns>Una lista de productos que coinciden con el filtro.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<Productos>), StatusCodes.Status200OK)] // 200 OK: Productos encontrados
        [ProducesResponseType(StatusCodes.Status401Unauthorized)] // 401 Unauthorized: Usuario no autorizado
        [ProducesResponseType(StatusCodes.Status404NotFound)] // 404 Not Found: No se encontraron productos
        public ActionResult<ProductosController> GetProductos([FromQuery] string nombre = "%")
        {
            string token = Request.Headers["Authorization"];
            if (new Cookies(_context).ComprobarRol(token, "1", "2", "3") is UnauthorizedResult)
            {
                return Unauthorized();
            }

            List<Productos> consulta = _context.Productos.FromSqlRaw(
                $"SELECT * FROM Productos WHERE Nombre LIKE @nombre",
                new SqlParameter("@nombre", nombre)).ToList();

            if (consulta.Count == 0)
            {
                return NotFound($"Producto no encontrado");
            }

            JsonResult productoJson = Json(consulta);
            return Ok(productoJson);
        }

        /// <summary>
        /// Crea un nuevo producto en el sistema.
        /// </summary>
        /// <param name="producto">Objeto que contiene los datos del nuevo producto.</param>
        /// <returns>El producto creado o un mensaje de conflicto si ya existe.</returns>
        [HttpPost]
        [ProducesResponseType(typeof(Productos), StatusCodes.Status200OK)] // 200 OK: Producto creado con éxito
        [ProducesResponseType(StatusCodes.Status401Unauthorized)] // 401 Unauthorized: Usuario no autorizado
        [ProducesResponseType(StatusCodes.Status409Conflict)] // 409 Conflict: Producto ya existe
        public ActionResult<ProductosController> CrearProductos([FromBody] Productos producto)
        {
            string token = Request.Headers["Authorization"];
            if (new Cookies(_context).ComprobarRol(token, "1") is UnauthorizedResult)
            {
                return Unauthorized();
            }

            if (_context.Productos.Any(user => user.Nombre == producto.Nombre))
            {
                return Conflict($"El producto {producto.Nombre} ya existe");
            }

            _context.Productos.Add(producto);
            _context.SaveChanges(true);

            return Ok(new JsonResult(producto));
        }

        /// <summary>
        /// Elimina un producto por su ID.
        /// </summary>
        /// <param name="id">ID del producto a eliminar.</param>
        /// <returns>El producto eliminado o un mensaje de conflicto si no existe.</returns>
        [HttpDelete]
        [ProducesResponseType(typeof(Productos), StatusCodes.Status200OK)] // 200 OK: Producto eliminado con éxito
        [ProducesResponseType(StatusCodes.Status401Unauthorized)] // 401 Unauthorized: Usuario no autorizado
        [ProducesResponseType(StatusCodes.Status409Conflict)] // 409 Conflict: Producto no existe
        public ActionResult<ProductosController> BorrarProductos([FromBody] int id)
        {
            string token = Request.Headers["Authorization"];
            if (new Cookies(_context).ComprobarRol(token, "1") is UnauthorizedResult)
            {
                return Unauthorized();
            }

            if (!_context.Productos.Any(user => user.Id == id))
            {
                return Conflict($"El producto con ID: {id} no existe");
            }

            Productos p = _context.Productos.First(user => user.Id == id);
            _context.Productos.Remove(p);
            _context.SaveChanges(true);

            return Ok(p);
        }

        /// <summary>
        /// Edita los datos de un producto existente.
        /// </summary>
        /// <param name="id">ID del producto a editar.</param>
        /// <param name="producto">Objeto que contiene los nuevos datos del producto.</param>
        /// <returns>El producto actualizado o un mensaje de conflicto si hay errores.</returns>
        [HttpPut]
        [ProducesResponseType(typeof(Productos), StatusCodes.Status200OK)] // 200 OK: Producto actualizado con éxito
        [ProducesResponseType(StatusCodes.Status401Unauthorized)] // 401 Unauthorized: Usuario no autorizado
        [ProducesResponseType(StatusCodes.Status409Conflict)] // 409 Conflict: Conflicto en la edición del producto
        public ActionResult<ProductosController> EditarProducto([FromQuery] int id, [FromBody] Productos producto)
        {
            string token = Request.Headers["Authorization"];
            if (new Cookies(_context).ComprobarRol(token, "1") is UnauthorizedResult)
            {
                return Unauthorized();
            }

            if (_context.Productos.Any(user => user.Nombre == producto.Nombre))
            {
                Productos productoComprobar = _context.Productos.First(user => user.Nombre == producto.Nombre);
                if (productoComprobar.Id != id)
                {
                    return Conflict($"El nombre de producto {producto.Nombre} ya está en uso");
                }
                if (productoComprobar == producto)
                {
                    return Conflict($"No hay cambios a realizar");
                }
            }

            _context.Productos.Update(_context.Productos.First(user => user.Id == id));
            _context.SaveChanges(true);

            JsonResult productoJson = Json(_context.Productos.First(user => user.Id == id));
            return Ok($"Producto actualizado con éxito\n{productoJson}");
        }
    }
}
