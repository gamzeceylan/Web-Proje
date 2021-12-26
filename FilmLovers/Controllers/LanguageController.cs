using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLovers.Controllers
{
    
    public class LanguageController : Controller
    {
        public IActionResult Change(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)), new
                CookieOptions
                { Expires = DateTimeOffset.UtcNow.AddMonths(1) });
            return RedirectToAction("Index", "Home");
        }
    }
}
