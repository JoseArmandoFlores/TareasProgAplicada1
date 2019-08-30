using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgAplicada1.Tarea1
{
    class Perimetro
    {
        private int lados;
        private float longitud, perimetro=0;
        public Perimetro(){}
        public void calcularPerimetro(){
            Console.Write("Digite la cantidad de lados del poligono: ");
            lados = int.Parse(Console.ReadLine());
            Console.Write("Digite la longitud de cada lado: ");
            longitud = float.Parse(Console.ReadLine());

            perimetro = lados * longitud;
            Console.WriteLine("El perimetro es: " + perimetro);
        }
    }
}
