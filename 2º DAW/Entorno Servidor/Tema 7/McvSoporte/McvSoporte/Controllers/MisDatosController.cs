using McvSoporte.Data;
using McvSoporte.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace McvSoporte.Controllers
{
	[Authorize(Roles = "Usuario")]
	public class MisDatosController : Controller
	{
		private readonly McvSoporteContexto _context;
		public MisDatosController(McvSoporteContexto context)
		{
			_context = context;
		}
		// GET: MisDatos/Create
		public IActionResult Create()
		{
			return View();
		}
		// POST: MisDatos/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult>
		Create([Bind("Id,Nombre,Email,Telefono,FechaNacimiento")] Empleado empleado)
		{
			// Asignar el Email del usuario actual
			empleado.Email = User.Identity.Name;
			if (ModelState.IsValid)
			{
				_context.Add(empleado);
				await _context.SaveChangesAsync();
				return RedirectToAction("Index", "Home");
			}
			return View(empleado);
		}

		// GET: MisDatos/Edit
		public async Task<IActionResult> Edit()
		{
			// Se seleccionan los datos del empleado correspondiente al usuario actual
			string? emailUsuario = User.Identity.Name;
			Empleado? empleado = await _context.Empleados
			.Where(e => e.Email == emailUsuario)
			.FirstOrDefaultAsync();
			if (empleado == null)
			{
				return NotFound();
			}
			return View(empleado);
		}
		// POST: MisDatos/Edit
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Email,Telefono,FechaNacimiento")] Empleado empleado)
		{
			if (id != empleado.Id)
			{
				return NotFound();
			}
			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(empleado);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!EmpleadoExists(empleado.Id))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction("Index", "Home");
			}
			return View(empleado);
		}
		private bool EmpleadoExists(int id)
		{
			return (_context.Empleados?.Any(e => e.Id == id)).GetValueOrDefault();
		}
	}
}
