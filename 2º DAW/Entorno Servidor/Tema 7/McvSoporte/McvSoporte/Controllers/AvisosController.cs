using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using McvSoporte.Data;
using McvSoporte.Models;

namespace McvSoporte.Controllers
{
    public class AvisosController : Controller
    {
        private readonly McvSoporteContexto _context;

        public AvisosController(McvSoporteContexto context)
        {
            _context = context;
        }

        // GET: Avisos
        public async Task<IActionResult> Index(string strCadenaBusqueda, string busquedaActual, int? intTipoAveriaId, int? tipoAveriaIdActual, int? pageNumber)
        {
            if (strCadenaBusqueda != null)
            {
                pageNumber = 1;
            }
            else
            {
                strCadenaBusqueda = busquedaActual;
            }
            ViewData["BusquedaActual"] = strCadenaBusqueda;

            if (intTipoAveriaId != null)
            {
                pageNumber = 1;
            }
            else
            {
                intTipoAveriaId = tipoAveriaIdActual;
            }
            ViewData["TipoAveriaIdActual"] = intTipoAveriaId;

            // Cargar datos de los avisos
            var avisos = _context.Avisos.AsQueryable();

            // Ordenar los avisos de forma descendente por FechaAviso
            avisos = avisos.OrderByDescending(s => s.FechaAviso);

            if (!String.IsNullOrEmpty(strCadenaBusqueda))
            {
                avisos = avisos.Where(s => s.Empleado.Nombre.Contains(strCadenaBusqueda));
            }

            // Para filtrar avisos por tipo de avería
            if (intTipoAveriaId == null)
            {
                ViewData["TipoAveriaId"] = new SelectList(_context.TipoAverias, "Id",
                "Descripcion");
            }
            else
            {
                ViewData["TipoAveriaId"] = new SelectList(_context.TipoAverias, "Id",
                "Descripcion", intTipoAveriaId);
                avisos = avisos.Where(x => x.TipoAveriaId == intTipoAveriaId);
            }

            avisos = avisos.Include(a => a.Empleado)
                           .Include(a => a.Equipo)
                           .Include(a => a.TipoAveria);
            int pageSize = 3;
            return View(await PaginatedList<Aviso>.CreateAsync(avisos.AsNoTracking(), pageNumber ?? 1, pageSize));

            // return View(await avisos.AsNoTracking().ToListAsync());

            // var mvcSoporteContexto = _context.Avisos.Include(a => a.Empleado).Include(a => a.Equipo).Include(a => a.TipoAveria);
            // return View(await mvcSoporteContexto.ToListAsync());
        }

        // GET: Avisos/Details/5
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

            return View(aviso);
        }

        // GET: Avisos/Create
        public IActionResult Create()
        {
            ViewData["EmpleadoId"] = new SelectList(_context.Empleados, "Id", "Nombre");
            ViewData["EquipoId"] = new SelectList(_context.Equipos, "Id", "CodigoEquipo");
            ViewData["TipoAveriaId"] = new SelectList(_context.TipoAverias, "Id", "Descripcion");
            return View();
        }

        // POST: Avisos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descripcion,FechaAviso,FechaCierre,Observaciones,EmpleadoId,TipoAveriaId,EquipoId")] Aviso aviso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aviso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmpleadoId"] = new SelectList(_context.Empleados, "Id", "Nombre", aviso.EmpleadoId);
            ViewData["EquipoId"] = new SelectList(_context.Equipos, "Id", "CodigoEquipo", aviso.EquipoId);
            ViewData["TipoAveriaId"] = new SelectList(_context.TipoAverias, "Id", "Descripcion", aviso.TipoAveriaId);
            return View(aviso);
        }

        // GET: Avisos/Edit/5
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
            ViewData["EmpleadoId"] = new SelectList(_context.Empleados, "Id", "Nombre", aviso.EmpleadoId);
            ViewData["EquipoId"] = new SelectList(_context.Equipos, "Id", "CodigoEquipo", aviso.EquipoId);
            ViewData["TipoAveriaId"] = new SelectList(_context.TipoAverias, "Id", "Descripcion", aviso.TipoAveriaId);
            return View(aviso);
        }

        // POST: Avisos/Edit/5
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

        // GET: Avisos/Delete/5
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

            return View(aviso);
        }

        // POST: Avisos/Delete/5
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
