using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgAplicada1.Tarea2
{
    class Diccionario
    {
        private string palabra;
        public Diccionario() { }

        public void correr()
        {
            Hashtable tabla = new Hashtable();

            tabla.Add("Mancuerna", "Pieza de equipamiento utilizada en el entrenamiento con pesas, es un tipo de peso libre.");
            tabla.Add("Materia", "Todo lo que posee mata y ocupa un lugar en el espacio.");
            tabla.Add("Cedula", "Documento que contiene datos personales.");

            Console.WriteLine("1. Cedula\n2. Mancuerna\n3. Materia");
            Console.Write("Esriba la palabra que a buscar: ");
            palabra = Console.ReadLine();

            Console.WriteLine("\n"+tabla[palabra]);
        }
    }
}
