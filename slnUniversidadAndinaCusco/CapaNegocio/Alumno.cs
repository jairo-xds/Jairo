﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Alumno
    {
        //atributos
        private string apellidos;
        private string nombres;
        private int edad;
        private string lugarNacimiento;
        //propiedades
        public string Apellidos
        {
            get { return apellidos; } // Lectura de atributo
            set { apellidos = value; } // Escrbir atributo
        }
        public string Nombres
        {
            get { return nombres; } 
            set { nombres = value; } 
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string LugarNacimiento
        {
            get { return this.lugarNacimiento; }
            set { this.lugarNacimiento = value; }
        }

        //Metodos u operaciones
        public string Estudiar()
        {
            return "No se ha implementado el metodo estudiar";
        }
        public string Trabajar()
        {
            return "No se ha implementado el metodo trabajar";
        }
        public string AprobarExamen()
        {
            return "No se ha implementado el metodo aporbar examen";
        }
    }
}
