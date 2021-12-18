using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FilmLovers.Data;
using FilmLovers.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace FilmLovers.Controllers
{
    public class FilmController : Controller
    {
        private readonly ApplicationDbContext _context;
      

        public FilmController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Film
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Film.Include(f => f.Kategori);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Film/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Film
                .Include(f => f.Kategori)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        // GET: Film/Create
        public IActionResult Create() // create çağrıldığı zaman
        {
            ViewData["KategoriId"] = new SelectList(_context.Kategori, "Id", "KategorAd");
            return View();
        }

        // POST: Film/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost] // post edildiği zaman burası çalışır
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FilmAd,Yil,Uzunluk,IMDB_Puan,Oyuncular,Afis,Dil,GosterimBaslangıc,GosterimBitis,Konu,KategoriId")] Film film)
        {
            /*
            if (ModelState.IsValid)
            {
                _context.Add(film);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["KategoriId"] = new SelectList(_context.Kategori, "Id", "Id", film.KategoriId);
            return View(film);
            */
            if (ModelState.IsValid) // tüm girilen veriler uygun girilmişse model geçerlidir. bos geçilmemiş vs
            {
                //  string webRootPath = _hostingEnvironment.WebRootPath; // proje path'i
                string webRootPath = @"C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\wwwroot";

                var files = HttpContext.Request.Form.Files; // gözat diyip seçtiğimiz resim dosyası adı files. html sayfasında da files değişkeniyle bağlanır

                string fileName = Guid.NewGuid().ToString(); // rastgele guid oluşturur bu dosya ismi oolur
                var uploads = Path.Combine(webRootPath, @"images\film"); // oluşturulan guidin kaydolacağı yer
                var extension = Path.GetExtension(files[0].FileName); // uzantı, seçilen dosya uzantısı

                using (var fileStream = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                film.Afis = @"images\film\" + fileName + extension; //

                _context.Add(film);
                await _context.SaveChangesAsync(); //veri tabanına kayıt
                return RedirectToAction(nameof(Index));
            }
            // kayıt olması için html sayfasında ilgili yere entype eklendi
            // model geçerli değilse kaydetmez, return view'e döner

            ViewData["KategoriId"] = new SelectList(_context.Kategori, "Id", "Id", film.KategoriId);
            return View(film);
        }

        // GET: Film/Edit/5
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
            ViewData["KategoriId"] = new SelectList(_context.Kategori, "Id", "Id", film.KategoriId);
            return View(film);
        }

        // POST: Film/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FilmAd,Yil,Uzunluk,IMDB_Puan,Oyuncular,Afis,Dil,GosterimBaslangıc,GosterimBitis,Konu,KategoriId")] Film film)
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
            ViewData["KategoriId"] = new SelectList(_context.Kategori, "Id", "Id", film.KategoriId);
            return View(film);
        }

        // GET: Film/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Film
                .Include(f => f.Kategori)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        // POST: Film/Delete/5
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
