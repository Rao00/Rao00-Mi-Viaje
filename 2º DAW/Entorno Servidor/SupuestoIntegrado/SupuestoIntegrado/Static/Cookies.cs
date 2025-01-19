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
        private readonly IHttpContextAccessor _httpContextAccessor;

        public Cookies(ApplicationDbContext context)
        {
            _context = context;
        }

        public Cookies(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetSesionToken()
        {
            Usuarios? user = null;
            string token = _httpContextAccessor.HttpContext.Request.Headers["Authorization"].ToString();

            if (token.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
            {
                user = _context.Usuarios.FirstOrDefault(u => u.Token == token.Substring("Bearer ".Length).Trim());
                if (user == null) { return "Usuario no encontrado"; }
            }

            return user.RolesId.ToString();
        }

        public IActionResult ComprobarRol(params string[] roles)
        {
            if (Array.IndexOf(roles, GetSesionToken()) != -1)
            {
                return Ok();
            }
            return Unauthorized();
        }
    }
}
