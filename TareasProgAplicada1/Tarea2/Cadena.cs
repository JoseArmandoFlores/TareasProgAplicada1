using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgAplicada1.Tarea2
{
    class Cadena
    {
        public int num { get; set; }
        public Cadena() { }
        public void cadena(){
            Console.Write("Digite un numero entero del 0 al 9: ");
            num = int.Parse(Console.ReadLine());

            switch (num){
                case 0:
                    Console.WriteLine("Cero");
                    break;
                case 1:
                    Console.WriteLine("Uno");
                    break;
                case 2:
                    Console.WriteLine("Dos");
                    break;
                case 3:
                    Console.WriteLine("Tres");
                    break;
                case 4:
                    Console.WriteLine("Cuatro");
                    break;
                case 5:
                    Console.WriteLine("Cinco");
                    break;
                case 6:
                    Console.WriteLine("Seis");
                    break;
                case 7:
                    Console.WriteLine("Siete");
                    break;
                case 8:
                    Console.WriteLine("Ocho");
                    break;
                case 9:
                    Console.WriteLine("Nueve");
                    break;
                default:
                    Console.WriteLine("Este numero no esta comprendido entre 0 y 9.");
                    break;
            }
        }
    }
}
