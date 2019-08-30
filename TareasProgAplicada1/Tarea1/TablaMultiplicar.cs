using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgAplicada1.Tarea1
{
    class TablaMultiplicar
    {
        private int num;
        public TablaMultiplicar() { }
        public void mostrarTabla()
        {
            Console.Write("Digite el numero: ");
            num = int.Parse(Console.ReadLine());

            for(int i=1; i<11; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + num * i);
            }
        }
    }
}
