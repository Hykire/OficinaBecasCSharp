using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Candidato : Persona
    {
        private int idCandidato;
        private string estadoPostulacion;
        private string estadoSeleccion;

        public int IdCandidato { get => idCandidato; set => idCandidato = value; }
        public string EstadoPostulacion { get => estadoPostulacion; set => estadoPostulacion = value; }
        public string EstadoSeleccion { get => estadoSeleccion; set => estadoSeleccion = value; }
    }
}
