using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgAplicada1.Tarea2
{
    class Agenda
    {
        private int cantidad;
        public Agenda() { }
        class Persona{
            public string nombre, numero;
            public Persona() { }
        }
        public void guardar()
        {
            Persona p = new Persona();
            ArrayList lista = new ArrayList();

            Console.Write("Digite la cantidad de numeros que desea almacenar en la agenda: ");
            cantidad = int.Parse(Console.ReadLine());

            for (int x = 0; x < cantidad; x++)
            {
                Console.Write("\nEscriba el nombre de la persona ["+(x+1)+"]: ");
                p.nombre = Console.ReadLine();

                Console.Write("Escriba el numero de la persona [" + (x + 1) + "]: ");
                p.numero = Console.ReadLine();

                lista.Add(p);
            }
        }
    }
}
