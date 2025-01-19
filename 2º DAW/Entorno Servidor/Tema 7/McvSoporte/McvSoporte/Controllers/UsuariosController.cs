using McvSoporte.Data;
using McvSoporte.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace McvSoporte.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class UsuariosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public UsuariosController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var usuarios = from user in _context.Users
                           join userRoles in _context.UserRoles on user.Id equals userRoles.UserId
                           join role in _context.Roles on userRoles.RoleId equals role.Id
                           select new ViewUsuarioConRol
                           {
                               Email = user.Email,
                               NombreUsuario = user.UserName,
                               RolDeUsuario = role.Name
                           };
            return View(usuarios.ToList());
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: Usuarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Email,Password")] McvSoporte.Areas.Identity.Pages.Account.RegisterModel.InputModel model)
        {
            // Se crea el nuevo usuario
            var user = new IdentityUser();
            user.UserName = model.Email;
            user.Email = model.Email;
            string usuarioPWD = model.Password;
            var result = await _userManager.CreateAsync(user, usuarioPWD);

            // Se asigna el rol de "Administrador" al usuario
            if (result.Succeeded)
            {
                var result1 = await _userManager.AddToRoleAsync(user, "Administrador");
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
    }
}
