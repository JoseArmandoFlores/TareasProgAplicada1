using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgAplicada1.Tarea1
{
    class Grados
    {
        private double celsius, fahrenheit;
        public Grados(){}
        public void convertir()
        {
            Console.Write("Digite la cantidad de grados celsius: ");
            celsius = float.Parse(Console.ReadLine());
            fahrenheit = (celsius * 1.8) + 32;
            Console.Write(celsius + "° Celsius = " + fahrenheit + "° Fahrenheit");
        }
    }
}
