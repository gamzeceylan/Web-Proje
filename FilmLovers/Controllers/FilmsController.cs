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
    public class FilmsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FilmsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Films
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Film.Include(f => f.Dil).Include(f => f.Kategori).Include(f => f.Yazar);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Films/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Film
                .Include(f => f.Dil)
                .Include(f => f.Kategori)
                .Include(f => f.Yazar)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        // GET: Films/Create
        public IActionResult Create()
        {
            ViewData["DilId"] = new SelectList(_context.Dil, "Id", "Id");
            ViewData["KategoriId"] = new SelectList(_context.Kategori, "Id", "Id");
            ViewData["YazarId"] = new SelectList(_context.Yazar, "Id", "Id");
            return View();
        }

        // POST: Films/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FilmAd,Yil,Uzunluk,IMDB_Puan,Oyuncular,GosterimBaslangıc,GosterimBitis,Konu,YazarPuan,KategoriId,DilId,YazarId")] Film film)
        {
            if (ModelState.IsValid)
            {
                _context.Add(film);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DilId"] = new SelectList(_context.Dil, "Id", "Id", film.DilId);
            ViewData["KategoriId"] = new SelectList(_context.Kategori, "Id", "Id", film.KategoriId);
            ViewData["YazarId"] = new SelectList(_context.Yazar, "Id", "Id", film.YazarId);
            return View(film);
        }

        // GET: Films/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Film.FindAsync(id);
            if (film == null)
            {
                return NotFound();
            }
            ViewData["DilId"] = new SelectList(_context.Dil, "Id", "Id", film.DilId);
            ViewData["KategoriId"] = new SelectList(_context.Kategori, "Id", "Id", film.KategoriId);
            ViewData["YazarId"] = new SelectList(_context.Yazar, "Id", "Id", film.YazarId);
            return View(film);
        }

        // POST: Films/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FilmAd,Yil,Uzunluk,IMDB_Puan,Oyuncular,GosterimBaslangıc,GosterimBitis,Konu,YazarPuan,KategoriId,DilId,YazarId")] Film film)
        {
            if (id != film.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(film);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilmExists(film.Id))
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
            ViewData["DilId"] = new SelectList(_context.Dil, "Id", "Id", film.DilId);
            ViewData["KategoriId"] = new SelectList(_context.Kategori, "Id", "Id", film.KategoriId);
            ViewData["YazarId"] = new SelectList(_context.Yazar, "Id", "Id", film.YazarId);
            return View(film);
        }

        // GET: Films/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Film
                .Include(f => f.Dil)
                .Include(f => f.Kategori)
                .Include(f => f.Yazar)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        // POST: Films/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var film = await _context.Film.FindAsync(id);
            _context.Film.Remove(film);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FilmExists(int id)
        {
            return _context.Film.Any(e => e.Id == id);
        }
    }
}
