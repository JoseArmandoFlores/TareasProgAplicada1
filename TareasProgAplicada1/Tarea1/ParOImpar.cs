using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgAplicada1.Tarea1
{
    class ParOImpar
    {
        private int num;
        public ParOImpar(){}
        public void esParOImpar()
        {
            Console.Write("Digite el numero: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("Es par");
            else
                Console.WriteLine("Es impar");
        }

    }
}
