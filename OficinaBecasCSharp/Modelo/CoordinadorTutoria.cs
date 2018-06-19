using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CoordinadorTutoria : Persona
    {
        private List<Tutor> tutores;
        private int id_coordinador;
        public CoordinadorTutoria() { tutores = new List<Tutor>(); }

        public List<Tutor> Tutores { get => tutores; set => tutores = value; }

        public int Id_coordinador { get => id_coordinador; set => id_coordinador = value; }
    }
}
