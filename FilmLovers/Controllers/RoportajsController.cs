using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FilmLovers.Data;
using FilmLovers.Models;

namespace FilmLovers.Controllers
{
    public class RoportajsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RoportajsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Roportajs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Roportaj.Include(r => r.Yazar);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Roportajs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roportaj = await _context.Roportaj
                .Include(r => r.Yazar)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roportaj == null)
            {
                return NotFound();
            }

            return View(roportaj);
        }

        // GET: Roportajs/Create
        public IActionResult Create()
        {
            ViewData["YazarId"] = new SelectList(_context.Yazar, "Id", "Id");
            return View();
        }

        // POST: Roportajs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Baslik,Konusmaci,YazarId")] Roportaj roportaj)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roportaj);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["YazarId"] = new SelectList(_context.Yazar, "Id", "Id", roportaj.YazarId);
            return View(roportaj);
        }

        // GET: Roportajs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roportaj = await _context.Roportaj.FindAsync(id);
            if (roportaj == null)
            {
                return NotFound();
            }
            ViewData["YazarId"] = new SelectList(_context.Yazar, "Id", "Id", roportaj.YazarId);
            return View(roportaj);
        }

        // POST: Roportajs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Baslik,Konusmaci,YazarId")] Roportaj roportaj)
        {
            if (id != roportaj.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roportaj);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoportajExists(roportaj.Id))
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
            ViewData["YazarId"] = new SelectList(_context.Yazar, "Id", "Id", roportaj.YazarId);
            return View(roportaj);
        }

        // GET: Roportajs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roportaj = await _context.Roportaj
                .Include(r => r.Yazar)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roportaj == null)
            {
                return NotFound();
            }

            return View(roportaj);
        }

        // POST: Roportajs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roportaj = await _context.Roportaj.FindAsync(id);
            _context.Roportaj.Remove(roportaj);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoportajExists(int id)
        {
            return _context.Roportaj.Any(e => e.Id == id);
        }
    }
}
