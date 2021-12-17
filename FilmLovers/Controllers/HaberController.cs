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
    public class HaberController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HaberController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Haber
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Haber.Include(h => h.Yazar);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Haber/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var haber = await _context.Haber
                .Include(h => h.Yazar)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (haber == null)
            {
                return NotFound();
            }

            return View(haber);
        }

        // GET: Haber/Create
        public IActionResult Create()
        {
            ViewData["YazarId"] = new SelectList(_context.Yazar, "Id", "KullaniciAdi");
            return View();
        }

        // POST: Haber/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Baslik,Resim,YazarId,Icerik")] Haber haber)
        {
            if (ModelState.IsValid)
            {
                _context.Add(haber);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["YazarId"] = new SelectList(_context.Yazar, "Id", "KullaniciAdi", haber.YazarId);
            return View(haber);
        }

        // GET: Haber/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var haber = await _context.Haber.FindAsync(id);
            if (haber == null)
            {
                return NotFound();
            }
            ViewData["YazarId"] = new SelectList(_context.Yazar, "Id", "KullaniciAdi", haber.YazarId);
            return View(haber);
        }

        // POST: Haber/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Baslik,Resim,YazarId,Icerik")] Haber haber)
        {
            if (id != haber.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(haber);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HaberExists(haber.Id))
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
            ViewData["YazarId"] = new SelectList(_context.Yazar, "Id", "KullaniciAdi", haber.YazarId);
            return View(haber);
        }

        // GET: Haber/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var haber = await _context.Haber
                .Include(h => h.Yazar)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (haber == null)
            {
                return NotFound();
            }

            return View(haber);
        }

        // POST: Haber/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var haber = await _context.Haber.FindAsync(id);
            _context.Haber.Remove(haber);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HaberExists(int id)
        {
            return _context.Haber.Any(e => e.Id == id);
        }
    }
}
