using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class PPP
    {
        private string apellidos;
        private string nombres;
        private string dni;
        private string carrera;
        private string semestre;
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public string Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }

        //Metodos u operaciones
        public string Aprender()
        {
            return "No se ha implementado el metodo aprender";
        }
        public string AdquirirConocimientoPractico()
        {
            return "No se ha implementado el metodo Adquirir Conocimiento Practico";
        }
        public string Desarrollarnos()
        {
            return "No se ha implementado el metodo Desarrollarnos";
        }
    }
}
