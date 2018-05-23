using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Facultad {
        private int _id_facultad;
        private string _nombre;
        private char _pabellon;

        public override string ToString() { return _nombre; }

        public int Id_facultad { get => _id_facultad; set => _id_facultad = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public char Pabellon { get => _pabellon; set => _pabellon = value; }
    }
}
