using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Tutor:Persona
    {
        private List<Becado> lstBecados;
        private List<Cita> lstCitas;
        private int idTutor;

        public Tutor()
        {
            lstBecados = new List<Becado>();
            lstCitas = new List<Cita>();
        }

        //añade un becado a la lista de becados x tutor
        public void añadirBecado(Becado b)
        {
            lstBecados.Add(b);
        }

        public void añadirCita(Cita c)
        {
            lstCitas.Add(c);
        }
        public Becado buscarBecado(int codBecado)
        {
            Becado becado1;
            becado1 = new Becado();
            //codigo

            return becado1;
        }
        public List<Becado> LstBecados { get => lstBecados; set => lstBecados = value; }
        public List<Cita> LstCitas { get => lstCitas; set => lstCitas = value; }
        public int IdTutor { get => idTutor; set => idTutor = value; }
    }
}
