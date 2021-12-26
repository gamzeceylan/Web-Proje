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
    public class FilmElestriController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FilmElestriController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FilmElestri
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.FilmElestri.Include(f => f.Film).Include(f => f.Yazar);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: FilmElestri/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filmElestri = await _context.FilmElestri
                .Include(f => f.Film)
                .Include(f => f.Yazar)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (filmElestri == null)
            {
                return NotFound();
            }

            return View(filmElestri);
        }

        // GET: FilmElestri/Create
        public IActionResult Create()
        {
            ViewData["FilmId"] = new SelectList(_context.Film, "Id", "FilmAd");
            ViewData["YazarId"] = new SelectList(_context.Yazar, "Id", "KullaniciAdi");
            return View();
        }

        // POST: FilmElestri/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FilmId,YazarId,Yazi,YazarPuan")] FilmElestri filmElestri)
        {
            if (ModelState.IsValid)
            {
                _context.Add(filmElestri);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FilmId"] = new SelectList(_context.Film, "Id", "FilmAd", filmElestri.FilmId);
            ViewData["YazarId"] = new SelectList(_context.Yazar, "Id", "KullaniciAdi", filmElestri.YazarId);
            return View(filmElestri);
        }

        // GET: FilmElestri/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filmElestri = await _context.FilmElestri.FindAsync(id);
            if (filmElestri == null)
            {
                return NotFound();
            }
            ViewData["FilmId"] = new SelectList(_context.Film, "Id", "FilmAd", filmElestri.FilmId);
            ViewData["YazarId"] = new SelectList(_context.Yazar, "Id", "KullaniciAdi", filmElestri.YazarId);
            return View(filmElestri);
        }

        // POST: FilmElestri/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FilmId,YazarId,Yazi,YazarPuan")] FilmElestri filmElestri)
        {
            if (id != filmElestri.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(filmElestri);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilmElestriExists(filmElestri.Id))
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
            ViewData["FilmId"] = new SelectList(_context.Film, "Id", "FilmAd", filmElestri.FilmId);
            ViewData["YazarId"] = new SelectList(_context.Yazar, "Id", "KullaniciAdi", filmElestri.YazarId);
            return View(filmElestri);
        }

        // GET: FilmElestri/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filmElestri = await _context.FilmElestri
                .Include(f => f.Film)
                .Include(f => f.Yazar)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (filmElestri == null)
            {
                return NotFound();
            }

            return View(filmElestri);
        }

        // POST: FilmElestri/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var filmElestri = await _context.FilmElestri.FindAsync(id);
            _context.FilmElestri.Remove(filmElestri);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FilmElestriExists(int id)
        {
            return _context.FilmElestri.Any(e => e.Id == id);
        }

        public IActionResult IcerikSayfasi(int id)
        {
            var filmElestri = _context.FilmElestri
                 .Include(d => d.Film)
                .Include(d => d.Yazar)
                .Where(d => d.FilmId == id)
                .Select(d => d);
           
            return View(filmElestri);
        }

 
    }
}
