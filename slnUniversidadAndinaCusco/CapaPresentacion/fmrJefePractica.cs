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
    public partial class fmrJefePractica : Form
    {
        public fmrJefePractica()
        {
            InitializeComponent();
        }
        //Instanciar la clas a traves de un objeto
        CapaNegocio.JefePractica JefePractica1 = new CapaNegocio.JefePractica();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del fromulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            string cursoPractico = txtCursoPractico.Text;
            DateTime fechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
            string especialidad = txtEspecialidad.Text;
            JefePractica1.Apellidos = apellidos;
            JefePractica1.Nombres = nombres;
            JefePractica1.CursoPractico = cursoPractico;
            JefePractica1.FechaNacimiento = fechaNacimiento;
            JefePractica1.Especialidad = especialidad;
            MessageBox.Show("Se han registrado correctamente los datos del Jefe de Practica");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string apellidos = JefePractica1.Apellidos;
            string nombres = JefePractica1.Nombres;
            string cursoPractico = JefePractica1.CursoPractico;
            DateTime fechaNacimiento = JefePractica1.FechaNacimiento;
            string especialidad = JefePractica1.Especialidad;
            MessageBox.Show("Apellidos: " + apellidos + "Nombres: " + nombres + "Curso Practico: " + cursoPractico + "fecha de Nacimiento: " + fechaNacimiento + "Especialidad: " + especialidad);
        }

        private void btnDirigir_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Dirigir
            MessageBox.Show(JefePractica1.Dirigir());
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Enseñar
            MessageBox.Show(JefePractica1.Enseñar());
        }

        private void btnAyudar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Ayudar
            MessageBox.Show(JefePractica1.Ayudar());
        }

        private void btnCoordinar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Coordinar
            MessageBox.Show(JefePractica1.Coordinar());
        }
    }
}
