using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseNegocio
{
    public class Administrativo : Persona, IMantenimiento
    {
        private string facultad;
        private string labor;
        private string experiencia;

        public string Facultad { get => facultad; set => facultad = value; }
        public string Labor { get => labor; set => labor = value; }
        public string Experiencia { get => experiencia; set => experiencia = value; }

        public bool Actualizar()
        {
            throw new NotImplementedException();
        }

        public bool Agregar()
        {
            throw new NotImplementedException();
        }

        public string Buscar()
        {
            throw new NotImplementedException();
        }

        public bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public bool Listar()
        {
            throw new NotImplementedException();
        }
    }
}