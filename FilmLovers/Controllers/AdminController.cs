using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FilmLovers.Data;
using FilmLovers.Models;
using Microsoft.AspNetCore.Authorization;

namespace FilmLovers.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin
        [Authorize(Roles = "Admin")] // adminse girer
        public async Task<IActionResult> Index()
        {
            return View(await _context.Admin.ToListAsync());
        }

      
    }
}
