using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using practica12.Models;

namespace Practica12._12.Controllers
{
    public class AreaController:Controller
    {
        private readonly ILogger<AreaController> _logger;

        public AreaController(ILogger<AreaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }        

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index( double Base, double Altura,string numero1, string numero2, string tipos)

        {
            Base=Convert.ToDouble(numero1);
            Altura=Convert.ToDouble(numero2);
            double c=0;
            if(tipos=="Triangulo")
            {
                c= Base*Altura/2;
                ViewBag.Resultado =c;
            }
            else{
                ViewBag.Resultado = c;
            }
            if(tipos=="Rectangulo")
            {
                c=Base*Altura;
                ViewBag.Resultado =c;
            }
          return View();
        }
    }
    }