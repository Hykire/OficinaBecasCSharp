using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Tutor:Persona
    {
        //private List<Becado> lstBecados;
        private List<Cita> lstCitas;
        private int idTutor;

       /// private char estadoT; //añadido
        private int idCoord;
        public Tutor()
        {
            //lstBecados = new List<Becado>();
            lstCitas = new List<Cita>();
        }

        //public List<Becado> LstBecados { get => lstBecados; set => lstBecados = value; }
       // public List<Cita> LstCitas { get => lstCitas; set => lstCitas = value; }
        public int IdTutor { get => idTutor; set => idTutor = value; }
       // public char EstadoT { get => estadoT; set => estadoT = value; }
        public int IdCoord { get => idCoord; set => idCoord = value; }
    }
}
