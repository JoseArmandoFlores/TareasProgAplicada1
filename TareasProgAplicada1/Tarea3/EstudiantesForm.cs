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
    public partial class EstudiantesForm : Form
    {
        public void limpiar()
        {
            NombreTextBox.Text = string.Empty;
            EdadTextBox.Text = string.Empty;
            CursoTextBox.Text = string.Empty;
            NumeroTextBox.Text = string.Empty;
        }
        public EstudiantesForm()
        {
            InitializeComponent();
        }

        private void DisenoClaseInventarioForm_Load(object sender, EventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Estudiantes estudiantes = new Estudiantes();

            estudiantes.nombre = NombreTextBox.Text;
            estudiantes.edad = Convert.ToInt32(EdadTextBox.Text);
            estudiantes.curso = CursoTextBox.Text;
            estudiantes.numero = Convert.ToInt32(NumeroTextBox.Text);

            limpiar();
        }
    }
}
