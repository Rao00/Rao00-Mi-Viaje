using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SupuestoIntegrado.Controllers;
using SupuestoIntegrado.Data;
using SupuestoIntegrado.Models;
using System.Web;

namespace SupuestoIntegrado.Static
{
    public class Cookies : Controller
    {
        readonly internal ApplicationDbContext _context;

        public Cookies(ApplicationDbContext context)
        {
            _context = context;
        }

        public string GetSesionToken(string token)
        {
            Usuarios? user = null;

            if (token.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
            {
                user = _context.Usuarios.FirstOrDefault(u => u.Token == token.Substring("Bearer ".Length).Trim());
                if (user == null) { return "Usuario no encontrado"; }
            }

            return user.RolesId.ToString();
        }

        public IActionResult ComprobarRol(string token, params string[] roles)
        {
            if (Array.IndexOf(roles, GetSesionToken(token)) != -1)
            {
                return Ok();
            }
            return Unauthorized();
        }
    }
}
