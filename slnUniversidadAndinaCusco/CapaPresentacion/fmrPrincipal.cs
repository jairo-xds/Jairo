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
    public partial class fmrPrincipal : Form
    {
        public fmrPrincipal()
        {
            InitializeComponent();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario del alumno
            fmrAlumno formulario = new fmrAlumno();
            formulario.Show();
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario Docente
            fmrDocente formulario = new fmrDocente();
            formulario.Show();
        }

        private void asignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario de la Asignatura
            fmrAsignatura formulario = new fmrAsignatura();
            formulario.Show();
        }

        private void jefePracticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario del jefe de practica
            fmrJefePractica formulario = new fmrJefePractica();
            formulario.Show();
        }

        private void laboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario del laboratorio
            fmrLaboratorio formulario = new fmrLaboratorio();
            formulario.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario de Notas
            fmrNotas formulario = new fmrNotas();
            formulario.Show();
        }

        private void rectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario de Notas
            fmrRector formulario = new fmrRector();
            formulario.Show();
        }

        private void pPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario de Notas
            fmrPPP formulario = new fmrPPP();
            formulario.Show();
        }
    }
}
