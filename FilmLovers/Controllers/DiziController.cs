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

            if (ModelState.IsValid) // tüm girilen veriler uygun girilmişse model geçerlidir. bos geçilmemiş vs
            {
                //  string webRootPath = _hostingEnvironment.WebRootPath; // proje path'i
                string webRootPath = @"C:\Users\cceyl\Documents\GitHub\Web-Proje\FilmLovers\wwwroot";

                var files = HttpContext.Request.Form.Files; // gözat diyip seçtiğimiz resim dosyası adı files. html sayfasında da files değişkeniyle bağlanır

                string fileName = Guid.NewGuid().ToString(); // rastgele guid oluşturur bu dosya ismi oolur
                var uploads = Path.Combine(webRootPath, @"images\dizi"); // oluşturulan guidin kaydolacağı yer
                var extension = Path.GetExtension(files[0].FileName); // uzantı, seçilen dosya uzantısı

                using (var fileStream = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                dizi.Resim = @"images\dizi\" + fileName + extension; //

                _context.Add(dizi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            // kayıt olması için html sayfasında ilgili yere entype eklendi
            // model geçerli değilse kaydetmez, return view'e döner

            
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
