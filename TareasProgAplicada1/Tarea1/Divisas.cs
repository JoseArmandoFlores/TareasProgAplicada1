using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgAplicada1.Tarea1
{
    class Divisas
    {
        private double dolar, euro, dolares, euros;
        private int opcion;
        public Divisas(){}
        public void convertirDolares()
        {
            Console.Write("Digite la cantidad de dolares a convertir: ");
            dolar = float.Parse(Console.ReadLine());
            euros = dolar * 0.90;
            Console.WriteLine(dolar + "USD = " + euros + "Euros");
        }

        public void convertirEuros()
        {
            Console.Write("Digite la cantidad de euros a convertir: ");
            euro = float.Parse(Console.ReadLine());
            dolares = euro*1.11;
            Console.WriteLine(euro + "Euros = " + dolares + "USD");
        }
        public void convertir()
        {
            Console.Clear();
            Console.WriteLine("1.Convertir de Dolares a Euros\n2.Convertir de Euros a Dolares");

            Console.Write("\nEscriba el numero del programa que desea ejecutar: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    convertirDolares();
                    break;
                case 2:
                    Console.Clear();
                    convertirEuros();
                    break;
            }
        }
    }
}
