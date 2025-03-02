﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using SupuestoIntegrado.Data;
using SupuestoIntegrado.Models;
using SupuestoIntegrado.Static;

namespace SupuestoIntegrado.Controllers
{
    [ApiController]
    [Route("/api/carritos")]
    public class CarritosController : Controller
    {
        readonly internal ApplicationDbContext _context;

        public CarritosController(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Obtiene los productos del carrito de un usuario.
        /// </summary>
        /// <param name="token">Token del usuario para identificarlo.</param>
        /// <param name="idCarrito">ID del carrito a consultar. Valor por defecto: -1 (obtiene el último carrito).</param>
        /// <returns>Lista de productos en el carrito o un mensaje de conflicto si el carrito no existe.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<Carritos>), StatusCodes.Status200OK)] // 200 OK: Carrito encontrado
        [ProducesResponseType(StatusCodes.Status401Unauthorized)] // 401 Unauthorized: Usuario no tiene permisos
        [ProducesResponseType(StatusCodes.Status409Conflict)] // 409 Conflict: Carrito o usuario no existe
        public ActionResult<CarritosController> LeerCarrito([FromQuery] int idCarrito = -1) //Leer Carrito
        {
            string token = Request.Headers["Authorization"];
            if (new Cookies(_context).ComprobarRol(token, "1", "2") is UnauthorizedResult)
            { 
                return Unauthorized(); 
            };

            List<Usuarios> user = _context.Usuarios.Where(p => p.Token == token).ToList();
            List<Carritos> listaCarritos;
            List<Carritos> carrito = new List<Carritos>();
            if (user.Count() == 0)
            {
                return Conflict($"El usuario con token {token} no existe");
            }

            if (idCarrito < 0)
            {
                listaCarritos = _context.Carritos.Where(c => c.UsuariosId == user[0].Id).ToList();
                if (listaCarritos.Count() <= 0) { return Conflict($"El usuario no tiene carrito"); }

                int maxId = listaCarritos.Max(c => c.Id);

                foreach (Carritos producto in listaCarritos)
                {
                    if (producto.Id == maxId)
                        carrito.Add(producto);
                }
            }
            else
            {
                listaCarritos = _context.Carritos.Where(c => c.UsuariosId == user[0].Id && c.Id == idCarrito).ToList();
                if (listaCarritos.Count() <= 0) { return Conflict($"El usuario no tiene carrito"); }

                foreach (Carritos producto in listaCarritos)
                {
                    carrito.Add(producto);
                }
            }

            return Ok(carrito);
        }

        /// <summary>
        /// Añade un producto al carrito de un usuario.
        /// </summary>
        /// <param name="body">Token del usuario e ID del producto para identificarlo.</param>
        /// <param name="cantidad">Cantidad del producto a añadir. Valor por defecto: 1.</param>
        /// <returns>El producto añadido o actualizado en el carrito.</returns>
        [HttpPost]
        [ProducesResponseType(typeof(Carritos), StatusCodes.Status200OK)] // 200 OK: Producto añadido o actualizado en el carrito
        [ProducesResponseType(StatusCodes.Status401Unauthorized)] // 401 Unauthorized: Usuario no tiene permisos
        [ProducesResponseType(StatusCodes.Status409Conflict)] // 409 Conflict: Usuario o carrito no existe
        public ActionResult<CarritosController> AñadirProductoCarrito([FromBody] PlantillaAñadirEliminarCarritos body, [FromQuery] int cantidad = 1) //Añadir Carrito
        {
            string token = Request.Headers["Authorization"];
            if (new Cookies(_context).ComprobarRol(token, "1", "2") is UnauthorizedResult)
            { return Unauthorized(); };

            List<Usuarios> user = _context.Usuarios.Where(p => p.Token == body.token).ToList();
            List<Productos> productos = _context.Productos.Where(p => p.Id == body.idProducto).ToList();
            List<Carritos> listaCarritos;
            if (user.Count() == 0)
            {
                return NotFound($"El usuario con token {body.token} no existe");
            }

            if (productos.Count() == 0)
            { 
                return NotFound($"El producto con id {body.idProducto} no existe");
            }

            listaCarritos = _context.Carritos.Where(c => c.UsuariosId == user[0].Id).ToList();
            if (listaCarritos.Count() <= 0) { return Conflict($"El usuario no tiene carrito"); }

            int maxId = listaCarritos.Max(c => c.Id);

            List<Carritos> carrito = _context.Carritos.Where(c => c.UsuariosId == user[0].Id
                                        && c.Id == maxId
                                        && c.ProductosId == body.idProducto).ToList();
            Carritos producto = carrito[0];

            if (producto.Estado != "Pendiente")
            {
                return Conflict("El pedido ya se ha tramitado");
            }

            if (carrito.Count == 0)
            {
                producto.Cantidad = cantidad;
                _context.Carritos.Add(producto);
                return Ok(carrito);
            }
            else
            {
                producto.Cantidad += cantidad;
                _context.Carritos.Update(producto);
                return Ok(carrito);
            }
        }

        /// <summary>
        /// Elimina un producto del carrito de un usuario.
        /// </summary>
        /// <param name="body">Token del usuario e ID del producto para identificarlo.</param>
        /// <param name="cantidad">Cantidad del producto a eliminar. Valor por defecto: 1.</param>
        /// <returns>Un mensaje de éxito o conflicto dependiendo del estado del producto en el carrito.</returns>
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)] // 200 OK: Producto eliminado correctamente
        [ProducesResponseType(StatusCodes.Status401Unauthorized)] // 401 Unauthorized: Usuario no tiene permisos
        [ProducesResponseType(StatusCodes.Status409Conflict)] // 409 Conflict: Usuario, carrito o producto no existe
        public ActionResult<CarritosController> EliminarProductoCarrito([FromBody] PlantillaAñadirEliminarCarritos body, [FromQuery] int cantidad = 1) //Añadir Carrito
        {
            string token = Request.Headers["Authorization"];
            if (new Cookies(_context).ComprobarRol(token, "1", "2") is UnauthorizedResult)
            { return Unauthorized(); };

            List<Usuarios> user = _context.Usuarios.Where(p => p.Token == body.token).ToList();
            List<Productos> productos = _context.Productos.Where(p => p.Id == body.idProducto).ToList();
            List<Carritos> listaCarritos;
            if (user.Count() == 0)
            {
                return NotFound($"El usuario con token {body.token} no existe");
            }

            if (productos.Count() == 0)
            {
                return NotFound($"El producto con id {body.idProducto} no existe");
            }

            listaCarritos = _context.Carritos.Where(c => c.UsuariosId == user[0].Id).ToList();
            if (listaCarritos.Count() <= 0) { return Conflict($"El usuario no tiene carrito"); }

            int maxId = listaCarritos.Max(c => c.Id);

            List<Carritos> carrito = _context.Carritos.Where(c => c.UsuariosId == user[0].Id
                                        && c.Id == maxId
                                        && c.ProductosId == body.idProducto).ToList();
            Carritos producto = carrito[0];

            if (producto.Estado != "Pendiente")
            {
                return Conflict("El pedido ya se ha tramitado");
            }

            if (carrito.Count == 0)
            {
                return NotFound("Producto no existe en el carrito");
            }

            if (carrito.Count == 1)
            {
                _context.Carritos.Remove(producto);
                _context.SaveChanges(true);
                return Ok("Producto eliminado correctamente");
            }
            else
            {
                if (producto.Cantidad - cantidad > 0)
                {
                    producto.Cantidad -= cantidad;
                    _context.Carritos.Update(producto);
                    _context.SaveChanges(true);
                    return Ok("Producto eliminado correctamente");
                }
                else
                {
                    _context.Carritos.Remove(producto);
                    _context.SaveChanges(true);
                    return Ok("Producto eliminado correctamente");
                }
            }
        }

        [HttpPut]
        [Route("estado")]
        public ActionResult<CarritosController> ActualizarEstado([FromBody] string nuevoEstado)
        {
            string token = Request.Headers["Authorization"];
            if (new Cookies(_context).ComprobarRol("1", "2") is UnauthorizedResult)
            { return Unauthorized(); };

            List<Usuarios> user = _context.Usuarios.Where(p => p.Token == token).ToList();
            List<Carritos> listaCarritos;
            if (user.Count() == 0)
            {
                return Conflict($"El usuario con token {token} no existe");
            }

            listaCarritos = _context.Carritos.Where(c => c.UsuariosId == user[0].Id).ToList();
            if (listaCarritos.Count() <= 0) { return Conflict($"El usuario no tiene carrito"); }
            int maxId = listaCarritos.Max(c => c.Id);

            List<Carritos> carrito = _context.Carritos.Where(c => c.UsuariosId == user[0].Id
                                        && c.Id == maxId).ToList();

            foreach (Carritos producto in carrito)
            {
                producto.Estado = nuevoEstado;
                _context.Carritos.Update(producto);
            }

            _context.SaveChanges(true);
            return Ok(carrito);
        }
    }
}
