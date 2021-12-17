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
    public class DiziElestriController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DiziElestriController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DiziElestri
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DiziElestri.Include(d => d.Dizi).Include(d => d.Yazar);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: DiziElestri/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diziElestri = await _context.DiziElestri
                .Include(d => d.Dizi)
                .Include(d => d.Yazar)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (diziElestri == null)
            {
                return NotFound();
            }

            return View(diziElestri);
        }

        // GET: DiziElestri/Create
        public IActionResult Create()
        {
            ViewData["DiziId"] = new SelectList(_context.Dizi, "Id", "DiziAd");
            ViewData["YazarId"] = new SelectList(_context.Yazar, "Id", "KullaniciAdi");
            return View();
        }

        // POST: DiziElestri/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DiziId,YazarId,Yazi,YazarPuan")] DiziElestri diziElestri)
        {
            if (ModelState.IsValid)
            {
                _context.Add(diziElestri);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DiziId"] = new SelectList(_context.Dizi, "Id", "DiziAd", diziElestri.DiziId);
            ViewData["YazarId"] = new SelectList(_context.Yazar, "Id", "KullaniciAdi", diziElestri.YazarId);
            return View(diziElestri);
        }

        // GET: DiziElestri/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diziElestri = await _context.DiziElestri.FindAsync(id);
            if (diziElestri == null)
            {
                return NotFound();
            }
            ViewData["DiziId"] = new SelectList(_context.Dizi, "Id", "DiziAd", diziElestri.DiziId);
            ViewData["YazarId"] = new SelectList(_context.Yazar, "Id", "KullaniciAdi", diziElestri.YazarId);
            return View(diziElestri);
        }

        // POST: DiziElestri/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DiziId,YazarId,Yazi,YazarPuan")] DiziElestri diziElestri)
        {
            if (id != diziElestri.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(diziElestri);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiziElestriExists(diziElestri.Id))
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
            ViewData["DiziId"] = new SelectList(_context.Dizi, "Id", "DiziAd", diziElestri.DiziId);
            ViewData["YazarId"] = new SelectList(_context.Yazar, "Id", "KullaniciAdi", diziElestri.YazarId);
            return View(diziElestri);
        }

        // GET: DiziElestri/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diziElestri = await _context.DiziElestri
                .Include(d => d.Dizi)
                .Include(d => d.Yazar)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (diziElestri == null)
            {
                return NotFound();
            }

            return View(diziElestri);
        }

        // POST: DiziElestri/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var diziElestri = await _context.DiziElestri.FindAsync(id);
            _context.DiziElestri.Remove(diziElestri);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiziElestriExists(int id)
        {
            return _context.DiziElestri.Any(e => e.Id == id);
        }
    }
}
