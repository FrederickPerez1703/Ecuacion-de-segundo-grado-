using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EcuaciondeSegundogrado.Controllers
{
    public class calcularController : Controller
    {
        public IActionResult Index(double Numero1, double Numero2, double Numero3)
        {
            double resultado1, resultado2, M;
            M = Math.Pow(Numero1, Numero2);
            resultado1 = (-Numero2 + (Math.Sqrt(M - 4 * Numero1 * Numero3))) / ( 2 * Numero1);
            resultado2 = (-Numero2 - (Math.Sqrt(M - 4 * Numero1 * Numero3))) /(2 * Numero1);

            ViewBag.resulfinal1 = resultado1;
            ViewBag.resulfinal2 = resultado2;
            return View();
        }
       
    }
}