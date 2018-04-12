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

        public Beca _beca
        {
            set
            {
                beca = value;
            }
            get
            {
                return beca;
            }
        }
        public Persona _postulante
        {
            set
            {
                postulante = value;
            }
            get
            {
                return postulante;
            }
        }
        public int _id_solicitud
        {
            set
            {
                id_solicitud = value;
            }
            get
            {
                return id_solicitud;
            }
        }

        public string _estado_beca
        {
            set
            {
                estado_beca = value;
            }
            get
            {
                return estado_beca;
            }
        }
        public string _estado_progreso
        {
            set
            {
                estado_progreso = value;
            }
            get
            {
                return estado_progreso;
            }
        }
    }
}
