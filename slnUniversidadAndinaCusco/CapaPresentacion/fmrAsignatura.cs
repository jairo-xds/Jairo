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
    public partial class fmrAsignatura : Form
    {
        public fmrAsignatura()
        {
            InitializeComponent();
        }

        //Instanciar la clas a traves de un objeto
        CapaNegocio.Asignatura Asignatura1 = new CapaNegocio.Asignatura();

        private void txtEspecialidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAprender_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Aprender
            MessageBox.Show(Asignatura1.Aprender());
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del fromulario
            string especialidad = txtEspecialidad.Text;
            string idiomas = txtIdiomas.Text;
            int aulas = int.Parse(txtAulas.Text);
            Asignatura1.Especialidad = especialidad;
            Asignatura1.Idiomas = idiomas;
            Asignatura1.Aula = aulas;
            MessageBox.Show("Se han registrado correctamente los datos de la Asignatura");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string especialidad = Asignatura1.Especialidad;
            string idiomas = Asignatura1.Idiomas;
            int aulas = Asignatura1.Aula;
            MessageBox.Show("Especialidad: " + especialidad + "Idiomas: " + idiomas + "Aulas: " + aulas);
        }

        private void btnClasificar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Clasificar
            MessageBox.Show(Asignatura1.Clasificar());
        }

        private void btnConocer_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Conocer
            MessageBox.Show(Asignatura1.Conocer());
        }
    }
}
