using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyDemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyDemoMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var filme = new Filme()
            {
                Titulo = "iu",
                Datalancamento = DateTime.Now,
                Avaliacao = 50,
                Valor = 100
            };
            return RedirectToAction("Privacy", filme);
        }

        public IActionResult Privacy(Filme filme)
        {

            if(ModelState.IsValid)
            {

            }

            foreach(var error in ModelState.Values.SelectMany(m=>m.Errors))
            {
                Console.WriteLine(error.ErrorMessage);
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("erro-encontrado")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
