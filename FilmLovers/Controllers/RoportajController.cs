using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FilmLovers.Data;
using FilmLovers.Models;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace FilmLovers.Controllers
{
    public class RoportajController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RoportajController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Roportaj
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Roportaj.Include(r => r.Yazar);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Roportaj/Details/5
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

        // GET: Roportaj/Create
        public IActionResult Create()
        {
            ViewData["YazarId"] = new SelectList(_context.Yazar, "Id", "KullaniciAdi");
            return View();

        }

        // POST: Roportaj/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Baslik,Konu,Resim,Konusmaci,YazarId,Yazi")] Roportaj roportaj)
        {
      
            if (ModelState.IsValid) // tüm girilen veriler uygun girilmişse model geçerlidir. bos geçilmemiş vs
            {
                //  string webRootPath = _hostingEnvironment.WebRootPath; // proje path'i
                string webRootPath = @"C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\wwwroot";

                var files = HttpContext.Request.Form.Files; // gözat diyip seçtiğimiz resim dosyası adı files. html sayfasında da files değişkeniyle bağlanır

                string fileName = Guid.NewGuid().ToString(); // rastgele guid oluşturur bu dosya ismi oolur
                var uploads = Path.Combine(webRootPath, @"images\roportaj"); // oluşturulan guidin kaydolacağı yer
                var extension = Path.GetExtension(files[0].FileName); // uzantı, seçilen dosya uzantısı

                using (var fileStream = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                roportaj.Resim = @"images\roportaj\" + fileName + extension; //

                _context.Add(roportaj);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            // kayıt olması için html sayfasında ilgili yere entype eklendi
            // model geçerli değilse kaydetmez, return view'e döner

            ViewData["YazarId"] = new SelectList(_context.Yazar, "Id", "KullaniciAdi", roportaj.YazarId);
            return View(roportaj);


        }

        // GET: Roportaj/Edit/5
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
            ViewData["YazarId"] = new SelectList(_context.Yazar, "Id", "KullaniciAdi", roportaj.YazarId);
            return View(roportaj);
        }

        // POST: Roportaj/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Baslik,Konu,Resim,Konusmaci,YazarId,Yazi")] Roportaj roportaj)
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
            ViewData["YazarId"] = new SelectList(_context.Yazar, "Id", "KullaniciAdi", roportaj.YazarId);
            return View(roportaj);
        }

        // GET: Roportaj/Delete/5
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

        // POST: Roportaj/Delete/5
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
        public IActionResult RoportajSayfasi()
        {
            var roportaj = _context.Roportaj;
            return View(roportaj);


        }

        [Authorize]
        public IActionResult IcerikSayfasi(int id)
        {
            var roportaj = _context.Roportaj
                .Include(d => d.Yazar)
                .Where(d => d.Id == id)
                .Select(d => d);
            int k = id;
            return View(roportaj);
        }
    }
}
