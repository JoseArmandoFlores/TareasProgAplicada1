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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CrearUnaEstructuraParaGuardarLosProductosDeUnaTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstructuraTiendaForm tienda = new EstructuraTiendaForm();
            tienda.MdiParent = this;
            tienda.Show();
        }

        private void CrearEstructurasEnlazadasParaGuardarLaInformacionDeUnaMascotaYSuDueñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstructurasEnlazadasForm estructEnlazada = new EstructurasEnlazadasForm();
            estructEnlazada.MdiParent = this;
            estructEnlazada.Show();
        }

        private void CrearUnaEnumeracionParaLosDiferentesTiposDeNeumaticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TiposDeNeumaticosForm neumaticos = new TiposDeNeumaticosForm();
            neumaticos.MdiParent = this;
            neumaticos.Show();
        }

        private void CrearUnaClaseDeLosEstudiantesDeUnaEscuelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstudiantesForm estudiantes = new EstudiantesForm();
            estudiantes.MdiParent = this;
            estudiantes.Show();
        }

        private void CrearUnaClaseParaPoligonosConSobrecargaDeConstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void UsarLaDepuracionPasoAPasoParaObservarComoCambiaElValorDeLaVariableEnElProgramaDeFactorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FactorialForm factorial = new FactorialForm();
            factorial.MdiParent = this;
            factorial.Show();
        }
    }
}
