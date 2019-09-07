using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgAplicada1.Tarea2
{
    class SalonClases
    {
        private int cantidad;
        private float mayorCalificacion = 0, menorCalificacion = 9999, acumulador = 0, promedio = 0,calificacion;
        public SalonClases() { }
        public void correr()
        {
            ArrayList lista = new ArrayList();

            Console.Write("Digite la cantidad de calificaciones: ");
            cantidad = int.Parse(Console.ReadLine());

            for (int x = 0; x < cantidad; x++)
            {
                Console.Write("Inserte calificacion [" + (x + 1)+"]: ");
                calificacion = float.Parse(Console.ReadLine());
                lista.Add(calificacion);
            }

            foreach (float calificacion in lista)
            {
                if (calificacion > mayorCalificacion)
                    mayorCalificacion = calificacion;

                if (calificacion < menorCalificacion)
                    menorCalificacion = calificacion;

                acumulador += calificacion;
            }

            int cantidadDatos = lista.Count;
            promedio = acumulador / cantidadDatos;

            Console.WriteLine("\nPromedio: " + promedio + "\nMayor calificacion: " + mayorCalificacion + "\nMenor calificacion: " + menorCalificacion);

        }

    }
}
