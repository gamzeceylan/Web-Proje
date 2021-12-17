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
    public class DiziController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DiziController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Dizi
        public async Task<IActionResult> Index()
        {
            return View(await _context.Dizi.ToListAsync());
        }

        // GET: Dizi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dizi = await _context.Dizi
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dizi == null)
            {
                return NotFound();
            }

            return View(dizi);
        }

        // GET: Dizi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dizi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DiziAd,Yil,Konu,Oyuncular,Resim,Dil,SezonSayisi,ToplamBolumSayisi")] Dizi dizi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dizi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dizi);
        }

        // GET: Dizi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dizi = await _context.Dizi.FindAsync(id);
            if (dizi == null)
            {
                return NotFound();
            }
            return View(dizi);
        }

        // POST: Dizi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DiziAd,Yil,Konu,Oyuncular,Resim,Dil,SezonSayisi,ToplamBolumSayisi")] Dizi dizi)
        {
            if (id != dizi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dizi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiziExists(dizi.Id))
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
            return View(dizi);
        }

        // GET: Dizi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dizi = await _context.Dizi
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dizi == null)
            {
                return NotFound();
            }

            return View(dizi);
        }

        // POST: Dizi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dizi = await _context.Dizi.FindAsync(id);
            _context.Dizi.Remove(dizi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiziExists(int id)
        {
            return _context.Dizi.Any(e => e.Id == id);
        }
    }
}
