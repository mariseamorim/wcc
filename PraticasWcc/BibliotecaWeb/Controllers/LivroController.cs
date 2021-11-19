using BibliotecaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace BibliotecaWeb.Controllers
{
    public class LivroController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public LivroController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Livro()
        {
            //var listaDeLivros = new Livro(" Código Limpo ", " Livro sobre tecnologia ", 6.50, new Autor(" Robert Cecil Martin "), Genero.F).ListaDeLivro; ;
            var livro = new Livro();
            var listaDeLivros = livro.GetLivros();
            return View(listaDeLivros);
        }
      
    }
}
