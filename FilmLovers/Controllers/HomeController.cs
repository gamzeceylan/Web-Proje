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
            /*    // veri tabanından dil ve kategoriler çağrılıyor
                // dil ve kategori FK
            // film tablosu çağrılır
            // fk larıyla birlikçe çağırıyoruz
                var filmList = _context.Film
                    .Include(f => f.Dil)
                    .Include(f => f.Kategori);

                return View(filmList.ToList()); // html sayfasına yollladık
    */    // film tablosu çağrılır
          // fk larıyla birlikçe çağırıyoruz
            var filmList = _context.Film
                .Include(f => f.Kategori);

            return View(filmList.ToList()); // html sayfasına yollladık
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

     //   [Authorize]
     // anlamadım?
        public IActionResult Admin()
        {
            return View();
        }
    }
}
