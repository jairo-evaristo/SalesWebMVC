using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SalesWebMCV.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMCV.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            @ViewData["name"] = "Jairo Gomes Evaristo";
            @ViewData["email"] = "jairo.fitbank.com.br";

            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["email"] = "jairo.evaristo@fitbank.com.br";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
