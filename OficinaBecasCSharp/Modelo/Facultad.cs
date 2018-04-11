using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo {
    class Facultad {
        private int idFacultad; //Puede ser un string
        private string nombre;
        private char pabellon;

        public int IdFacultad { get => idFacultad; set => idFacultad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public char Pabellon { get => pabellon; set => pabellon = value; }
    }
}
