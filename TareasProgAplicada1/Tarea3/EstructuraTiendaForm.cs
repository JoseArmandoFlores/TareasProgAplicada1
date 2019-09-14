using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareasProgAplicada1.Tarea3
{
    public partial class EstructuraTiendaForm : Form
    {
        public struct Tienda
        {
            public string articulo;
            public decimal precio;
            public string cantidad;
            public decimal total;
        }
        public void limpiar()
        {
            ArticuloTextBox.Text = string.Empty;
            PrecioTextBox.Text = string.Empty;
            CantidadTextBox.Text = string.Empty;
            TotalTextBox.Text = string.Empty;
        }

        public EstructuraTiendaForm()
        {
            InitializeComponent();
        }

        private void EstructuraTiendaForm_Load(object sender, EventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Tienda tienda;

            tienda.articulo = ArticuloTextBox.Text;
            tienda.precio = Convert.ToDecimal(PrecioTextBox.Text);
            tienda.cantidad = CantidadTextBox.Text;
            tienda.total = Convert.ToDecimal(PrecioTextBox.Text) * Convert.ToInt32(CantidadTextBox.Text);

            limpiar();

            MyDataGridView.Rows.Add(tienda.articulo, tienda.precio, tienda.cantidad, tienda.total);
        }
    }
}
