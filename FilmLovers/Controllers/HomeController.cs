using FilmLovers.Data;
using FilmLovers.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLovers.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context; // veri tabanı nesnesi

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // filmleri anasayfaya çekmek için
        public IActionResult Index()
        {

            var filmList = _context.Film
                .Include(f => f.Kategori);
      
                 return View(filmList); // html sayfasına yollladık
        
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

      //  [Authorize(Roles ="Admin")]
        public IActionResult AdminSayfasi()
        {
            return View();
        }

   
    
        /*
        [Authorize] // sadece login olanlar erişebilir
        public IActionResult IcerikSayfasi()
        {
            
            if (id == null)
            {
                return NotFound();
            }

            var diziElestri = _context.DiziElestri
                .Include(d => d.Dizi)
                .Include(d => d.Yazar)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (diziElestri == null)
            {
                return NotFound();
            }

            
            return View();


        }
  
    */
    }
}
