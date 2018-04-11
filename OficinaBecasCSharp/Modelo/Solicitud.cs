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
        private DateTime fechaRegistrada;
        private Beca beca;
        private Persona postulante;

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
    }
}
