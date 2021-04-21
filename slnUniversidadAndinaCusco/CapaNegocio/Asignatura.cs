using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Asignatura
    {
        //atributos
        private string especialidad;
        private string idiomas;
        private int aula;
        //propiedades
        public string Especialidad
        {
            get { return especialidad; } // Lectura de atributo
            set { especialidad = value; } // Escrbir atributo
        }
        public string Idiomas
        {
            get { return idiomas; }
            set { idiomas = value; }
        }
        public int Aula
        {
            get { return aula; }
            set { aula = value; }
        }

        //Metodos u operaciones
        public string Aprender()
        {
            return "No se ha implementado el metodo Aprender";
        }
        public string Clasificar()
        {
            return "No se ha implementado el metodo Clasificar";
        }
        public string Conocer()
        {
            return "No se ha implementado el metodo Conocer";
        }
    }
}

    

