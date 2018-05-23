using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Especialidad
    {
        private int _id_especialidad;
        private string _nombre;
        private Facultad _facultad;

        public override string ToString() { return _nombre; }

        public int Id_especialidad { get => _id_especialidad; set => _id_especialidad = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public Facultad Facultad { get => _facultad; set => _facultad = value; }
    }

}
