using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgAplicada1.Tarea2
{
    class Colegio
    {
        private int cantidadSalones, cantidadAlumnos, x, y;
        private float menorCalificacion=9999, mayorCalificacion=0, acumulador = 0, promedio;

        public Colegio(){}

        public void correr()
        {
            x = 0; y = 0;
            Console.Write("Digite la cantidad de salones: ");
            cantidadSalones = int.Parse(Console.ReadLine());

            float[][] calificaciones = new float[cantidadSalones][];

            for(x=0; x < cantidadSalones; x++)
            {
                Console.Write("Digite la cantidad de alumnos del salon [" + (x + 1) + "]: ");
                cantidadAlumnos = int.Parse(Console.ReadLine());

                calificaciones[x] = new float[cantidadAlumnos];
            }

            for (x = 0; x < cantidadSalones; x++)
            {

                Console.WriteLine("Salon [" + (x + 1) + "]");
                for(y=0; y<calificaciones[x].GetLength(0); y++)
                {
                    Console.Write("Digite la calificacion del estudiante [" + (y + 1) + "]: ");
                    calificaciones[x][y] = float.Parse(Console.ReadLine());
                    if (calificaciones[x][y] > mayorCalificacion)
                        mayorCalificacion = calificaciones[x][y];
                    if (calificaciones[x][y] < menorCalificacion)
                        menorCalificacion = calificaciones[x][y];
                }
            }

            Console.WriteLine("\t\tImpresion de datos");
            for(x=0; x<cantidadSalones; x++)
            {
                Console.WriteLine("Salon [" + (x + 1) + "]");
                for(y=0; y<calificaciones[x].GetLength(0); y++)
                    Console.WriteLine("Calificacion del alumno [" + (y + 1) + "]: " + calificaciones[x][y]);
                Console.WriteLine("\tPromedio de calificaciones: " + calcularPromedio(cantidadSalones, calificaciones, x));
                Console.WriteLine("\tCalificacion maxima: " + mayorCalificacion);
                Console.WriteLine("\tCalificacion minima: " + menorCalificacion);
            }
        }
        public float calcularPromedio(int cantidadSalones,float [][]calificaciones, int x)
        {
            acumulador = 0;
            int cantidad = calificaciones[x].GetLength(0);
            for (int y = 0; y<calificaciones[x].GetLength(0); y++)
                acumulador += calificaciones[x][y];
            promedio = acumulador / cantidad;
            return promedio;
        }
    }
    


}
