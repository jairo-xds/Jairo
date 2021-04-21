using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class fmrPPP : Form
    {
        public fmrPPP()
        {
            InitializeComponent();
        }
        // Instanciar la clase a traves de un objeto
        // En esta parte del codigo se declaran variables globales
        CapaNegocio.PPP Ppp1 = new CapaNegocio.PPP();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            string dni = txtDni.Text;
            string carrera = txtCarrera.Text;
            string semestre = txtSemestre.Text;
            Ppp1.Apellidos = apellidos;
            Ppp1.Nombres = nombres;
            Ppp1.Dni = dni;
            Ppp1.Carrera = carrera;
            Ppp1.Semestre = semestre;
            MessageBox.Show("Se ha registrado correctamente los datos del PPP");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string apellidos = Ppp1.Apellidos;
            string nombres = Ppp1.Nombres;
            string dni = Ppp1.Dni;
            string carrera = Ppp1.Carrera;
            string semestre = Ppp1.Semestre;
            MessageBox.Show("Apellidos: " + apellidos + "   Nombres: " + nombres + "   Edad: " + dni + "   Profesion: " + carrera + "   Ocupacion: " + semestre);
        }

        private void btnAprender_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operación Aprender
            MessageBox.Show(Ppp1.Aprender());
        }

        private void btnAdquirirConocimientoPractico_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operación AdquirirConocimientoPractico
            MessageBox.Show(Ppp1.AdquirirConocimientoPractico());
        }

        private void btnDesarrollarnos_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operación Desarrollarnos
            MessageBox.Show(Ppp1.Desarrollarnos());
        }
    }
}
