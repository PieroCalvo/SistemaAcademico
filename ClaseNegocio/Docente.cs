using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseNegocio
{
    public class Docente : Persona, IMantenimiento
    {
        private string facultad;
        private string grado;

        public string Grado { get => grado; set => grado = value; }
        public string Facultad { get => facultad; set => facultad = value; }

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