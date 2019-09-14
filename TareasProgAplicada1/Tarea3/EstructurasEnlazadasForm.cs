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
    public partial class EstructurasEnlazadasForm : Form
    {
        public struct Mascota
        {
            public string nombreDueño;
            public string edadDueño;
            public string cedula;
            public string nombreMascota;
            public string edadMascota;
            public string raza;
        }
        public void limpiar()
        {
            NombrePersonaTextBox.Text = string.Empty;
            NombreMascotaTextBox.Text = string.Empty;
            EdadMascotaTextBox.Text = string.Empty;
            EdadPersonaTextBox.Text = string.Empty;
            CedulaTextBox.Text = string.Empty;
            RazaTextBox.Text = string.Empty;
        }
        public EstructurasEnlazadasForm()
        {
            InitializeComponent();
        }

        private void EstructurasEnlazadasForm_Load(object sender, EventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Mascota mascota;

            mascota.nombreDueño = NombrePersonaTextBox.Text;
            mascota.nombreDueño = NombreMascotaTextBox.Text;
            mascota.edadMascota = EdadMascotaTextBox.Text;
            mascota.edadDueño = EdadPersonaTextBox.Text;
            mascota.cedula = CedulaTextBox.Text;
            mascota.raza = RazaTextBox.Text;

            limpiar();
            MyDataGridView.Rows.Add(mascota.nombreDueño, mascota.edadDueño, mascota.edadDueño, NombreMascotaTextBox.Text, mascota.edadMascota, mascota.raza);
        }
    }
}
