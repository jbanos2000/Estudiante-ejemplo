using System;
using System.ComponentModel.DataAnnotations;

namespace mvc_lab.Models
{
    public class Calculadora
    {
        public int Operador1 { get; set; }

        public int Operador2 { get; set; }

        public String Accion { get; set; }

        [Display(Name="Output")]
        public int Respuesta { get; set; }
    }
}
