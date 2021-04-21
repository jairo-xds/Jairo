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
    public partial class fmrAlumno : Form
    {
        public fmrAlumno()
        {
            InitializeComponent();
        }

        //Instanciar la clas a traves de un objeto
        CapaNegocio.Alumno alumno1 = new CapaNegocio.Alumno();

        private void button1_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Estudiar
            MessageBox.Show(alumno1.Estudiar());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Leer los datos del fromulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            string lugarNacimiento = txtLugarNacimiento.Text;
            alumno1.Apellidos = apellidos;
            alumno1.Nombres = nombres;
            alumno1.Edad = edad;
            alumno1.LugarNacimiento = lugarNacimiento;
            MessageBox.Show("Se han registrado correctamente los datos de alumno 1");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string apellidos = alumno1.Apellidos;
            string nombres = alumno1.Nombres;
            int edad = alumno1.Edad;
            string lugarNacimiento = alumno1.LugarNacimiento;
            MessageBox.Show("Apellidos: " + apellidos + "Nombres: " + nombres + "Edad: " + edad + "Lugar Nacimiento: " + lugarNacimiento);
        }

        private void btnAprobarExamen_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion AprobarExamen
            MessageBox.Show(alumno1.AprobarExamen());
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Trabajar
            MessageBox.Show(alumno1.Trabajar());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLugarNacimiento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
