using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgAplicada1.Tarea2
{
    class OrdenarCadenas
    {
        private string cadena, cadena2;
        private int comparar;

        public OrdenarCadenas() { }
        public void ordenar()
        {
            Console.Write("Escriba la cadena 1: ");
            cadena = Console.ReadLine();
            Console.Write("Escriba la cadena 2: ");
            cadena2 = Console.ReadLine();

            comparar = String.Compare(cadena, cadena2);

            if (comparar < 0)
            {
                Console.WriteLine("\n" + cadena + "\n" + cadena2);
            }
            else
            {
                Console.WriteLine("\n" + cadena2 + "\n" + cadena);
            }
        }
    }
}
