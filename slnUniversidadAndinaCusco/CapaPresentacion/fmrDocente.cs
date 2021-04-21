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
    public partial class fmrDocente : Form
    {
        public fmrDocente()
        {
            InitializeComponent();
        }

        //Instanciar la clas a traves de un objeto
        CapaNegocio.Docente docente1 = new CapaNegocio.Docente();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del fromulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            string dni = txtDni.Text;
            DateTime fechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
            string profesion = txtProfesion.Text;
            docente1.Apellidos = apellidos;
            docente1.Nombres = nombres;
            docente1.Dni = dni;
            docente1.FechaNacimiento = fechaNacimiento;
            docente1.Profesion = profesion;
            MessageBox.Show("Se han registrado correctamente los datos del Docente");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string apellidos = docente1.Apellidos;
            string nombres = docente1.Nombres;
            string dni = docente1.Dni;
            DateTime fechaNacimiento = docente1.FechaNacimiento;
            string profesion = docente1.Profesion;
            MessageBox.Show("Apellidos: " + apellidos + "Nombres: " + nombres + "Dni: " + dni + "fecha de Nacimiento: " + fechaNacimiento + "profesion " + profesion);
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Enseñar
            MessageBox.Show(docente1.Enseñar());
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Matricular
            MessageBox.Show(docente1.Matricular());
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Aprobar
            MessageBox.Show(docente1.Aprobar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Desaprobar
            MessageBox.Show(docente1.Desaprobar());
        }
    }
}
