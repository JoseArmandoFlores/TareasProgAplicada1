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
    public partial class FactorialForm : Form
    {
        public FactorialForm()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            int numero;

            numero = Convert.ToInt32(NumeroTextBox.Text);

            for (int i = numero - 1; i > 1; i--)
            {
                numero = numero * i;
                Console.WriteLine("{0}\n", numero);
            }
            Console.WriteLine("\nEl factorial es: {0}", numero);
            FactorialTextBox.Text = Convert.ToString(numero);
        }
    }
}
