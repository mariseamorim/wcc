using BibliotecaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaWeb.Controllers
{
    public class AutorController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public AutorController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Autor()
        {
            return View();
        }

      
    }
}
