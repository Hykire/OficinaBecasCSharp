using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Tutor:Persona
    {
        private List<Cita> lstCitas;
        private int idTutor;

        private int idCoord;
        public Tutor() { lstCitas = new List<Cita>(); }
        public int IdTutor { get => idTutor; set => idTutor = value; }
        public int IdCoord { get => idCoord; set => idCoord = value; }
    }
}
