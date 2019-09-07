using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgAplicada1.Tarea2
{
    class FormatoFechaYHora
    {
        private string formato;

        public FormatoFechaYHora() { }

        public void correr()
        {
            formato = String.Format("Fecha:{0: h:m tt   d / M / yyy}", DateTime.Now);
            Console.WriteLine(formato);
        }
    }
}
