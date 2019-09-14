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
    public partial class TiposDeNeumaticosForm : Form
    {
        enum TiposNeumaticos
        {
            Asimétricos, Tubuless, Runflat, Recauchutados, PerfilBajo, Invierno, Diagonal,Verdes
        }
        public TiposDeNeumaticosForm()
        {
            InitializeComponent();
        }

        private void ResultadoLabel_Click(object sender, EventArgs e)
        {

        }

        private void TiposDeNeumaticosForm_Load(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            TipoTextBox.Text = Enum.GetName(typeof(TiposNeumaticos), Convert.ToInt32(BuscarTextBox.Text));
        }
    }
}
