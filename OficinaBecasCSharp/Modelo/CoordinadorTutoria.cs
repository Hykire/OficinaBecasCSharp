using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class CoordinadorTutoria : Persona
    {
        private List<Tutor> tutores;
        
        public CoordinadorTutoria()
        {
            tutores = new List<Tutor>();
        }

        public List<Tutor> Tutores
        {
            set
            {
                tutores = value;
            }
            get
            {
                return tutores;
            }
        }

    }
}
