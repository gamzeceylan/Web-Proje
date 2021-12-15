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
    public class YazarsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public YazarsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Yazars
        public async Task<IActionResult> Index()
        {
            return View(await _context.Yazar.ToListAsync());
        }

        // GET: Yazars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yazar = await _context.Yazar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (yazar == null)
            {
                return NotFound();
            }

            return View(yazar);
        }

        // GET: Yazars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Yazars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ad,Soyad")] Yazar yazar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(yazar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(yazar);
        }

        // GET: Yazars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yazar = await _context.Yazar.FindAsync(id);
            if (yazar == null)
            {
                return NotFound();
            }
            return View(yazar);
        }

        // POST: Yazars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ad,Soyad")] Yazar yazar)
        {
            if (id != yazar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(yazar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!YazarExists(yazar.Id))
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
            return View(yazar);
        }

        // GET: Yazars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yazar = await _context.Yazar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (yazar == null)
            {
                return NotFound();
            }

            return View(yazar);
        }

        // POST: Yazars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var yazar = await _context.Yazar.FindAsync(id);
            _context.Yazar.Remove(yazar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool YazarExists(int id)
        {
            return _context.Yazar.Any(e => e.Id == id);
        }
    }
}
