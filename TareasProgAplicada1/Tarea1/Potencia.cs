using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgAplicada1.Tarea1
{
    class Potencia
    {
        private float basee, exponente, potencia=1;
        public Potencia() { }
        public void elevar()
        {
            Console.Write("Digite la base: ");
            basee = float.Parse(Console.ReadLine());
            Console.Write("Digite el exponente: ");
            exponente = float.Parse(Console.ReadLine());

            for(int i=0; i<exponente; i++)
            {
                potencia *= basee;
            }

            Console.WriteLine("El numero " + basee + " elevado a la potencia " + exponente + " es igual a: " + potencia);
        }
    }
}
