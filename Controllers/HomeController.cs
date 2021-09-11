using HealthRecord.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HealthRecord.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IStringLocalizer<HomeController> _localizer;
        public HomeController(IStringLocalizer<HomeController> localizer, ILogger<HomeController> logger)
        {
            _localizer = localizer;
            _logger = logger;
        }

       /* public HomeController(ILogger<HomeController> logger)
        {
            
        }*/

        public IActionResult Index()
        {
            return View();
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

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePatient()
        {
            if (!ModelState.IsValid) { }
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult ChangeCulture(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, $"c={culture}|uic={culture}");
            return RedirectToAction("Index");
        }

        public string Get()
        {
            return _localizer["continue"].Value;
        }
    }
}
