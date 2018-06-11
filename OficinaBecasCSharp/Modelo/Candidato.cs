using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Candidato : Persona
    {
        private bool estadoPostulacion;
        private bool estadoSeleccion;

        public bool EstadoPostulacion { get => estadoPostulacion; set => estadoPostulacion = value; }
        public bool EstadoSeleccion { get => estadoSeleccion; set => estadoSeleccion = value; }

        public string Postulante { get => estadoPostulacion == true ? "Sí" : "No"; }
        public string Seleccionado { get => estadoSeleccion == true ? "Sí" : "No"; }
    }
}
