using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_lab.Models;

namespace mvc_lab.Controllers
{
    public class CalculadoraController : Controller
    {
        private readonly ILogger<CalculadoraController> _logger;

        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Calcular(Calculadora calc){
            if(calc.Accion=="+"){
                calc.Respuesta= calc.Operador1 + calc.Operador2;
            }else if(calc.Accion=="-"){
                calc.Respuesta= calc.Operador1 - calc.Operador2;
            }else if(calc.Accion=="*"){
                calc.Respuesta= calc.Operador1 * calc.Operador2;
            }else{
                calc.Respuesta= calc.Operador1 / calc.Operador2;
            }

            return View("Index",calc);
        }
    }
}