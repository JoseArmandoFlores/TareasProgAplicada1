using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgAplicada1.Tarea1
{
    class Area
    {
        Perimetro p = new Perimetro();

        private int lados;
        private double apotema, longitud, area;
        public Area() { }
        public void calcularArea()
        {
            Console.Write("Digite la cantidad de lados del poligono: ");
            lados = int.Parse(Console.ReadLine());
            Console.Write("Digite la longitud de cada lado: ");
            longitud = double.Parse(Console.ReadLine());
            Console.Write("Digite la longitud del apotema: ");
            apotema = double.Parse(Console.ReadLine());

            area = (lados * longitud * apotema) / 2;
            Console.WriteLine("El area es: " + area);
        }

        public void calcularAreaOPerimetro()
        {
            int opcion;
            Console.WriteLine("1.Calcular Perimetro\n2.Calcular Area");
            Console.Write("\nEscriba el numero del programa que desea ejecutar: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    p.calcularPerimetro();
                    break;
                case 2:
                    Console.Clear();
                    calcularArea();
                    break;
            }
        }
    }
}
