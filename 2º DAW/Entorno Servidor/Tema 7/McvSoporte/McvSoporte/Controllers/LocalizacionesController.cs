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
    public class LocalizacionesController : Controller
    {
        private readonly McvSoporteContexto _context;

        public LocalizacionesController(McvSoporteContexto context)
        {
            _context = context;
        }

        // GET: Localizaciones
        public async Task<IActionResult> Index()
        {
            return View(await _context.Localizaciones.ToListAsync());
        }

        // GET: Localizaciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var localizacion = await _context.Localizaciones
                .FirstOrDefaultAsync(m => m.Id == id);
            if (localizacion == null)
            {
                return NotFound();
            }

            return View(localizacion);
        }

        // GET: Localizaciones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Localizaciones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descripcion")] Localizacion localizacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(localizacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(localizacion);
        }

        // GET: Localizaciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var localizacion = await _context.Localizaciones.FindAsync(id);
            if (localizacion == null)
            {
                return NotFound();
            }
            return View(localizacion);
        }

        // POST: Localizaciones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descripcion")] Localizacion localizacion)
        {
            if (id != localizacion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(localizacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocalizacionExists(localizacion.Id))
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
            return View(localizacion);
        }

        // GET: Localizaciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var localizacion = await _context.Localizaciones
                .FirstOrDefaultAsync(m => m.Id == id);
            if (localizacion == null)
            {
                return NotFound();
            }

            return View(localizacion);
        }

        // POST: Localizaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var localizacion = await _context.Localizaciones.FindAsync(id);
            if (localizacion != null)
            {
                _context.Localizaciones.Remove(localizacion);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocalizacionExists(int id)
        {
            return _context.Localizaciones.Any(e => e.Id == id);
        }
    }
}
