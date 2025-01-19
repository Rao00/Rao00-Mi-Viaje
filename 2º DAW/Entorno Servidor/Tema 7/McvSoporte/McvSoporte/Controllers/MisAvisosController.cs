using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using McvSoporte.Data;
using McvSoporte.Models;
using Microsoft.AspNetCore.Authorization;

namespace McvSoporte.Controllers
{
    [Authorize(Roles = "Usuario")]
    public class MisAvisosController : Controller
    {
        private readonly McvSoporteContexto _context;

        public MisAvisosController(McvSoporteContexto context)
        {
            _context = context;
        }

        // GET: MisAvisos
        public async Task<IActionResult> Index()
        {
            // Se selecciona el empleado correspondiente al usuario actual
            var emailUsuario = User.Identity.Name;
            var empleado = await _context.Empleados.Where(e => e.Email == emailUsuario)
            .FirstOrDefaultAsync();
            if (empleado == null)
            {
                return RedirectToAction("Index", "Home");
            }
            // Se seleccionan los avisos del Empleado correspondiente al usuario actual
            var misAvisos = _context.Avisos
            .Where(a => a.EmpleadoId == empleado.Id)
            .OrderByDescending(a => a.FechaAviso)
            .Include(a => a.Empleado).Include(a => a.Equipo).Include(a => a.TipoAveria);
            return View(await misAvisos.ToListAsync());
            // var mvcSoporteContexto = _context.Avisos.Include(a => a.Empleado)
            // .Include(a => a.Equipo).Include(a => a.TipoAveria);
            // return View(await mvcSoporteContexto.ToListAsync());

        }

        // GET: MisAvisos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aviso = await _context.Avisos
                .Include(a => a.Empleado)
                .Include(a => a.Equipo)
                .Include(a => a.TipoAveria)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aviso == null)
            {
                return NotFound();
            }

            // Para evitar el acceso a los avisos de otros empleados
            var emailUsuario = User.Identity.Name;
            var empleado = await _context.Empleados
            .Where(e => e.Email == emailUsuario)
            .FirstOrDefaultAsync();
            if (empleado == null)
            {
                return NotFound();
            }
            if (aviso.EmpleadoId != empleado.Id)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(aviso);
        }

        // GET: MisAvisos/Create
        public IActionResult Create()
        {
            // ViewData["EmpleadoId"] = new SelectList(_context.Empleados, "Id", "Nombre");
            ViewData["EquipoId"] = new SelectList(_context.Equipos, "Id", "CodigoEquipo");
            ViewData["TipoAveriaId"] = new SelectList(_context.TipoAverias, "Id", "Descripcion");
            return View();

        }

        // POST: MisAvisos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descripcion,FechaAviso,FechaCierre,Observaciones,EmpleadoId,TipoAveriaId,EquipoId")] Aviso aviso)
        {
            // Se asigna al aviso el Id del empleado correspondiente al usuario actual
            var emailUsuario = User.Identity.Name;
            var empleado = await _context.Empleados
            .Where(e => e.Email == emailUsuario)
            .FirstOrDefaultAsync();
            if (empleado != null)
            {
                aviso.EmpleadoId = empleado.Id;
            }
            if (ModelState.IsValid)
            {
                _context.Add(aviso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            // ViewData["EmpleadoId"] = new SelectList(_context.Empleados, "Id", "Nombre",
            // aviso.EmpleadoId);
            ViewData["EquipoId"] = new SelectList(_context.Equipos, "Id", "CodigoEquipo",
            aviso.EquipoId);
            ViewData["TipoAveriaId"] = new SelectList(_context.TipoAverias, "Id", "Descripcion",
            aviso.TipoAveriaId);
            return View(aviso);
        }

        // GET: MisAvisos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aviso = await _context.Avisos.FindAsync(id);
            if (aviso == null)
            {
                return NotFound();
            }

            // Para evitar el acceso a los avisos de otros empleados
            var emailUsuario = User.Identity.Name;
            var empleado = await _context.Empleados
            .Where(e => e.Email == emailUsuario)
            .FirstOrDefaultAsync();
            if (empleado == null)
            {
                return NotFound();
            }
            if (aviso.EmpleadoId != empleado.Id)
            {
                return RedirectToAction(nameof(Index));
            }

            ViewData["EmpleadoId"] = new SelectList(_context.Empleados, "Id", "Nombre", aviso.EmpleadoId);
            ViewData["EquipoId"] = new SelectList(_context.Equipos, "Id", "CodigoEquipo", aviso.EquipoId);
            ViewData["TipoAveriaId"] = new SelectList(_context.TipoAverias, "Id", "Descripcion", aviso.TipoAveriaId);
            return View(aviso);
        }

        // POST: MisAvisos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descripcion,FechaAviso,FechaCierre,Observaciones,EmpleadoId,TipoAveriaId,EquipoId")] Aviso aviso)
        {
            if (id != aviso.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aviso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AvisoExists(aviso.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmpleadoId"] = new SelectList(_context.Empleados, "Id", "Nombre", aviso.EmpleadoId);
            ViewData["EquipoId"] = new SelectList(_context.Equipos, "Id", "CodigoEquipo", aviso.EquipoId);
            ViewData["TipoAveriaId"] = new SelectList(_context.TipoAverias, "Id", "Descripcion", aviso.TipoAveriaId);
            return View(aviso);
        }

        // GET: MisAvisos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aviso = await _context.Avisos
                .Include(a => a.Empleado)
                .Include(a => a.Equipo)
                .Include(a => a.TipoAveria)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aviso == null)
            {
                return NotFound();
            }

            // Para evitar el acceso a los avisos de otros empleados
            var emailUsuario = User.Identity.Name;
            var empleado = await _context.Empleados
            .Where(e => e.Email == emailUsuario)
            .FirstOrDefaultAsync();
            if (empleado == null)
            {
                return NotFound();
            }
            if (aviso.EmpleadoId != empleado.Id)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(aviso);
        }

        // POST: MisAvisos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aviso = await _context.Avisos.FindAsync(id);
            if (aviso != null)
            {
                _context.Avisos.Remove(aviso);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AvisoExists(int id)
        {
            return _context.Avisos.Any(e => e.Id == id);
        }
    }
}
