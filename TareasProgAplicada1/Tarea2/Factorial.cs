using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgAplicada1.Tarea2
{
    class Factorial
    {
        public int num { get; set; }

        public Factorial(){}
        public int factorial(int num){
            if (num == 0 || num == 1)
                return num;
            return num * factorial(num - 1);
        }

        public void calcularFactorial(){
            Console.Write("Digite el numero: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("El factorial de " + num + " es: " + factorial(num));
        }
    }
}
