﻿using Microsoft.AspNetCore.Mvc;
using MyDemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDemoMVC.Controllers
{
    public class FilmesController:Controller
    {
        [HttpGet]
        public IActionResult Adicionar() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(Filme filme)
        {
            if(ModelState.IsValid)
            {
                //
            }

            return View(filme);
        }
    }
}
