using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Solicitud
    {
        private int id_solicitud;
        private DateTime fecha_soli;
        private Beca beca;
        private Persona postulante;
        private string estado_beca;
        private string estado_progreso;

        public Beca _beca { get => beca; set => beca = value; }
        public Persona _postulante { get => postulante; set => postulante = value; }
        public int _id_solicitud { get => id_solicitud; set => id_solicitud = value; }
        public string _estado_beca { get => estado_beca; set => estado_beca = value; }
        public string _estado_progreso { get => estado_progreso; set => estado_progreso = value; }
    }
}
