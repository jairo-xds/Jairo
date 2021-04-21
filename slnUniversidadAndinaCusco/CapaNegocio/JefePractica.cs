using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class JefePractica
    {
        //atributos
        private string apellidos;
        private string nombres;
        private string cursoPractico;
        private DateTime fechaNacimiento;
        private string especialidad;
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
        public string CursoPractico
        {
            get { return cursoPractico; }
            set { cursoPractico = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return this.fechaNacimiento; }
            set { this.fechaNacimiento = value; }
        }
        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }

        //Metodos u operaciones
        public string Dirigir()
        {
            return "No se ha implementado el metodo dirigir";
        }
        public string Enseñar()
        {
            return "No se ha implementado el metodo Enseñar";
        }
        public string Ayudar()
        {
            return "No se ha implementado el metodo ayudar";
        }
        public string Coordinar()
        {
            return "No se ha implementado el metodo coordinar";
        }
    }
}