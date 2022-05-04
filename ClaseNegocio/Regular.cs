using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseNegocio
{
    public class Regular : Alumno
    {
        private string grupo;
        private string creditos;
        public string Grupo { get => grupo; set => grupo = value; }
        public string Creditos { get => creditos; set => creditos = value; }

        public string Matricular()
        {
            throw new System.NotImplementedException();
        }

        public string Aprender()
        {
            throw new System.NotImplementedException();
        }
    }
}