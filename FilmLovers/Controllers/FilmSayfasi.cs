using FilmLovers.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLovers.Controllers
{
    public class FilmSayfasi : Controller
    {
        private readonly ApplicationDbContext _context; // veri tabanı nesnesi

        public FilmSayfasi(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // film tablosu çağrılır
            // fk larıyla birlikçe çağırıyoruz
            var filmList = _context.Film
                .Include(f => f.Kategori);

            return View(filmList.ToList()); // html sayfasına yollladık
        }
    }
}
