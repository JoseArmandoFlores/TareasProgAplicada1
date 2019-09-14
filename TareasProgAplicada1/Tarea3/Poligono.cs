using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgAplicada1.Tarea3
{
    class Poligono
    {
        public int cantidadLados { get; set; }
        public float longitud { get; set; }
        public float apotema { get; set; }

        public Poligono(int cantidadlados, float longitud, float apotema)
        {
            this.cantidadLados = cantidadlados;
            this.longitud = longitud;
            this.apotema = apotema;
        }

        public override string ToString()
        {
            String mostrar = "";
            mostrar += "Cantidad de lados: " + longitud.ToString() + " \nLongitud de cada lado:  " +
            cantidadLados.ToString() + "\nApotema " + apotema.ToString();

            return mostrar;
        }
    }
}
