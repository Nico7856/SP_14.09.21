using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SP_14._09._21.Web.Data;

namespace SP_14._09._21.Web.Controllers
{
    public class GestionsController : Controller
    {
        private readonly DataContext _context;

        public GestionsController(DataContext context)
        {
            _context = context;
        }

        // GET: Gestions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Gestion_1.ToListAsync());
        }

        // GET: Gestions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gestion = await _context.Gestion_1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gestion == null)
            {
                return NotFound();
            }

            return View(gestion);
        }

        // GET: Gestions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Gestions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descipcion,Activo")] Gestion gestion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gestion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gestion);
        }

        // GET: Gestions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gestion = await _context.Gestion_1.FindAsync(id);
            if (gestion == null)
            {
                return NotFound();
            }
            return View(gestion);
        }

        // POST: Gestions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descipcion,Activo")] Gestion gestion)
        {
            if (id != gestion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gestion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GestionExists(gestion.Id))
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
            return View(gestion);
        }

        // GET: Gestions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gestion = await _context.Gestion_1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gestion == null)
            {
                return NotFound();
            }

            return View(gestion);
        }

        // POST: Gestions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gestion = await _context.Gestion_1.FindAsync(id);
            _context.Gestion_1.Remove(gestion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GestionExists(int id)
        {
            return _context.Gestion_1.Any(e => e.Id == id);
        }
    }
}
