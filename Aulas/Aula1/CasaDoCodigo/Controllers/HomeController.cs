using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CasaDoCodigo.Models;

namespace CasaDoCodigo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Carrossel()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }
        //DAQUI PRA BAIXO NAO IMPORTA

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
