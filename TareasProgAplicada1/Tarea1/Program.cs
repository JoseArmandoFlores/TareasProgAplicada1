using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareasProgAplicada1.Tarea1;

namespace TareasProgAplicada1
{
    class Program
    {
        static int opcion;
        static void Main(string[] args){
            Nombre n = new Nombre();
            Perimetro p = new Perimetro();
            Radianes cr = new Radianes();
            Grados cg = new Grados();
            Divisas div = new Divisas();
            ParOImpar par = new ParOImpar();
            Semana s = new Semana();
            Area a = new Area();
            TablaMultiplicar tm = new TablaMultiplicar();
            Potencia pot = new Potencia();
            Edades e = new Edades();
            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\tEjercicios Tarea 1");
                Console.WriteLine("\n\tCapitulo I\n1. Imprimir Nombre\n2. Agregar Mensajes\n\n\tCapitulo II\n3. Calcular Perimetro de Poligono Regular" +
                    "\n4. Convertir de Grados a Radianes\n5. Convertir de Grados Centigrados a Grados Fahrenheit\n6. Convertir entre Dolares & Euros\n" +
                    "\n\tCapitulo III\n7. Par o Impar\n8. Dia de la Semana\n9. Calcular Area o Perimetro de Poligono Regular\n\n\tCapitulo IV\n10.Tabla de Multiplicar" +
                    "\n11.Calcular Potencia\n12.Promedio de Edades\n13.Salir");

                Console.Write("\nEscriba el numero del programa que desea ejecutar: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        n.mostrarNombre();
                        break;
                    case 2:
                        Console.Clear();
                        n.mensajes();
                        break;
                    case 3:
                        Console.Clear();
                        p.calcularPerimetro();
                        break;
                    case 4:
                        Console.Clear();
                        cr.convertir();
                        break;
                    case 5:
                        Console.Clear();
                        cg.convertir();
                        break;
                    case 6:
                        Console.Clear();
                        div.convertir();
                        break;
                    case 7:
                        Console.Clear();
                        par.esParOImpar();
                        break;
                    case 8:
                        Console.Clear();
                        s.diaSemana();
                        break;
                    case 9:
                        Console.Clear();
                        a.calcularAreaOPerimetro();
                        break;
                    case 10:
                        Console.Clear();
                        tm.mostrarTabla();
                        break;
                    case 11:
                        Console.Clear();
                        pot.elevar();
                        break;
                    case 12:
                        Console.Clear();
                        e.calcularPromedio();
                        break;
                }
                Console.ReadKey();
            } while (opcion != 13); 
        }
    }
}
