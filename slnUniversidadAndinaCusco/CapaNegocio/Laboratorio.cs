using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Laboratorio
    {
        //atributos
        private string elementos;
        private int foro;
        private string tipo;
        private int cantidadAlumnos;
        //propiedades
        public string Elementos
        {
            get { return elementos; }
            set { elementos = value; }
        }
        public int Foro
        {
            get { return foro; }
            set { foro = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public int CantidadAlumnos
        {
            get { return this.cantidadAlumnos; }
            set { this.cantidadAlumnos = value; }
        }

        //Metodos u operaciones
        public string Investigar()
        {
            return "No se ha implementado el metodo investigar";
        }
        public string Experimentar()
        {
            return "No se ha implementado el metodo Experimentar";
        }
        public string Aprender()
        {
            return "No se ha implementado el metodo aprender";
        }

    }
}

