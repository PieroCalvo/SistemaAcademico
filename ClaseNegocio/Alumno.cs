using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNegocio
{
    public class Alumno : Persona, IMantenimiento
    {
        // atributos
        private bool seguro;
        private string escuela;

        // propiedades
        public bool Seguro { get => seguro; set => seguro = value; }
        public string Escuela { get => escuela; set => escuela = value; }

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

        // metodos

    }
}
