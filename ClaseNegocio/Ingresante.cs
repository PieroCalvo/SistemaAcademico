using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseNegocio
{
    public class Ingresante : Alumno
    {
        private string puestoIngreso;
        private string grupo;
        public string PuestoIngreso { get => puestoIngreso; set => puestoIngreso = value; }
        public string Grupo { get => grupo; set => grupo = value; }

        public string Aprender()
        {
            throw new System.NotImplementedException();
        }

        public string Matricular()
        {
            throw new System.NotImplementedException();
        }
    }
}