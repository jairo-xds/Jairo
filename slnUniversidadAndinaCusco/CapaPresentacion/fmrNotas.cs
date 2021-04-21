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
    public partial class fmrNotas : Form
    {
        public fmrNotas()
        {
            InitializeComponent();
        }
        // Instanciar la clase a traves de un objeto
        // En esta parte del codigo se declaran variables globales
        CapaNegocio.Notas notas1 = new CapaNegocio.Notas();
        
        private void button4_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Quitar
            MessageBox.Show(notas1.Quitar());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string curso = notas1.Curso;
            int peso = notas1.Peso;
            string aporte = notas1.Aporte;
            MessageBox.Show("Curso: " + curso + "Valor: " + peso + "Aporte:" + aporte);
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer datos del formulario
            string curso = txtCurso.Text;
            int peso = int.Parse(txtPeso.Text);
            string aporte = txtAporte.Text;
            notas1.Curso = curso;
            notas1.Peso = peso;
            notas1.Aporte = aporte;
            MessageBox.Show("Se han registrado correctamente los datos de Notas1");
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Aprobar
            MessageBox.Show(notas1.Aprobar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Desaprobar
            MessageBox.Show(notas1.Desaprobar());
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            //Mostrar el metodo u operacion Aumentar
            MessageBox.Show(notas1.Aumentar());
        }
    }
}
