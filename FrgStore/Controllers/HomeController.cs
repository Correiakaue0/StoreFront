using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Store.Models;

namespace Store.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Carrossel()
        {
            ViewBag.Title = "Home";
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
