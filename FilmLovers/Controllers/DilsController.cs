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
    public class DilsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DilsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Dils
        public async Task<IActionResult> Index()
        {
            return View(await _context.Dil.ToListAsync());
        }

        // GET: Dils/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dil = await _context.Dil
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dil == null)
            {
                return NotFound();
            }

            return View(dil);
        }

        // GET: Dils/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dils/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DilAd")] Dil dil)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dil);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dil);
        }

        // GET: Dils/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dil = await _context.Dil.FindAsync(id);
            if (dil == null)
            {
                return NotFound();
            }
            return View(dil);
        }

        // POST: Dils/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DilAd")] Dil dil)
        {
            if (id != dil.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dil);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DilExists(dil.Id))
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
            return View(dil);
        }

        // GET: Dils/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dil = await _context.Dil
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dil == null)
            {
                return NotFound();
            }

            return View(dil);
        }

        // POST: Dils/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dil = await _context.Dil.FindAsync(id);
            _context.Dil.Remove(dil);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DilExists(int id)
        {
            return _context.Dil.Any(e => e.Id == id);
        }
    }
}
