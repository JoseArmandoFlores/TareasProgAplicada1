using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgAplicada1.Tarea3
{
    class Tienda
    {
        public string articulo { get; set; }
        public string descripcion { get; set; }
        public decimal precioVenta { get; set; }
        public int cantidad { get; set; }
        public decimal precioCompra { get; set; }

        public Tienda(string articulo, string descripcion, decimal precioVenta, int cantidad, decimal precioCompra)
        {
            this.articulo = articulo;
            this.descripcion = descripcion;
            this.precioVenta = precioVenta;
            this.cantidad = cantidad;
            this.precioCompra = precioCompra;
        }
    }
}
