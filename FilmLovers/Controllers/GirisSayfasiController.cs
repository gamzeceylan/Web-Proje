﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLovers.Controllers
{
    public class GirisSayfasiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
