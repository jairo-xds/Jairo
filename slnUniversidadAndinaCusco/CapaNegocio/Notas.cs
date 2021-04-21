using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Notas
    {
        //atribute
        private string curso;
        private int peso;
        private string aporte;
        //Propiedades
        public string Curso
        {
            get { return curso; } //Lectura atributo
            set { curso = value; } //Escritura del atributo
        }
        public int Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public string Aporte
        {
            get { return aporte; }
            set { aporte = value; }
        }
        //Metodos u operaciones
        public string Aprobar()
        {
            return "No se ha implementado el metodo aprobar";
        }
        public string Desaprobar()
        {
            return "No se ha implementado el metodo desaprobar ";
        }
        public string Aumentar()
        {
            return "No se ha implementado el metodo aumentar";
        }
        public string Quitar()
        {
            return "No se ha implementado el método quitar";
        }
    }
}
