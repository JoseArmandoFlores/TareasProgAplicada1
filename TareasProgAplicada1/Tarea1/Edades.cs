using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgAplicada1.Tarea1
{
    class Edades
    {
        private float cantidad, edad, mayor=0, menor=999, edades=0, promedio = 0;
        public Edades() { }
        public void calcularPromedio()
        {
            Console.Write("Digite la cantidad de personas: ");
            cantidad = int.Parse(Console.ReadLine());

            for(int i=0; i<cantidad; i++)
            {
                Console.Write("Digite la edad de la persona " + (i+1) + ": ");
                edad = int.Parse(Console.ReadLine());
                edades += edad;
                if (edad > mayor)
                    mayor = edad;
                if (edad < menor)
                    menor = edad;
            }
            promedio = edades/cantidad;
            Console.WriteLine("\nEl promedio de edades es: " + promedio);
            Console.WriteLine("La edad de la persona mas grande es: " + mayor);
            Console.WriteLine("La edad de la persona mas joven es: " + menor);
        }
    }
}
