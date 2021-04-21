using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Docente
    {
        //atributos
        private string apellidos;
        private string nombres;
        private string dni;
        private DateTime fechaNacimiento;
        private string profesion;
        //propiedades
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
        public DateTime FechaNacimiento
        {
            get { return this.fechaNacimiento; }
            set { this.fechaNacimiento = value; }
        }
        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }

        //Metodos u operaciones
        public string Enseñar()
        {
            return "No se ha implementado el metodo enseñar";
        }
        public string Matricular()
        {
            return "No se ha implementado el metodo matricular";
        }
        public string Aprobar()
        {
            return "No se ha implementado el metodo aprobar examen";
        }
        public string Desaprobar()
        {
            return "No se ha implementado el metodo desaprobar examen";
        }
    }
}
